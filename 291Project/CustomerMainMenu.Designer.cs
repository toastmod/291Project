namespace _291Project
{
    partial class CustomerMainMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.view_curr_res_button = new System.Windows.Forms.Button();
            this.req_res_button = new System.Windows.Forms.Button();
            this.Customer_id_box = new System.Windows.Forms.Label();
            this.custRequestRes1 = new _291Project.CustRequestRes(false);
            this.custViewCurrentRes1 = new _291Project.CustViewCurrentRes();
            this.custViewPastRes1 = new _291Project.custViewPastRes();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Back_btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LogoutBtn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(174, 1197);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(5, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 109);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Home_btn_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(5, 369);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 109);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Exit_btn_click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(5, 127);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(158, 109);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.Location = new System.Drawing.Point(5, 248);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(158, 109);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.Logout_btn_click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.view_curr_res_button, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.req_res_button, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(377, 205);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1092, 706);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // view_curr_res_button
            // 
            this.view_curr_res_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_curr_res_button.Location = new System.Drawing.Point(5, 239);
            this.view_curr_res_button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.view_curr_res_button.Name = "view_curr_res_button";
            this.view_curr_res_button.Size = new System.Drawing.Size(1081, 220);
            this.view_curr_res_button.TabIndex = 1;
            this.view_curr_res_button.Text = "View Reservations";
            this.view_curr_res_button.UseVisualStyleBackColor = true;
            this.view_curr_res_button.Click += new System.EventHandler(this.view_curr_res_button_Click);
            // 
            // req_res_button
            // 
            this.req_res_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.req_res_button.Location = new System.Drawing.Point(5, 6);
            this.req_res_button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.req_res_button.Name = "req_res_button";
            this.req_res_button.Size = new System.Drawing.Size(1081, 220);
            this.req_res_button.TabIndex = 2;
            this.req_res_button.Text = "Request a Reservation";
            this.req_res_button.UseVisualStyleBackColor = true;
            this.req_res_button.Click += new System.EventHandler(this.req_res_button_Click_1);
            // 
            // Customer_id_box
            // 
            this.Customer_id_box.AutoSize = true;
            this.Customer_id_box.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_id_box.Location = new System.Drawing.Point(263, 41);
            this.Customer_id_box.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Customer_id_box.Name = "Customer_id_box";
            this.Customer_id_box.Size = new System.Drawing.Size(131, 33);
            this.Customer_id_box.TabIndex = 2;
            this.Customer_id_box.Text = "Welcome!";
            this.Customer_id_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Customer_id_box.Click += new System.EventHandler(this.Customer_id_box_Click);
            // 
            // custRequestRes1
            // 
            this.custRequestRes1.Location = new System.Drawing.Point(183, 0);
            this.custRequestRes1.Name = "custRequestRes1";
            this.custRequestRes1.Size = new System.Drawing.Size(1462, 1197);
            this.custRequestRes1.TabIndex = 3;
            // 
            // custViewCurrentRes1
            // 
            this.custViewCurrentRes1.Location = new System.Drawing.Point(159, 6);
            this.custViewCurrentRes1.Name = "custViewCurrentRes1";
            this.custViewCurrentRes1.Size = new System.Drawing.Size(1473, 1197);
            this.custViewCurrentRes1.TabIndex = 4;
            // 
            // custViewPastRes1
            // 
            this.custViewPastRes1.Location = new System.Drawing.Point(183, 0);
            this.custViewPastRes1.Name = "custViewPastRes1";
            this.custViewPastRes1.Size = new System.Drawing.Size(1462, 1197);
            this.custViewPastRes1.TabIndex = 5;
            this.custViewPastRes1.Load += new System.EventHandler(this.custViewPastRes1_Load_1);
            // 
            // CustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1641, 1197);
            this.Controls.Add(this.custViewPastRes1);
            this.Controls.Add(this.custViewCurrentRes1);
            this.Controls.Add(this.custRequestRes1);
            this.Controls.Add(this.Customer_id_box);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CustomerMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numved Car Rentals";
            this.Load += new System.EventHandler(this.CustomerMainMenu_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Customer_id_box;
        private System.Windows.Forms.Button view_curr_res_button;
        private System.Windows.Forms.Button req_res_button;
        private System.Windows.Forms.Button Back_btn;
        private CustRequestRes custRequestRes1;
        private CustViewCurrentRes custViewCurrentRes1;
        private _291Project.custViewPastRes custViewPastRes1;
    }
}