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

namespace BAU_Project
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string phone = phone_box.Text;
            string email = email_box.Text;
            string oil = oil_box.Text;
            string litre = litre_box.Text;
            string taka = taka_box.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter Name");
            }
            else if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Enter Phone");
            }
            else if (string.IsNullOrEmpty(oil))
            {
                MessageBox.Show("Enter Fuel Type");
            }
            else if (string.IsNullOrEmpty(litre))
            {
                MessageBox.Show("Enter How much litre");
            }
            else if (string.IsNullOrEmpty(taka))
            {
                MessageBox.Show("Enter Payment");
            }
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(oil) && !string.IsNullOrEmpty(litre) && !string.IsNullOrEmpty(taka)) {

                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=patrol;uid=root;pwd=\"\";";
                cnn = new MySqlConnection(connetionString);

                try
                {
                    cnn.Open();
                    string insertQ = "INSERT INTO customer (name,phone,email,oil,litre,taka) VALUES('" + name + "','" + phone + "','" + email + "','" + oil + "','" + litre + "','" + taka + "')";
                    MySqlCommand cmd = new MySqlCommand(insertQ, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been saved successfully");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }

            }
            

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Hide();
        }

        private void show_data_btn_Click(object sender, EventArgs e)
        {
            showdata datas = new showdata();
            datas.Show();
            this.Hide();
        }
    }
}
