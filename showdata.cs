using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace BAU_Project
{
    public partial class showdata : Form
    {
        public int id;
        public showdata()
        {
            InitializeComponent();
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=patrol;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);

            string query = "SELECT * FROM customer;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            cnn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);

            dataview.DataSource = dTable;

            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Hide();
        }

        private void dataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataview.SelectedRows[0].Cells[0].Value.ToString());
            name_box.Text = dataview.SelectedRows[0].Cells[1].Value.ToString();
            phone_box.Text = dataview.SelectedRows[0].Cells[2].Value.ToString();
            email_box.Text = dataview.SelectedRows[0].Cells[3].Value.ToString();
            oil_box.Text = dataview.SelectedRows[0].Cells[4].Value.ToString();
            litre_box.Text = dataview.SelectedRows[0].Cells[5].Value.ToString();
            taka_box.Text = dataview.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string phone = phone_box.Text;
            string email = email_box.Text;
            string oil = oil_box.Text;
            string litre = litre_box.Text;
            string taka = taka_box.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Select a data from the table");
            }
            else
            {
                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=patrol;uid=root;pwd=\"\";";
                cnn = new MySqlConnection(connetionString);

                try
                {
                    cnn.Open();
                    string updateQ = "UPDATE customer set name='" + name + "', phone='" + phone + "', email='" + email + "', oil='" + oil + "', litre='" + litre + "', taka='" + taka + "' WHERE id='" + id + "'";
                    MySqlCommand cmd = new MySqlCommand(updateQ, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been updated successfully");
                    MessageBox.Show("Press Refresh Button");
                    cnn.Close();

                    name_box.Text = null;
                    phone_box.Text = null;
                    email_box.Text = null;
                    oil_box.Text = null;
                    litre_box.Text = null;
                    taka_box.Text = null;
                    id = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }

            
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            
            name_box.Text = null;
            phone_box.Text = null;
            email_box.Text = null;
            oil_box.Text = null;
            litre_box.Text = null;
            taka_box.Text = null;
            id = 0;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=patrol;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);

            string query = "SELECT * FROM customer;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            cnn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);

            dataview.DataSource = dTable;

            cnn.Close();

            name_box.Text = null;
            phone_box.Text = null;
            email_box.Text = null;
            oil_box.Text = null;
            litre_box.Text = null;
            taka_box.Text = null;
            id = 0;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Select a data from the table");
            }
            else
            {
                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=patrol;uid=root;pwd=\"\";";
                cnn = new MySqlConnection(connetionString);

                cnn.Open();
                string deleteQ = "DELETE FROM customer WHERE id='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(deleteQ, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been deleted successfully");
                MessageBox.Show("Press Refresh Button");
                cnn.Close();
                id = 0;

                name_box.Text = null;
                phone_box.Text = null;
                email_box.Text = null;
                oil_box.Text = null;
                litre_box.Text = null;
                taka_box.Text = null;
                id = 0;
            }

            
        }

        private void add_customer_btn_Click(object sender, EventArgs e)
        {
            addCustomer addc = new addCustomer();
            addc.Show();
            this.Hide();
        }
    }
}
