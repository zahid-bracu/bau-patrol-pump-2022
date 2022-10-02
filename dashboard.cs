using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAU_Project
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void add_customer_Click(object sender, EventArgs e)
        {
            addCustomer addc = new addCustomer();
            addc.Show();
            this.Hide();
        }

        private void show_all_customer_Click(object sender, EventArgs e)
        {
            showdata datas = new showdata();
            datas.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataview dview = new dataview();
            dview.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void about_us_btn_Click(object sender, EventArgs e)
        {
            aboutus abu = new aboutus();
            abu.Show();
            this.Hide();
        }
    }
}
