namespace Airline_Reservation
{
    partial class LoginWindow
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
            this.userId_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.userId_txtBox = new System.Windows.Forms.TextBox();
            this.Signin_btn = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.errorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // userId_lbl
            // 
            this.userId_lbl.AutoSize = true;
            this.userId_lbl.Location = new System.Drawing.Point(42, 80);
            this.userId_lbl.Name = "userId_lbl";
            this.userId_lbl.Size = new System.Drawing.Size(53, 17);
            this.userId_lbl.TabIndex = 0;
            this.userId_lbl.Text = "User Id";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(42, 122);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(69, 17);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Password";
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(137, 122);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '*';
            this.password_txtbox.Size = new System.Drawing.Size(182, 22);
            this.password_txtbox.TabIndex = 3;
            // 
            // userId_txtBox
            // 
            this.userId_txtBox.Location = new System.Drawing.Point(137, 80);
            this.userId_txtBox.Name = "userId_txtBox";
            this.userId_txtBox.Size = new System.Drawing.Size(182, 22);
            this.userId_txtBox.TabIndex = 2;
            // 
            // Signin_btn
            // 
            this.Signin_btn.Location = new System.Drawing.Point(137, 186);
            this.Signin_btn.Name = "Signin_btn";
            this.Signin_btn.Size = new System.Drawing.Size(75, 30);
            this.Signin_btn.TabIndex = 4;
            this.Signin_btn.Text = "Sign In";
            this.Signin_btn.UseVisualStyleBackColor = true;
            this.Signin_btn.Click += new System.EventHandler(this.Signin_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(249, 186);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 30);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = "Sign up";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(45, 163);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 17);
            this.errorLbl.TabIndex = 6;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(364, 229);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.Signin_btn);
            this.Controls.Add(this.userId_txtBox);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.userId_lbl);
            this.Name = "LoginWindow";
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userId_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox userId_txtBox;
        private System.Windows.Forms.Button Signin_btn;
        private System.Windows.Forms.Button signup_btn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label errorLbl;
    }
}