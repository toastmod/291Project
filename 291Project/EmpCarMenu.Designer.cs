
namespace _291Project
{
    partial class EmpCarMenu
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
            this.add_car_btn = new System.Windows.Forms.Button();
            this.car_search_btn = new System.Windows.Forms.Button();
            this.cars_avail_btn = new System.Windows.Forms.Button();
            this.cars_due_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.add_car_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.car_search_btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cars_avail_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cars_due_btn, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 399);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // add_car_btn
            // 
            this.add_car_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_car_btn.Location = new System.Drawing.Point(3, 3);
            this.add_car_btn.Name = "add_car_btn";
            this.add_car_btn.Size = new System.Drawing.Size(556, 93);
            this.add_car_btn.TabIndex = 0;
            this.add_car_btn.Text = "Add Car";
            this.add_car_btn.UseVisualStyleBackColor = true;
            // 
            // car_search_btn
            // 
            this.car_search_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.car_search_btn.Location = new System.Drawing.Point(3, 102);
            this.car_search_btn.Name = "car_search_btn";
            this.car_search_btn.Size = new System.Drawing.Size(556, 93);
            this.car_search_btn.TabIndex = 1;
            this.car_search_btn.Text = "Car Search";
            this.car_search_btn.UseVisualStyleBackColor = true;
            // 
            // cars_avail_btn
            // 
            this.cars_avail_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cars_avail_btn.Location = new System.Drawing.Point(3, 201);
            this.cars_avail_btn.Name = "cars_avail_btn";
            this.cars_avail_btn.Size = new System.Drawing.Size(556, 93);
            this.cars_avail_btn.TabIndex = 2;
            this.cars_avail_btn.Text = "Cars Available";
            this.cars_avail_btn.UseVisualStyleBackColor = true;
            this.cars_avail_btn.Click += new System.EventHandler(this.cars_avail_btn_Click);
            // 
            // cars_due_btn
            // 
            this.cars_due_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cars_due_btn.Location = new System.Drawing.Point(3, 300);
            this.cars_due_btn.Name = "cars_due_btn";
            this.cars_due_btn.Size = new System.Drawing.Size(556, 96);
            this.cars_due_btn.TabIndex = 3;
            this.cars_due_btn.Text = "Cars Due";
            this.cars_due_btn.UseVisualStyleBackColor = true;
            this.cars_due_btn.Click += new System.EventHandler(this.cars_due_btn_Click);
            // 
            // EmpCarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmpCarMenu";
            this.Size = new System.Drawing.Size(568, 424);
            this.Load += new System.EventHandler(this.EmpCarMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button add_car_btn;
        private System.Windows.Forms.Button car_search_btn;
        private System.Windows.Forms.Button cars_avail_btn;
        private System.Windows.Forms.Button cars_due_btn;
    }
}
