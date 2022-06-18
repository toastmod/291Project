namespace _291Project
{
    partial class EmpCustomerManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowTermMemBox = new System.Windows.Forms.CheckBox();
            this.TermCustBtn = new System.Windows.Forms.Button();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.CusNameFilter = new System.Windows.Forms.TextBox();
            this.CusNameFilterLabel = new System.Windows.Forms.Label();
            this.CustomerIDFilter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerDataView
            // 
            this.CustomerDataView.AllowUserToAddRows = false;
            this.CustomerDataView.AllowUserToDeleteRows = false;
            this.CustomerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataView.Location = new System.Drawing.Point(0, 0);
            this.CustomerDataView.MultiSelect = false;
            this.CustomerDataView.Name = "CustomerDataView";
            this.CustomerDataView.ReadOnly = true;
            this.CustomerDataView.RowTemplate.Height = 25;
            this.CustomerDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDataView.Size = new System.Drawing.Size(660, 282);
            this.CustomerDataView.TabIndex = 0;
            this.CustomerDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search By Customer ID:";
            // 
            // ShowTermMemBox
            // 
            this.ShowTermMemBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowTermMemBox.AutoSize = true;
            this.ShowTermMemBox.Location = new System.Drawing.Point(241, 84);
            this.ShowTermMemBox.Name = "ShowTermMemBox";
            this.ShowTermMemBox.Size = new System.Drawing.Size(177, 19);
            this.ShowTermMemBox.TabIndex = 5;
            this.ShowTermMemBox.Text = "Show Terminated Customers";
            this.ShowTermMemBox.UseVisualStyleBackColor = true;
            this.ShowTermMemBox.CheckedChanged += new System.EventHandler(this.ShowTermMemBox_CheckedChanged);
            // 
            // TermCustBtn
            // 
            this.TermCustBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TermCustBtn.Location = new System.Drawing.Point(478, 135);
            this.TermCustBtn.Name = "TermCustBtn";
            this.TermCustBtn.Size = new System.Drawing.Size(144, 29);
            this.TermCustBtn.TabIndex = 2;
            this.TermCustBtn.Text = "Terminate Membership";
            this.TermCustBtn.UseVisualStyleBackColor = true;
            this.TermCustBtn.Click += new System.EventHandler(this.DelCustBtn_Click);
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AddCustBtn.Location = new System.Drawing.Point(497, 54);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(105, 24);
            this.AddCustBtn.TabIndex = 1;
            this.AddCustBtn.Text = "Add Customer";
            this.AddCustBtn.UseVisualStyleBackColor = true;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RefreshBtn.Location = new System.Drawing.Point(277, 54);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(105, 24);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CusNameFilter
            // 
            this.CusNameFilter.Location = new System.Drawing.Point(3, 135);
            this.CusNameFilter.Name = "CusNameFilter";
            this.CusNameFilter.PlaceholderText = "---Type Here to Search---";
            this.CusNameFilter.Size = new System.Drawing.Size(214, 23);
            this.CusNameFilter.TabIndex = 8;
            this.CusNameFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CusNameFilter.TextChanged += new System.EventHandler(this.CusNameFilter_TextChanged);
            // 
            // CusNameFilterLabel
            // 
            this.CusNameFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CusNameFilterLabel.AutoSize = true;
            this.CusNameFilterLabel.Location = new System.Drawing.Point(3, 117);
            this.CusNameFilterLabel.Name = "CusNameFilterLabel";
            this.CusNameFilterLabel.Size = new System.Drawing.Size(151, 15);
            this.CusNameFilterLabel.TabIndex = 9;
            this.CusNameFilterLabel.Text = "Search By Customer Name:";
            // 
            // CustomerIDFilter
            // 
            this.CustomerIDFilter.Location = new System.Drawing.Point(3, 54);
            this.CustomerIDFilter.Name = "CustomerIDFilter";
            this.CustomerIDFilter.PlaceholderText = "---Type Here to Search---";
            this.CustomerIDFilter.Size = new System.Drawing.Size(214, 23);
            this.CustomerIDFilter.TabIndex = 6;
            this.CustomerIDFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerIDFilter.TextChanged += new System.EventHandler(this.CusIDFilter_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.CustomerIDFilter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CusNameFilterLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CusNameFilter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShowTermMemBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RefreshBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TermCustBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddCustBtn, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 283);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.53892F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.96407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.53892F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.35928F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 167);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint_1);
            // 
            // EmpCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CustomerDataView);
            this.Name = "EmpCustomerManagement";
            this.Size = new System.Drawing.Size(660, 450);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ShowTermMemBox;
        private System.Windows.Forms.Button TermCustBtn;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.TextBox CusNameFilter;
        private System.Windows.Forms.Label CusNameFilterLabel;
        private System.Windows.Forms.TextBox CustomerIDFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
