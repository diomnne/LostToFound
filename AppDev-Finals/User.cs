using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev_Finals
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Position { get; set; }

        public byte[] ProfilePicture { get; set; }

        public DateTime DateJoined { get; set; }

        public User(int userID, string firstName, string lastName, string email, string password, int position, byte[] profilePicture, DateTime dateJoined)
        {
            this.UserID = userID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Position = position;
            this.ProfilePicture = profilePicture;
            DateJoined = dateJoined;
        }

        public User() { }


    }  
}
