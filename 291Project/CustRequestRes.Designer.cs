namespace _291Project
{
    partial class CustRequestRes
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
            this.ResTable = new System.Windows.Forms.DataGridView();
            this.rates = new System.Windows.Forms.TextBox();
            this.cartypes = new System.Windows.Forms.ComboBox();
            this.Branches = new System.Windows.Forms.ComboBox();
            this.Provinces = new System.Windows.Forms.ComboBox();
            this.Maxrate = new System.Windows.Forms.Label();
            this.Cartype = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.Label();
            this.Province = new System.Windows.Forms.Label();
            this.UpdateResScreen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.RequestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ResTable
            // 
            this.ResTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResTable.Location = new System.Drawing.Point(84, 6);
            this.ResTable.Margin = new System.Windows.Forms.Padding(4);
            this.ResTable.Name = "ResTable";
            this.ResTable.RowHeadersWidth = 72;
            this.ResTable.RowTemplate.Height = 37;
            this.ResTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResTable.Size = new System.Drawing.Size(1296, 742);
            this.ResTable.TabIndex = 0;
            this.ResTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResTable_CellContentClick);
            // 
            // rates
            // 
            this.rates.Location = new System.Drawing.Point(279, 1013);
            this.rates.Margin = new System.Windows.Forms.Padding(4);
            this.rates.Name = "rates";
            this.rates.Size = new System.Drawing.Size(318, 39);
            this.rates.TabIndex = 24;
            // 
            // cartypes
            // 
            this.cartypes.FormattingEnabled = true;
            this.cartypes.Location = new System.Drawing.Point(279, 937);
            this.cartypes.Margin = new System.Windows.Forms.Padding(4);
            this.cartypes.Name = "cartypes";
            this.cartypes.Size = new System.Drawing.Size(318, 40);
            this.cartypes.TabIndex = 21;
            this.cartypes.SelectedIndexChanged += new System.EventHandler(this.cartypes_SelectedIndexChanged);
            // 
            // Branches
            // 
            this.Branches.FormattingEnabled = true;
            this.Branches.Location = new System.Drawing.Point(279, 860);
            this.Branches.Margin = new System.Windows.Forms.Padding(4);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(318, 40);
            this.Branches.TabIndex = 20;
            this.Branches.SelectedIndexChanged += new System.EventHandler(this.Branches_SelectedIndexChanged);
            // 
            // Provinces
            // 
            this.Provinces.FormattingEnabled = true;
            this.Provinces.Location = new System.Drawing.Point(279, 789);
            this.Provinces.Margin = new System.Windows.Forms.Padding(4);
            this.Provinces.Name = "Provinces";
            this.Provinces.Size = new System.Drawing.Size(318, 40);
            this.Provinces.TabIndex = 19;
            this.Provinces.SelectedIndexChanged += new System.EventHandler(this.Provinces_SelectedIndexChanged);
            // 
            // Maxrate
            // 
            this.Maxrate.AutoSize = true;
            this.Maxrate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Maxrate.Location = new System.Drawing.Point(15, 1011);
            this.Maxrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Maxrate.Name = "Maxrate";
            this.Maxrate.Size = new System.Drawing.Size(222, 40);
            this.Maxrate.TabIndex = 18;
            this.Maxrate.Text = "Max rate/day:";
            // 
            // Cartype
            // 
            this.Cartype.AutoSize = true;
            this.Cartype.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cartype.Location = new System.Drawing.Point(82, 934);
            this.Cartype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cartype.Name = "Cartype";
            this.Cartype.Size = new System.Drawing.Size(152, 40);
            this.Cartype.TabIndex = 15;
            this.Cartype.Text = "Car Type:";
            // 
            // Branch
            // 
            this.Branch.AutoSize = true;
            this.Branch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Branch.Location = new System.Drawing.Point(106, 858);
            this.Branch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(126, 40);
            this.Branch.TabIndex = 14;
            this.Branch.Text = "Branch:";
            // 
            // Province
            // 
            this.Province.AutoSize = true;
            this.Province.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Province.Location = new System.Drawing.Point(84, 789);
            this.Province.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(150, 40);
            this.Province.TabIndex = 13;
            this.Province.Text = "Province:";
            // 
            // UpdateResScreen
            // 
            this.UpdateResScreen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateResScreen.Location = new System.Drawing.Point(323, 1067);
            this.UpdateResScreen.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateResScreen.Name = "UpdateResScreen";
            this.UpdateResScreen.Size = new System.Drawing.Size(227, 98);
            this.UpdateResScreen.TabIndex = 25;
            this.UpdateResScreen.Text = "Refresh";
            this.UpdateResScreen.UseVisualStyleBackColor = true;
            this.UpdateResScreen.Click += new System.EventHandler(this.UpdateResScreen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(802, 858);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 40);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(841, 934);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 40);
            this.label3.TabIndex = 29;
            this.label3.Text = "Date To:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1001, 860);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(379, 39);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1001, 939);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(379, 39);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // RequestBtn
            // 
            this.RequestBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RequestBtn.Location = new System.Drawing.Point(1001, 1067);
            this.RequestBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(227, 98);
            this.RequestBtn.TabIndex = 33;
            this.RequestBtn.Text = "Request Car";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_click);
            // 
            // CustRequestRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RequestBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateResScreen);
            this.Controls.Add(this.rates);
            this.Controls.Add(this.cartypes);
            this.Controls.Add(this.Branches);
            this.Controls.Add(this.Provinces);
            this.Controls.Add(this.Maxrate);
            this.Controls.Add(this.Cartype);
            this.Controls.Add(this.Branch);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.ResTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustRequestRes";
            this.Size = new System.Drawing.Size(1463, 1186);
            this.Load += new System.EventHandler(this.CustRequestRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResTable;
        private System.Windows.Forms.TextBox rates;
        private System.Windows.Forms.ComboBox cartypes;
        private System.Windows.Forms.ComboBox Branches;
        private System.Windows.Forms.ComboBox Provinces;
        private System.Windows.Forms.Label Maxrate;
        private System.Windows.Forms.Label Cartype;
        private System.Windows.Forms.Label Branch;
        private System.Windows.Forms.Label Province;
        private System.Windows.Forms.Button UpdateResScreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button RequestBtn;
    }
}
