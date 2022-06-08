namespace _291Project
{
    partial class ReservationMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.createRes1 = new _291Project.background();
            this.createReservation1 = new _291Project.createReservation();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(231, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a Reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(231, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Current Reservations";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 414);
            this.panel1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(3, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // createRes1
            // 
            this.createRes1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createRes1.Location = new System.Drawing.Point(88, 0);
            this.createRes1.Name = "createRes1";
            this.createRes1.Size = new System.Drawing.Size(504, 414);
            this.createRes1.TabIndex = 5;
            // 
            // createReservation1
            // 
            this.createReservation1.Location = new System.Drawing.Point(88, 0);
            this.createReservation1.Name = "createReservation1";
            this.createReservation1.Size = new System.Drawing.Size(504, 414);
            this.createReservation1.TabIndex = 6;
            // 
            // ReservationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 414);
            this.Controls.Add(this.createReservation1);
            this.Controls.Add(this.createRes1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ReservationMenu";
            this.Text = " Reservation Menu";
            this.Load += new System.EventHandler(this.ReservationMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private background createRes1;
        private createReservation createReservation1;
    }
}