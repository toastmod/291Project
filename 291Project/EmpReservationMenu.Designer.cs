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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.emp_create_res, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emp_curr_res, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.emp_past_res, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 389);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // emp_create_res
            // 
            this.emp_create_res.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_create_res.Location = new System.Drawing.Point(3, 3);
            this.emp_create_res.Name = "emp_create_res";
            this.emp_create_res.Size = new System.Drawing.Size(524, 122);
            this.emp_create_res.TabIndex = 0;
            this.emp_create_res.Text = "Create Reservation";
            this.emp_create_res.UseVisualStyleBackColor = true;
            // 
            // emp_curr_res
            // 
            this.emp_curr_res.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_curr_res.Location = new System.Drawing.Point(3, 132);
            this.emp_curr_res.Name = "emp_curr_res";
            this.emp_curr_res.Size = new System.Drawing.Size(524, 122);
            this.emp_curr_res.TabIndex = 1;
            this.emp_curr_res.Text = "Current Reservations";
            this.emp_curr_res.UseVisualStyleBackColor = true;
            // 
            // emp_past_res
            // 
            this.emp_past_res.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_past_res.Location = new System.Drawing.Point(3, 261);
            this.emp_past_res.Name = "emp_past_res";
            this.emp_past_res.Size = new System.Drawing.Size(524, 124);
            this.emp_past_res.TabIndex = 2;
            this.emp_past_res.Text = "Past Reservations";
            this.emp_past_res.UseVisualStyleBackColor = true;
            // 
            // EmpReservationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmpReservationMenu";
            this.Size = new System.Drawing.Size(568, 424);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button emp_create_res;
        private System.Windows.Forms.Button emp_curr_res;
        private System.Windows.Forms.Button emp_past_res;
    }
}
