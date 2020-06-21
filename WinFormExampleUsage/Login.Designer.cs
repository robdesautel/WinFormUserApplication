namespace WinFormExampleUsage
{
    partial class Login
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
            this.userEmailAddress = new System.Windows.Forms.TextBox();
            this.userEmailAddressLabel = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.userLoginCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userEmailAddress
            // 
            this.userEmailAddress.Location = new System.Drawing.Point(38, 167);
            this.userEmailAddress.Name = "userEmailAddress";
            this.userEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.userEmailAddress.TabIndex = 0;
            // 
            // userEmailAddressLabel
            // 
            this.userEmailAddressLabel.AutoSize = true;
            this.userEmailAddressLabel.Location = new System.Drawing.Point(38, 148);
            this.userEmailAddressLabel.Name = "userEmailAddressLabel";
            this.userEmailAddressLabel.Size = new System.Drawing.Size(32, 13);
            this.userEmailAddressLabel.TabIndex = 1;
            this.userEmailAddressLabel.Text = "Email";
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(246, 166);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(100, 20);
            this.userPassword.TabIndex = 2;
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(246, 147);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.userPasswordLabel.TabIndex = 3;
            this.userPasswordLabel.Text = "Password";
            // 
            // userLoginButton
            // 
            this.userLoginButton.Location = new System.Drawing.Point(418, 164);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(75, 23);
            this.userLoginButton.TabIndex = 4;
            this.userLoginButton.Text = "Login";
            this.userLoginButton.UseVisualStyleBackColor = true;
            this.userLoginButton.Click += new System.EventHandler(this.userLoginButton_Click);
            // 
            // userLoginCancelButton
            // 
            this.userLoginCancelButton.Location = new System.Drawing.Point(559, 163);
            this.userLoginCancelButton.Name = "userLoginCancelButton";
            this.userLoginCancelButton.Size = new System.Drawing.Size(75, 23);
            this.userLoginCancelButton.TabIndex = 5;
            this.userLoginCancelButton.Text = "Cancel";
            this.userLoginCancelButton.UseVisualStyleBackColor = true;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userLoginCancelButton);
            this.Controls.Add(this.userLoginButton);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userEmailAddressLabel);
            this.Controls.Add(this.userEmailAddress);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userEmailAddress;
        private System.Windows.Forms.Label userEmailAddressLabel;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Button userLoginButton;
        private System.Windows.Forms.Button userLoginCancelButton;
    }
}