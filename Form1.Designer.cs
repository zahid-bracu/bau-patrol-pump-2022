namespace BAU_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.mobile_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.confirm_password_box = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.login_page_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(265, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(265, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(219, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(265, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile :";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(415, 120);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(238, 23);
            this.name_box.TabIndex = 5;
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(415, 164);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(238, 23);
            this.email_box.TabIndex = 6;
            // 
            // mobile_box
            // 
            this.mobile_box.Location = new System.Drawing.Point(415, 211);
            this.mobile_box.Name = "mobile_box";
            this.mobile_box.Size = new System.Drawing.Size(238, 23);
            this.mobile_box.TabIndex = 7;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(415, 255);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(238, 23);
            this.password_box.TabIndex = 8;
            // 
            // confirm_password_box
            // 
            this.confirm_password_box.Location = new System.Drawing.Point(415, 306);
            this.confirm_password_box.Name = "confirm_password_box";
            this.confirm_password_box.Size = new System.Drawing.Size(238, 23);
            this.confirm_password_box.TabIndex = 9;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(415, 354);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(110, 38);
            this.Register.TabIndex = 10;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.register_button);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(324, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Register Here";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(265, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "BAU Patrol Pump 2022";
            // 
            // login_page_btn
            // 
            this.login_page_btn.Location = new System.Drawing.Point(549, 354);
            this.login_page_btn.Name = "login_page_btn";
            this.login_page_btn.Size = new System.Drawing.Size(104, 38);
            this.login_page_btn.TabIndex = 13;
            this.login_page_btn.Text = "Login ";
            this.login_page_btn.UseVisualStyleBackColor = true;
            this.login_page_btn.Click += new System.EventHandler(this.login_page_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_page_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.confirm_password_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.mobile_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox name_box;
        private TextBox email_box;
        private TextBox mobile_box;
        private TextBox password_box;
        private TextBox confirm_password_box;
        private Button Register;
        private Label label6;
        private Label label7;
        private Button login_page_btn;
    }
}