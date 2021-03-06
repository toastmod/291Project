namespace _291Project
{
    partial class EmployeeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.emp_logout_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.EmpMainMenuBtnPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Emp_id_box = new System.Windows.Forms.Label();
            this.mainMenuBranchDropdown = new System.Windows.Forms.ComboBox();
            this.EmpCarMenu = new _291Project.EmpCarMenu();
            this.EmpReservationMenu1 = new _291Project.EmpReservationMenu();
            this.empCustomerManagement = new _291Project.EmpCustomerManagement();
            this.tableLayoutPanel1.SuspendLayout();
            this.EmpMainMenuBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Back_btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.emp_logout_btn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(94, 530);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HomeBtn_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(4, 176);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(4, 60);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(85, 51);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // emp_logout_btn
            // 
            this.emp_logout_btn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_logout_btn.Location = new System.Drawing.Point(4, 117);
            this.emp_logout_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emp_logout_btn.Name = "emp_logout_btn";
            this.emp_logout_btn.Size = new System.Drawing.Size(85, 51);
            this.emp_logout_btn.TabIndex = 2;
            this.emp_logout_btn.Text = "Log Out";
            this.emp_logout_btn.UseVisualStyleBackColor = true;
            this.emp_logout_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(4, 199);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(544, 92);
            this.button3.TabIndex = 3;
            this.button3.Text = "Manage Cars";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ManageCars_Btn);
            // 
            // EmpMainMenuBtnPanel
            // 
            this.EmpMainMenuBtnPanel.ColumnCount = 1;
            this.EmpMainMenuBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmpMainMenuBtnPanel.Controls.Add(this.button3, 0, 2);
            this.EmpMainMenuBtnPanel.Controls.Add(this.button6, 0, 1);
            this.EmpMainMenuBtnPanel.Controls.Add(this.button7, 0, 3);
            this.EmpMainMenuBtnPanel.Controls.Add(this.button5, 0, 0);
            this.EmpMainMenuBtnPanel.Location = new System.Drawing.Point(216, 83);
            this.EmpMainMenuBtnPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EmpMainMenuBtnPanel.Name = "EmpMainMenuBtnPanel";
            this.EmpMainMenuBtnPanel.RowCount = 4;
            this.EmpMainMenuBtnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmpMainMenuBtnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmpMainMenuBtnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmpMainMenuBtnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmpMainMenuBtnPanel.Size = new System.Drawing.Size(552, 395);
            this.EmpMainMenuBtnPanel.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(4, 101);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(544, 92);
            this.button6.TabIndex = 5;
            this.button6.Text = "Create Report";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(4, 297);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(544, 94);
            this.button7.TabIndex = 6;
            this.button7.Text = "Manage Customers";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.EmpManageCustomersBtn);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(4, 3);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(544, 92);
            this.button5.TabIndex = 4;
            this.button5.Text = "Manage Reservations";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ResMenuBtn);
            // 
            // Emp_id_box
            // 
            this.Emp_id_box.AutoSize = true;
            this.Emp_id_box.Location = new System.Drawing.Point(136, 24);
            this.Emp_id_box.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Emp_id_box.Name = "Emp_id_box";
            this.Emp_id_box.Size = new System.Drawing.Size(60, 15);
            this.Emp_id_box.TabIndex = 6;
            this.Emp_id_box.Text = "Welcome!";
            this.Emp_id_box.Click += new System.EventHandler(this.Emp_id_box_Click);
            // 
            // mainMenuBranchDropdown
            // 
            this.mainMenuBranchDropdown.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainMenuBranchDropdown.FormattingEnabled = true;
            this.mainMenuBranchDropdown.Location = new System.Drawing.Point(707, 16);
            this.mainMenuBranchDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainMenuBranchDropdown.MaxDropDownItems = 20;
            this.mainMenuBranchDropdown.Name = "mainMenuBranchDropdown";
            this.mainMenuBranchDropdown.Size = new System.Drawing.Size(164, 26);
            this.mainMenuBranchDropdown.TabIndex = 7;
            this.mainMenuBranchDropdown.Text = "Select Branch...";
            this.mainMenuBranchDropdown.SelectedIndexChanged += new System.EventHandler(this.MainMenuBranchDropdown_SelectedIndexChanged);
            // 
            // EmpCarMenu
            // 
            this.EmpCarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.EmpCarMenu.Location = new System.Drawing.Point(136, 47);
            this.EmpCarMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpCarMenu.Name = "EmpCarMenu";
            this.EmpCarMenu.Size = new System.Drawing.Size(735, 472);
            this.EmpCarMenu.TabIndex = 8;
            this.EmpCarMenu.Load += new System.EventHandler(this.EmpCarMenu_Load);
            // 
            // EmpReservationMenu1
            // 
            this.EmpReservationMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.EmpReservationMenu1.Location = new System.Drawing.Point(200, 60);
            this.EmpReservationMenu1.Margin = new System.Windows.Forms.Padding(6);
            this.EmpReservationMenu1.Name = "EmpReservationMenu1";
            this.EmpReservationMenu1.Size = new System.Drawing.Size(568, 424);
            this.EmpReservationMenu1.TabIndex = 9;
            this.EmpReservationMenu1.Load += new System.EventHandler(this.EmpReservationMenu1_Load);
            // 
            // empCustomerManagement
            // 
            this.empCustomerManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.empCustomerManagement.Location = new System.Drawing.Point(160, 60);
            this.empCustomerManagement.Name = "empCustomerManagement";
            this.empCustomerManagement.Size = new System.Drawing.Size(644, 450);
            this.empCustomerManagement.TabIndex = 10;
            this.empCustomerManagement.Visible = false;
            this.empCustomerManagement.Load += new System.EventHandler(this.empCustomerManagement1_Load_1);
            // 
            // EmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(884, 530);
            this.Controls.Add(this.mainMenuBranchDropdown);
            this.Controls.Add(this.Emp_id_box);
            this.Controls.Add(this.EmpMainMenuBtnPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.EmpCarMenu);
            this.Controls.Add(this.EmpReservationMenu1);
            this.Controls.Add(this.empCustomerManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "EmployeeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCR - Employee Menu";
            this.Load += new System.EventHandler(this.EmployeeMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EmpMainMenuBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button emp_logout_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label Emp_id_box;
        public System.Windows.Forms.ComboBox mainMenuBranchDropdown;
        private EmpCarMenu EmpCarMenu;
        private EmpReservationMenu EmpReservationMenu1;
        private System.Windows.Forms.Button Back_btn;
        private EmpCustomerManagement EmpCustomerManagement;
        private System.Windows.Forms.TableLayoutPanel EmpMainMenuBtnPanel;
        private EmpCustomerManagement empCustomerManagement;
    }
}