using Google.Protobuf;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace BAU_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_button(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string email = email_box.Text;
            string mobile = mobile_box.Text;
            string password = password_box.Text;
            string confirm_password = confirm_password_box.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter Name");
            }
            else if (string.IsNullOrEmpty(email)) 
            {
                MessageBox.Show("Enter Email");
            }
            else if (string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Enter Mobile");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter Password");
            }
            else if (string.IsNullOrEmpty(confirm_password))
            {
                MessageBox.Show("Enter Confirm Password");
            }
            else if(confirm_password != password)
            {
                MessageBox.Show("Password does not match");
            }

            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(mobile) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirm_password) && password == confirm_password)
            {
                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=patrol;uid=root;pwd=\"\";";
                cnn = new MySqlConnection(connetionString);

                try
                {
                    cnn.Open();
                    string insertQ = "INSERT INTO user (name,email,mobile,password) VALUES('" + name + "','" + email + "','" + mobile + "','" + password + "')";
                    MySqlCommand cmd = new MySqlCommand(insertQ, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been registered Successfully");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }



            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_page_btn_Click(object sender, EventArgs e)
        {
            var loginPage = new Form2();
            loginPage.Show();
            this.Hide();
        }
    }
}