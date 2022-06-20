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
            this.CustViewCurrent_dt = new System.Windows.Forms.DataGridView();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.custUpdateCurrent = new System.Windows.Forms.Button();
            this.EnterID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustViewCurrent_dt)).BeginInit();
            this.SuspendLayout();
            // 
            // CustViewCurrent_dt
            // 
            this.CustViewCurrent_dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustViewCurrent_dt.Location = new System.Drawing.Point(41, 3);
            this.CustViewCurrent_dt.Name = "CustViewCurrent_dt";
            this.CustViewCurrent_dt.RowHeadersWidth = 72;
            this.CustViewCurrent_dt.RowTemplate.Height = 37;
            this.CustViewCurrent_dt.Size = new System.Drawing.Size(1270, 705);
            this.CustViewCurrent_dt.TabIndex = 0;
            // 
            // cust_id
            // 
            this.cust_id.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cust_id.Location = new System.Drawing.Point(583, 842);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(254, 40);
            this.cust_id.TabIndex = 25;
            this.cust_id.Tag = "Enter Customer ID";
            this.cust_id.TextChanged += new System.EventHandler(this.cust_id_TextChanged);
            // 
            // custUpdateCurrent
            // 
            this.custUpdateCurrent.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custUpdateCurrent.Location = new System.Drawing.Point(620, 957);
            this.custUpdateCurrent.Name = "custUpdateCurrent";
            this.custUpdateCurrent.Size = new System.Drawing.Size(173, 63);
            this.custUpdateCurrent.TabIndex = 26;
            this.custUpdateCurrent.Text = "Refresh";
            this.custUpdateCurrent.UseVisualStyleBackColor = true;
            this.custUpdateCurrent.Click += new System.EventHandler(this.custUpdateCurrent_Click);
            // 
            // EnterID
            // 
            this.EnterID.AutoSize = true;
            this.EnterID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterID.Location = new System.Drawing.Point(452, 846);
            this.EnterID.Name = "EnterID";
            this.EnterID.Size = new System.Drawing.Size(125, 36);
            this.EnterID.TabIndex = 27;
            this.EnterID.Text = "Enter ID:";
            // 
            // CustViewCurrentRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnterID);
            this.Controls.Add(this.custUpdateCurrent);
            this.Controls.Add(this.cust_id);
            this.Controls.Add(this.CustViewCurrent_dt);
            this.Name = "CustViewCurrentRes";
            this.Size = new System.Drawing.Size(1359, 1072);
            this.Load += new System.EventHandler(this.CustViewCurrentRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustViewCurrent_dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustViewCurrent_dt;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.Button custUpdateCurrent;
        private System.Windows.Forms.Label EnterID;
    }
}
