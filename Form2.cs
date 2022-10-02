using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BAU_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            var registerPage = new Form1();
            registerPage.Show();
            this.Hide();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string email=email_box.Text;
            string password=password_box.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Enter Email");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter Password");
            }

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(email))
            {
                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=patrol;uid=root;pwd=\"\";";
                cnn = new MySqlConnection(connetionString);

                try
                {
                    cnn.Open();
                    string selectSQL = "SELECT * FROM user WHERE email='" + email + "' and password='" + password + "';";
                    MySqlCommand cmd = new MySqlCommand(selectSQL, cnn);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Login Successfull. Press ok to proceed");
                        dashboard dash = new dashboard();
                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password or Email");
                    }


                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }


            
        }
    }
}
