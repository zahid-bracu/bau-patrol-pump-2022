namespace BAU_Project
{
    partial class showdata
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.oil_box = new System.Windows.Forms.TextBox();
            this.litre_box = new System.Windows.Forms.TextBox();
            this.taka_box = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.add_customer_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(275, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 41);
            this.label7.TabIndex = 16;
            this.label7.Text = "BAU Patrol Pump 2022";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(295, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Update Customer Information";
            // 
            // dataview
            // 
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(22, 396);
            this.dataview.Name = "dataview";
            this.dataview.RowTemplate.Height = 25;
            this.dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataview.Size = new System.Drawing.Size(755, 210);
            this.dataview.TabIndex = 19;
            this.dataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataview_CellClick);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Location = new System.Drawing.Point(503, 336);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(121, 35);
            this.dashboard_btn.TabIndex = 20;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Oil Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Litre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Payment :";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(126, 127);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(259, 23);
            this.name_box.TabIndex = 27;
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(126, 173);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(259, 23);
            this.email_box.TabIndex = 28;
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(126, 231);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(259, 23);
            this.phone_box.TabIndex = 29;
            // 
            // oil_box
            // 
            this.oil_box.Location = new System.Drawing.Point(503, 127);
            this.oil_box.Name = "oil_box";
            this.oil_box.Size = new System.Drawing.Size(257, 23);
            this.oil_box.TabIndex = 30;
            // 
            // litre_box
            // 
            this.litre_box.Location = new System.Drawing.Point(503, 178);
            this.litre_box.Name = "litre_box";
            this.litre_box.Size = new System.Drawing.Size(257, 23);
            this.litre_box.TabIndex = 31;
            // 
            // taka_box
            // 
            this.taka_box.Location = new System.Drawing.Point(503, 239);
            this.taka_box.Name = "taka_box";
            this.taka_box.Size = new System.Drawing.Size(257, 23);
            this.taka_box.TabIndex = 32;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(126, 281);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(121, 35);
            this.update_btn.TabIndex = 33;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(264, 281);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(121, 35);
            this.delete_btn.TabIndex = 34;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(503, 281);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(121, 35);
            this.clear_btn.TabIndex = 35;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(639, 281);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(121, 35);
            this.refresh_btn.TabIndex = 36;
            this.refresh_btn.Text = "REFRESH";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // add_customer_btn
            // 
            this.add_customer_btn.Location = new System.Drawing.Point(639, 336);
            this.add_customer_btn.Name = "add_customer_btn";
            this.add_customer_btn.Size = new System.Drawing.Size(121, 35);
            this.add_customer_btn.TabIndex = 37;
            this.add_customer_btn.Text = "Add Customer";
            this.add_customer_btn.UseVisualStyleBackColor = true;
            this.add_customer_btn.Click += new System.EventHandler(this.add_customer_btn_Click);
            // 
            // showdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.add_customer_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.taka_box);
            this.Controls.Add(this.litre_box);
            this.Controls.Add(this.oil_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dashboard_btn);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "showdata";
            this.Text = "showdata";
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Label label1;
        private Button button1;
        private DataGridView dataview;
        private Button dashboard_btn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox name_box;
        private TextBox email_box;
        private TextBox phone_box;
        private TextBox oil_box;
        private TextBox litre_box;
        private TextBox taka_box;
        private Button update_btn;
        private Button delete_btn;
        private Button clear_btn;
        private Button refresh_btn;
        private Button add_customer_btn;
    }
}