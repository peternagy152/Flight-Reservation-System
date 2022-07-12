namespace LoginPage
{
    partial class LogInForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UnseenBox4 = new System.Windows.Forms.PictureBox();
            this.SeenBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnseenBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeenBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(121, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(121, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 5;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(121, 146);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(276, 30);
            this.UserName.TabIndex = 6;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            this.UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_KeyPress);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(121, 269);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(276, 30);
            this.Password.TabIndex = 13;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.Click += new System.EventHandler(this.Password_Click_1);
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = global::LoginPage.Properties.Resources._2221;
            this.label1.Location = new System.Drawing.Point(220, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Do not have account? Register --->";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.BackgroundImage = global::LoginPage.Properties.Resources._2221;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(452, 403);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(163, 35);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BackgroundImage = global::LoginPage.Properties.Resources._222;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(160, 346);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(163, 35);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "LOG IN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::LoginPage.Properties.Resources._111;
            this.pictureBox3.Image = global::LoginPage.Properties.Resources._698841_icon_114_lock_512;
            this.pictureBox3.Location = new System.Drawing.Point(35, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LoginPage.Properties.Resources._111;
            this.pictureBox2.Image = global::LoginPage.Properties.Resources.User_icon_2_svg;
            this.pictureBox2.Location = new System.Drawing.Point(35, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginlabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.IndianRed;
            this.loginlabel.Image = global::LoginPage.Properties.Resources._2221;
            this.loginlabel.Location = new System.Drawing.Point(332, 9);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(307, 64);
            this.loginlabel.TabIndex = 1;
            this.loginlabel.Text = "LOG IN";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = global::LoginPage.Properties.Resources.airplane_flight_clouds_124229_3840x2400;
            this.pictureBox1.Image = global::LoginPage.Properties.Resources.airplane_flight_clouds_124229_3840x2400;
            this.pictureBox1.Location = new System.Drawing.Point(-79, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(998, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UnseenBox4
            // 
            this.UnseenBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UnseenBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnseenBox4.Image = global::LoginPage.Properties.Resources.show_hide_icon_20;
            this.UnseenBox4.Location = new System.Drawing.Point(358, 269);
            this.UnseenBox4.Name = "UnseenBox4";
            this.UnseenBox4.Size = new System.Drawing.Size(39, 30);
            this.UnseenBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UnseenBox4.TabIndex = 14;
            this.UnseenBox4.TabStop = false;
            this.UnseenBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // SeenBox5
            // 
            this.SeenBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SeenBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeenBox5.Image = global::LoginPage.Properties.Resources.show_hide_password_07_5121;
            this.SeenBox5.Location = new System.Drawing.Point(358, 269);
            this.SeenBox5.Name = "SeenBox5";
            this.SeenBox5.Size = new System.Drawing.Size(39, 30);
            this.SeenBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SeenBox5.TabIndex = 15;
            this.SeenBox5.TabStop = false;
            this.SeenBox5.Click += new System.EventHandler(this.pictureBox5_Click_1);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SeenBox5);
            this.Controls.Add(this.UnseenBox4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogInForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnseenBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeenBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox UnseenBox4;
        private System.Windows.Forms.PictureBox SeenBox5;
    }
}

