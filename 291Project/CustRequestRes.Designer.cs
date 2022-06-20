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
            this.ReservationTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rates = new System.Windows.Forms.TextBox();
            this.cartypes = new System.Windows.Forms.ComboBox();
            this.Branches = new System.Windows.Forms.ComboBox();
            this.Provinces = new System.Windows.Forms.ComboBox();
            this.Maxrate = new System.Windows.Forms.Label();
            this.Cartype = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.Label();
            this.Province = new System.Windows.Forms.Label();
            this.UpdateResScreen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationTable
            // 
            this.ReservationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationTable.Location = new System.Drawing.Point(83, 6);
            this.ReservationTable.Name = "ReservationTable";
            this.ReservationTable.RowHeadersWidth = 72;
            this.ReservationTable.RowTemplate.Height = 37;
            this.ReservationTable.Size = new System.Drawing.Size(1297, 742);
            this.ReservationTable.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1079, 1066);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 97);
            this.button1.TabIndex = 7;
            this.button1.Text = "Request Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rates
            // 
            this.rates.Location = new System.Drawing.Point(278, 1013);
            this.rates.Name = "rates";
            this.rates.Size = new System.Drawing.Size(318, 39);
            this.rates.TabIndex = 24;
            // 
            // cartypes
            // 
            this.cartypes.FormattingEnabled = true;
            this.cartypes.Location = new System.Drawing.Point(278, 937);
            this.cartypes.Name = "cartypes";
            this.cartypes.Size = new System.Drawing.Size(318, 40);
            this.cartypes.TabIndex = 21;
            this.cartypes.SelectedIndexChanged += new System.EventHandler(this.cartypes_SelectedIndexChanged);
            // 
            // Branches
            // 
            this.Branches.FormattingEnabled = true;
            this.Branches.Location = new System.Drawing.Point(278, 860);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(318, 40);
            this.Branches.TabIndex = 20;
            this.Branches.SelectedIndexChanged += new System.EventHandler(this.Branches_SelectedIndexChanged);
            // 
            // Provinces
            // 
            this.Provinces.FormattingEnabled = true;
            this.Provinces.Location = new System.Drawing.Point(278, 790);
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
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(126, 40);
            this.Branch.TabIndex = 14;
            this.Branch.Text = "Branch:";
            // 
            // Province
            // 
            this.Province.AutoSize = true;
            this.Province.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Province.Location = new System.Drawing.Point(83, 788);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(150, 40);
            this.Province.TabIndex = 13;
            this.Province.Text = "Province:";
            // 
            // UpdateResScreen
            // 
            this.UpdateResScreen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateResScreen.Location = new System.Drawing.Point(324, 1066);
            this.UpdateResScreen.Name = "UpdateResScreen";
            this.UpdateResScreen.Size = new System.Drawing.Size(226, 97);
            this.UpdateResScreen.TabIndex = 25;
            this.UpdateResScreen.Text = "Refresh";
            this.UpdateResScreen.UseVisualStyleBackColor = true;
            this.UpdateResScreen.Click += new System.EventHandler(this.UpdateResScreen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1001, 794);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 39);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(713, 790);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 40);
            this.label1.TabIndex = 27;
            this.label1.Text = "Car ID to request:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(802, 858);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 40);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(842, 934);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 40);
            this.label3.TabIndex = 29;
            this.label3.Text = "Date To:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1001, 860);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(379, 39);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1001, 940);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(379, 39);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // CustRequestRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UpdateResScreen);
            this.Controls.Add(this.rates);
            this.Controls.Add(this.cartypes);
            this.Controls.Add(this.Branches);
            this.Controls.Add(this.Provinces);
            this.Controls.Add(this.Maxrate);
            this.Controls.Add(this.Cartype);
            this.Controls.Add(this.Branch);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReservationTable);
            this.Name = "CustRequestRes";
            this.Size = new System.Drawing.Size(1464, 1185);
            this.Load += new System.EventHandler(this.CustRequestRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReservationTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rates;
        private System.Windows.Forms.ComboBox cartypes;
        private System.Windows.Forms.ComboBox Branches;
        private System.Windows.Forms.ComboBox Provinces;
        private System.Windows.Forms.Label Maxrate;
        private System.Windows.Forms.Label Cartype;
        private System.Windows.Forms.Label Branch;
        private System.Windows.Forms.Label Province;
        private System.Windows.Forms.Button UpdateResScreen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
