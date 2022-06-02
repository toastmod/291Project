using System.Windows.Forms;
namespace _291Project
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.first = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.Phone_Num = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.line2 = new System.Windows.Forms.TextBox();
            this.postalcode = new System.Windows.Forms.TextBox();
            this.Province = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.first.Location = new System.Drawing.Point(123, 21);
            this.first.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(141, 30);
            this.first.TabIndex = 0;
            this.first.Text = "First Name:";
            // 
            // last
            // 
            this.last.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.last.Location = new System.Drawing.Point(118, 68);
            this.last.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(141, 30);
            this.last.TabIndex = 1;
            this.last.Text = "Last Name:";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(313, 18);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(240, 39);
            this.FirstName.TabIndex = 2;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(313, 68);
            this.LastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(240, 39);
            this.LastName.TabIndex = 3;
            // 
            // line1
            // 
            this.line1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.line1.Location = new System.Drawing.Point(313, 147);
            this.line1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(240, 39);
            this.line1.TabIndex = 4;
            // 
            // PhoneNum
            // 
            this.PhoneNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNum.Location = new System.Drawing.Point(313, 382);
            this.PhoneNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(240, 39);
            this.PhoneNum.TabIndex = 5;
            // 
            // address_label
            // 
            this.address_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_label.Location = new System.Drawing.Point(146, 112);
            this.address_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(113, 30);
            this.address_label.TabIndex = 6;
            this.address_label.Text = "Address:";
            // 
            // Phone_Num
            // 
            this.Phone_Num.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Phone_Num.Location = new System.Drawing.Point(69, 384);
            this.Phone_Num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Phone_Num.Name = "Phone_Num";
            this.Phone_Num.Size = new System.Drawing.Size(190, 30);
            this.Phone_Num.TabIndex = 7;
            this.Phone_Num.Text = "Phone Number:";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.create.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create.Location = new System.Drawing.Point(313, 470);
            this.create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(213, 44);
            this.create.TabIndex = 8;
            this.create.Text = "Create Account";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click_1);
            // 
            // line2
            // 
            this.line2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.line2.Location = new System.Drawing.Point(313, 194);
            this.line2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(240, 39);
            this.line2.TabIndex = 9;
            // 
            // postalcode
            // 
            this.postalcode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalcode.Location = new System.Drawing.Point(313, 241);
            this.postalcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(240, 39);
            this.postalcode.TabIndex = 10;
            // 
            // Province
            // 
            this.Province.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Province.Location = new System.Drawing.Point(313, 288);
            this.Province.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(240, 39);
            this.Province.TabIndex = 11;
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.City.Location = new System.Drawing.Point(313, 335);
            this.City.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(240, 39);
            this.City.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Line 1:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(177, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Line 2:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(115, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Postal Code:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(146, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Province:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(198, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "City:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(848, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.postalcode);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.create);
            this.Controls.Add(this.Phone_Num);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label first;
        private Label last;
        private TextBox FirstName;
        private TextBox LastName;
        private TextBox line1;
        private TextBox PhoneNum;
        private Label address_label;
        private Label Phone_Num;
        private Button create;
        private TextBox line2;
        private TextBox postalcode;
        private TextBox Province;
        private TextBox City;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}