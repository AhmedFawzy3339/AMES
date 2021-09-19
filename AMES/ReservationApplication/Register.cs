using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationApplication
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegOk_Click(object sender, EventArgs e)
        {

            AirbnbDBEntities1 Ent = new AirbnbDBEntities1();
            User user = new User();
            user.User_Name = RegisterName.Text;
            user.User_Phone = Phone.Text;
            user.User_Email = Email.Text;
            user.User_Password = Pass.Text;



            Ent.Users.Add(user);
            if (CPass.Text == Pass.Text)
            {
                Ent.SaveChanges();
                RegisterName.Text = Phone.Text = Email.Text = Pass.Text = CPass.Text = string.Empty;
                MessageBox.Show("Register Successed");
                this.Close();
            }
            else
                MessageBox.Show("Password doesn't Match!!");
        }

        private void RegCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
