
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSearchDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.Size = new System.Drawing.Size(411, 300);
            this.dataGridView1.TabIndex = 4;
            // 
            // CarSearchDataView
            // 
            this.CarSearchDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarSearchDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarSearchDataView.Location = new System.Drawing.Point(0, 0);
            this.CarSearchDataView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CarSearchDataView.Name = "CarSearchDataView";
            this.CarSearchDataView.RowHeadersWidth = 72;
            this.CarSearchDataView.RowTemplate.Height = 25;
            this.CarSearchDataView.Size = new System.Drawing.Size(1131, 621);
            this.CarSearchDataView.TabIndex = 1;
            this.CarSearchDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarSearchDataView_click);
            // 
            // EmpCarsAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.CarSearchDataView);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmpCarsAvailable";
            this.Size = new System.Drawing.Size(1131, 900);
            this.Load += new System.EventHandler(this.EmpCarsAvailable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSearchDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView CarSearchDataView;
    }
}
