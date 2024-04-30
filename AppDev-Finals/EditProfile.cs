using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppDev_Finals
{
    public partial class EditProfile : Form
    {
        Functions f = new Functions();
        User user;
        string email;
        public EditProfile()
        {
            
            
        }

        public void SetImageFromByteArray1(PictureBox Image_cont, byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    Image_cont.Image = image;
                }
            }
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
