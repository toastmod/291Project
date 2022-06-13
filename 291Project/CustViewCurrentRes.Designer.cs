namespace _291Project
{
    partial class CustViewCurrentRes
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
            this.CustViewCurrentFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1321, 882);
            this.dataGridView1.TabIndex = 0;
            // 
            // CustViewCurrentFilters
            // 
            this.CustViewCurrentFilters.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustViewCurrentFilters.Location = new System.Drawing.Point(16, 987);
            this.CustViewCurrentFilters.Name = "CustViewCurrentFilters";
            this.CustViewCurrentFilters.Size = new System.Drawing.Size(187, 73);
            this.CustViewCurrentFilters.TabIndex = 1;
            this.CustViewCurrentFilters.Text = "Filters";
            this.CustViewCurrentFilters.UseVisualStyleBackColor = true;
            // 
            // CustViewCurrentRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustViewCurrentFilters);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustViewCurrentRes";
            this.Size = new System.Drawing.Size(1398, 1072);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CustViewCurrentFilters;
    }
}
