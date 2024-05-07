using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_Finals
{
    public class Functions
    {

        string connection = "server=127.0.0.1;uid=root;pwd=20181024;database=lost_and_found";
        

        public void submitReport(Item item)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();


                    string insertSql = @"INSERT INTO lost_and_found.item (ItemName, PlaceFound, Description, Category, DateFound, TimeFound, ClaimStatus, Image, ReportedBy) 
                     VALUES (@ItemName, @PlaceFound, @Description, @Category, @DateFound, @TimeFound, @ClaimStatus, @Image, @ReportedBy)";

                    MySqlCommand cmd = new MySqlCommand(insertSql, conn);

                    cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                    cmd.Parameters.AddWithValue("@PlaceFound", item.PlaceFound);
                    cmd.Parameters.AddWithValue("@Description", item.Description);
                    cmd.Parameters.AddWithValue("@Category", item.Category);
                    cmd.Parameters.AddWithValue("@DateFound", item.DateFound);
                    cmd.Parameters.AddWithValue("@TimeFound", item.TimeFound);
                    cmd.Parameters.AddWithValue("@ClaimStatus", item.ClaimStatus);

                    if(item.Image != null && item.Image.Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@Image", item.Image);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Image", DBNull.Value);

                    }
                    cmd.Parameters.AddWithValue("@ReportedBy", item.ReportedBy);



                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Submitted successfully!");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        public List<Item> getAllItems()
        {
            List<Item> items = new List<Item>();

            using (MySqlConnection conConn = new MySqlConnection(connection))
            {
                try
                {
                    conConn.Open();


                    string sql = "SELECT * FROM lost_and_found.item ORDER BY ItemID DESC";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.HasRows && reader.Read())
                        {
                            Item item = new Item(); 
                            item.ItemID = reader.GetInt32(0);
                            item.ItemName = reader["ItemName"].ToString();
                            item.PlaceFound = reader["PlaceFound"].ToString();
                            item.Description = reader["Description"].ToString();
                            item.Category = reader["Category"].ToString();
                            item.ReportedBy = reader["ReportedBy"].ToString();
                            item.DateFound = Convert.ToDateTime(reader["DateFound"]);
                            item.TimeFound = Convert.ToDateTime(reader["TimeFound"]);
                            item.ClaimStatus = Convert.ToInt32(reader["ClaimStatus"]);

                            // Check if image data exists (may require conversion)
                            item.Image = reader["Image"] != DBNull.Value ? (byte[])reader["Image"] : null;

                            items.Add(item);
                        }
                    }
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return items;
        }


        public User prevInitializeUser(string email)
        {
            User user = null;  // Consider initializing with default User if needed
            using (MySqlConnection conConn = new MySqlConnection(connection))
            {
                conConn.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM lost_and_found.user WHERE email = @Email", conConn))
                    {
                        command.Parameters.AddWithValue("@Email", email); 
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    
                                    byte[] profilePic = reader["ProfilePicture"] != DBNull.Value ? (byte[])reader["ProfilePicture"] : null;
                                    MessageBox.Show("Hello world");
                                    user = new User((int)reader["UserID"],
                                                     (string)reader["FirstName"],
                                                     (string)reader["LastName"],
                                                     (string)reader["Email"],
                                                     (string)reader["Password"],
                                                     (int)reader["Position"],
                                                     profilePic,
                                                     (DateTime)reader["DateJoined"]);
                                    break;  // Exit loop after finding the first user (if duplicates are not expected)
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Here: " + ex.Message);
                }
            }
            return user;
        }

        public User InitializeUser(string email)
        {
            //MessageBox.Show(email);
            User user = null;  // Consider initializing with default User if needed
            using (MySqlConnection conConn = new MySqlConnection(connection))
            {
                conConn.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM lost_and_found.user WHERE Email = @Email", conConn))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //MessageBox.Show("hERE "+ (int)reader["UserID"] + "" + (string)reader["FirstName"] + "" + (string)reader["LastName"] + "" + (string)reader["Email"] + "" + (string)reader["Password"] + "" + (int)reader["Position"] + "" + (DateTime)reader["DateJoined"]);

                                    byte[] profilePic = reader["ProfilePicture"] != DBNull.Value ? (byte[])reader["ProfilePicture"] : null;
                                    
                                    user = new User();
                                user.UserID = reader.GetInt32(0);
                                user.FirstName = reader["FirstName"].ToString();
                                user.LastName = reader["LastName"].ToString();
                                user.Email = reader["Email"].ToString();
                                user.Password = reader["Password"].ToString();
                                user.Position = Convert.ToInt32(reader["Position"]);
                                user.ProfilePicture = profilePic;
                                user.DateJoined = Convert.ToDateTime(reader["DateJoined"]);
                                break;  // Exit loop after finding the first user (if duplicates are not expected)


                            
                            }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Here: " + ex.Message);
                }
                
            }
            return user;
        }



        public void updateUser(User user)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    // Update statement with WHERE clause to identify the item
                    string updateSql = "UPDATE lost_and_found.user SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE UserID = @UserID;";

                    MySqlCommand cmd = new MySqlCommand(updateSql, conn);

                    // Add parameter for ItemId to identify the record to update
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile Updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void updateReport(Item item)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    // Update statement with WHERE clause to identify the item
                    string updateSql = "UPDATE lost_and_found.item SET ItemName = @ItemName, PlaceFound = @PlaceFound, Description = @Description, Category = @Category, DateFound = @DateFound, TimeFound = @TimeFound, ClaimStatus = @ClaimStatus, Image = @Image WHERE ItemID = @ItemID;";

                    MySqlCommand cmd = new MySqlCommand(updateSql, conn);

                    // Add parameter for ItemId to identify the record to update
                    cmd.Parameters.AddWithValue("@ItemID", item.ItemID); 

                    cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                    cmd.Parameters.AddWithValue("@PlaceFound", item.PlaceFound);
                    cmd.Parameters.AddWithValue("@Description", item.Description);
                    cmd.Parameters.AddWithValue("@Category", item.Category);
                    cmd.Parameters.AddWithValue("@DateFound", item.DateFound);
                    cmd.Parameters.AddWithValue("@TimeFound", item.TimeFound);
                    cmd.Parameters.AddWithValue("@ClaimStatus", item.ClaimStatus);

                    if (item.Image != null && item.Image.Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@Image", item.Image);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Image", DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

        }


        public void updateClaimStatus(int itemId, int newClaimStatus)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                string updateSql = @"UPDATE lost_and_found.item 
                            SET ClaimStatus = @ClaimStatus
                          WHERE ItemId = @ItemId";

                MySqlCommand cmd = new MySqlCommand(updateSql, conn);

                cmd.Parameters.AddWithValue("@ItemId", itemId);
                cmd.Parameters.AddWithValue("@ClaimStatus", newClaimStatus);

                cmd.ExecuteNonQuery();
            }
        }

        public bool changeUserProfile(Byte[] image, int user_id)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                try
                {
                    string sql = "UPDATE lost_and_found.user SET ProfilePicture = @ProfilePic WHERE UserID = @user_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    if (image != null)
                    {
                        cmd.Parameters.AddWithValue("@ProfilePic", image);
                    }
                    else
                    {
                        MessageBox.Show("hello world");
                        cmd.Parameters.AddWithValue("@ProfilePic", DBNull.Value);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected == 1; // Check for exactly one row updated
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }





    }
}
