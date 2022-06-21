
namespace _291Project
{
    partial class EmpCarsAvailable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CarSearchDataView = new System.Windows.Forms.DataGridView();
            this.rates = new System.Windows.Forms.TextBox();
            this.cartypes = new System.Windows.Forms.ComboBox();
            this.CarStatus = new System.Windows.Forms.ComboBox();
            this.Maxrate = new System.Windows.Forms.Label();
            this.Cartype = new System.Windows.Forms.Label();
            this.CarStatusLabel = new System.Windows.Forms.Label();
            this.Provinces = new System.Windows.Forms.ComboBox();
            this.Province = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSearchDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // CarSearchDataView
            // 
            this.CarSearchDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarSearchDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarSearchDataView.Location = new System.Drawing.Point(0, 0);
            this.CarSearchDataView.Name = "CarSearchDataView";
            this.CarSearchDataView.RowHeadersWidth = 72;
            this.CarSearchDataView.RowTemplate.Height = 25;
            this.CarSearchDataView.Size = new System.Drawing.Size(660, 310);
            this.CarSearchDataView.TabIndex = 1;
            this.CarSearchDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarSearchDataView_click);
            // 
            // rates
            // 
            this.rates.Location = new System.Drawing.Point(443, 374);
            this.rates.Margin = new System.Windows.Forms.Padding(2);
            this.rates.Name = "rates";
            this.rates.Size = new System.Drawing.Size(173, 23);
            this.rates.TabIndex = 32;
            this.rates.TextChanged += new System.EventHandler(this.rates_TextChanged);
            // 
            // cartypes
            // 
            this.cartypes.FormattingEnabled = true;
            this.cartypes.Location = new System.Drawing.Point(121, 374);
            this.cartypes.Margin = new System.Windows.Forms.Padding(2);
            this.cartypes.Name = "cartypes";
            this.cartypes.Size = new System.Drawing.Size(173, 23);
            this.cartypes.TabIndex = 31;
            this.cartypes.SelectedIndexChanged += new System.EventHandler(this.cartypes_SelectedIndexChanged);
            // 
            // CarStatus
            // 
            this.CarStatus.FormattingEnabled = true;
            this.CarStatus.Location = new System.Drawing.Point(121, 336);
            this.CarStatus.Margin = new System.Windows.Forms.Padding(2);
            this.CarStatus.Name = "CarStatus";
            this.CarStatus.Size = new System.Drawing.Size(173, 23);
            this.CarStatus.TabIndex = 29;
            this.CarStatus.SelectedIndexChanged += new System.EventHandler(this.CarStatusDropdown_SelectedIndexChanged);
            // 
            // Maxrate
            // 
            this.Maxrate.AutoSize = true;
            this.Maxrate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Maxrate.Location = new System.Drawing.Point(301, 373);
            this.Maxrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Maxrate.Name = "Maxrate";
            this.Maxrate.Size = new System.Drawing.Size(110, 22);
            this.Maxrate.TabIndex = 28;
            this.Maxrate.Text = "Max rate/day:";
            // 
            // Cartype
            // 
            this.Cartype.AutoSize = true;
            this.Cartype.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cartype.Location = new System.Drawing.Point(15, 373);
            this.Cartype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cartype.Name = "Cartype";
            this.Cartype.Size = new System.Drawing.Size(78, 22);
            this.Cartype.TabIndex = 27;
            this.Cartype.Text = "Car Type:";
            // 
            // CarStatusLabel
            // 
            this.CarStatusLabel.AutoSize = true;
            this.CarStatusLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarStatusLabel.Location = new System.Drawing.Point(16, 336);
            this.CarStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CarStatusLabel.Name = "CarStatusLabel";
            this.CarStatusLabel.Size = new System.Drawing.Size(87, 22);
            this.CarStatusLabel.TabIndex = 25;
            this.CarStatusLabel.Text = "Car Status:";
            // 
            // Provinces
            // 
            this.Provinces.FormattingEnabled = true;
            this.Provinces.Location = new System.Drawing.Point(444, 337);
            this.Provinces.Margin = new System.Windows.Forms.Padding(2);
            this.Provinces.Name = "Provinces";
            this.Provinces.Size = new System.Drawing.Size(173, 23);
            this.Provinces.TabIndex = 34;
            this.Provinces.SelectedIndexChanged += new System.EventHandler(this.Provinces_SelectedIndexChanged);
            // 
            // Province
            // 
            this.Province.AutoSize = true;
            this.Province.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Province.Location = new System.Drawing.Point(334, 337);
            this.Province.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(78, 22);
            this.Province.TabIndex = 33;
            this.Province.Text = "Province:";
            // 
            // EmpCarsAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.Provinces);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.rates);
            this.Controls.Add(this.cartypes);
            this.Controls.Add(this.CarStatus);
            this.Controls.Add(this.Maxrate);
            this.Controls.Add(this.Cartype);
            this.Controls.Add(this.CarStatusLabel);
            this.Controls.Add(this.CarSearchDataView);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmpCarsAvailable";
            this.Size = new System.Drawing.Size(660, 450);
            this.Load += new System.EventHandler(this.EmpCarsAvailable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSearchDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView CarSearchDataView;
        private System.Windows.Forms.TextBox rates;
        private System.Windows.Forms.ComboBox cartypes;
        private System.Windows.Forms.ComboBox CarStatus;
        private System.Windows.Forms.Label Maxrate;
        private System.Windows.Forms.Label Cartype;
        private System.Windows.Forms.Label CarStatusLabel;
        private System.Windows.Forms.ComboBox Provinces;
        private System.Windows.Forms.Label Province;
    }
}
