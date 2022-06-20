namespace _291Project
{
    partial class EmpReservationMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.emp_create_res = new System.Windows.Forms.Button();
            this.emp_curr_res = new System.Windows.Forms.Button();
            this.emp_past_res = new System.Windows.Forms.Button();
            this.empCurrentRes1 = new EmpCurrentRes();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Controls.Add(this.emp_create_res, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emp_curr_res, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.emp_past_res, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 36);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 830);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // emp_create_res
            // 
            this.emp_create_res.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_create_res.Location = new System.Drawing.Point(6, 6);
            this.emp_create_res.Margin = new System.Windows.Forms.Padding(6);
            this.emp_create_res.Name = "emp_create_res";
            this.emp_create_res.Size = new System.Drawing.Size(972, 260);
            this.emp_create_res.TabIndex = 0;
            this.emp_create_res.Text = "Create Reservation";
            this.emp_create_res.UseVisualStyleBackColor = true;
            this.emp_create_res.Click += new System.EventHandler(this.emp_create_res_Click);
            // 
            // emp_curr_res
            // 
            this.emp_curr_res.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_curr_res.Location = new System.Drawing.Point(6, 282);
            this.emp_curr_res.Margin = new System.Windows.Forms.Padding(6);
            this.emp_curr_res.Name = "emp_curr_res";
            this.emp_curr_res.Size = new System.Drawing.Size(972, 260);
            this.emp_curr_res.TabIndex = 1;
            this.emp_curr_res.Text = "Current Reservations";
            this.emp_curr_res.UseVisualStyleBackColor = true;
            this.emp_curr_res.Click += new System.EventHandler(this.emp_curr_res_Click);
            // 
            // emp_past_res
            // 
            this.emp_past_res.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_past_res.Location = new System.Drawing.Point(6, 558);
            this.emp_past_res.Margin = new System.Windows.Forms.Padding(6);
            this.emp_past_res.Name = "emp_past_res";
            this.emp_past_res.Size = new System.Drawing.Size(972, 265);
            this.emp_past_res.TabIndex = 2;
            this.emp_past_res.Text = "Past Reservations";
            this.emp_past_res.UseVisualStyleBackColor = true;
            this.emp_past_res.Click += new System.EventHandler(this.emp_past_res_Click);
            // 
            // EmpReservationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.empCurrentRes1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EmpReservationMenu";
            this.Size = new System.Drawing.Size(1055, 905);
            this.Load += new System.EventHandler(this.EmpReservationMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button emp_create_res;
        private System.Windows.Forms.Button emp_curr_res;
        private System.Windows.Forms.Button emp_past_res;
        private EmpCurrentRes empCurrentRes1;
    }
}
