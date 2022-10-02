namespace BAU_Project
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_customer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.show_all_customer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.about_us_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_customer
            // 
            this.add_customer.Location = new System.Drawing.Point(324, 147);
            this.add_customer.Name = "add_customer";
            this.add_customer.Size = new System.Drawing.Size(137, 36);
            this.add_customer.TabIndex = 0;
            this.add_customer.Text = "Add Customer";
            this.add_customer.UseVisualStyleBackColor = true;
            this.add_customer.Click += new System.EventHandler(this.add_customer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(244, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 41);
            this.label7.TabIndex = 14;
            this.label7.Text = "BAU Patrol Pump 2022";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(324, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dashboard";
            // 
            // show_all_customer
            // 
            this.show_all_customer.Location = new System.Drawing.Point(324, 201);
            this.show_all_customer.Name = "show_all_customer";
            this.show_all_customer.Size = new System.Drawing.Size(137, 36);
            this.show_all_customer.TabIndex = 16;
            this.show_all_customer.Text = "Update";
            this.show_all_customer.UseVisualStyleBackColor = true;
            this.show_all_customer.Click += new System.EventHandler(this.show_all_customer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Show All Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(326, 306);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(135, 36);
            this.logout_btn.TabIndex = 18;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // about_us_btn
            // 
            this.about_us_btn.Location = new System.Drawing.Point(328, 362);
            this.about_us_btn.Name = "about_us_btn";
            this.about_us_btn.Size = new System.Drawing.Size(135, 34);
            this.about_us_btn.TabIndex = 19;
            this.about_us_btn.Text = "About Us";
            this.about_us_btn.UseVisualStyleBackColor = true;
            this.about_us_btn.Click += new System.EventHandler(this.about_us_btn_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.about_us_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.show_all_customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add_customer);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button add_customer;
        private Label label7;
        private Label label1;
        private Button show_all_customer;
        private Button button1;
        private Button logout_btn;
        private Button about_us_btn;
    }
}