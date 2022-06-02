﻿using System.Windows.Forms;
namespace _291Project
{
    partial class CSignUpForm : Form
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
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.first.Location = new System.Drawing.Point(69, 45);
            this.first.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(186, 64);
            this.first.TabIndex = 0;
            this.first.Text = "First Name:";
            // 
            // last
            // 
            this.last.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.last.Location = new System.Drawing.Point(69, 119);
            this.last.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(189, 64);
            this.last.TabIndex = 1;
            this.last.Text = "Last Name:";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(267, 48);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(271, 43);
            this.FirstName.TabIndex = 2;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(267, 122);
            this.LastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(271, 43);
            this.LastName.TabIndex = 3;
            // 
            // line1
            // 
            this.line1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.line1.Location = new System.Drawing.Point(267, 290);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(271, 43);
            this.line1.TabIndex = 4;
            // 
            // PhoneNum
            // 
            this.PhoneNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNum.Location = new System.Drawing.Point(267, 791);
            this.PhoneNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(271, 43);
            this.PhoneNum.TabIndex = 5;
            this.PhoneNum.TextChanged += new System.EventHandler(this.PhoneNum_TextChanged);
            // 
            // address_label
            // 
            this.address_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_label.Location = new System.Drawing.Point(69, 224);
            this.address_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(210, 64);
            this.address_label.TabIndex = 6;
            this.address_label.Text = "Address:";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create.Location = new System.Drawing.Point(180, 941);
            this.create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(319, 75);
            this.create.TabIndex = 8;
            this.create.Text = "Create Account";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click_1);
            // 
            // line2
            // 
            this.line2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.line2.Location = new System.Drawing.Point(267, 390);
            this.line2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(271, 43);
            this.line2.TabIndex = 9;
            // 
            // postalcode
            // 
            this.postalcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalcode.Location = new System.Drawing.Point(267, 491);
            this.postalcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(271, 43);
            this.postalcode.TabIndex = 10;
            // 
            // Province
            // 
            this.Province.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Province.Location = new System.Drawing.Point(267, 591);
            this.Province.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(271, 43);
            this.Province.TabIndex = 11;
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.City.Location = new System.Drawing.Point(267, 689);
            this.City.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(271, 43);
            this.City.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 64);
            this.label1.TabIndex = 13;
            this.label1.Text = "Line 1:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 64);
            this.label2.TabIndex = 14;
            this.label2.Text = "Line 2:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 488);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 64);
            this.label3.TabIndex = 15;
            this.label3.Text = "Postal Code:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(104, 588);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 64);
            this.label4.TabIndex = 16;
            this.label4.Text = "Province:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(165, 677);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 64);
            this.label5.TabIndex = 18;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 788);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 64);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone Number:";
            // 
            // CSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(659, 1043);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.postalcode);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.create);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CSignUpForm";
            this.Text = "Numved Car Rental - Customer Sign Up";
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
        private Label label6;
    }
}