namespace DotNetWebSearchAnalyticsAPI.Client
{
    partial class APIForm
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
            label2 = new Label();
            txtNewUserConfirmPassword = new TextBox();
            label6 = new Label();
            btnCreateAccount = new Button();
            txtNewUserPassword = new TextBox();
            label5 = new Label();
            txtNewUserUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnClearNewUser = new Button();
            label11 = new Label();
            btnCopy = new Button();
            label7 = new Label();
            txtJWBToken = new TextBox();
            button3 = new Button();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            label8 = new Label();
            txtLoginUsername = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtAPIAddress = new TextBox();
            label21 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 47);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 1;
            label2.Text = "Identity Management";
            // 
            // txtNewUserConfirmPassword
            // 
            txtNewUserConfirmPassword.Font = new Font("Segoe UI", 9.75F);
            txtNewUserConfirmPassword.Location = new Point(400, 77);
            txtNewUserConfirmPassword.Name = "txtNewUserConfirmPassword";
            txtNewUserConfirmPassword.PlaceholderText = "Confirm Password...";
            txtNewUserConfirmPassword.Size = new Size(178, 25);
            txtNewUserConfirmPassword.TabIndex = 7;
            txtNewUserConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(400, 53);
            label6.Name = "label6";
            label6.Size = new Size(137, 21);
            label6.TabIndex = 6;
            label6.Text = "Confirm Password";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.LightGray;
            btnCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccount.Location = new Point(594, 74);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(128, 29);
            btnCreateAccount.TabIndex = 5;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += button1_Click;
            // 
            // txtNewUserPassword
            // 
            txtNewUserPassword.Font = new Font("Segoe UI", 9.75F);
            txtNewUserPassword.Location = new Point(206, 77);
            txtNewUserPassword.Name = "txtNewUserPassword";
            txtNewUserPassword.PlaceholderText = "Password...";
            txtNewUserPassword.Size = new Size(178, 25);
            txtNewUserPassword.TabIndex = 4;
            txtNewUserPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(206, 53);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 3;
            label5.Text = "Password";
            // 
            // txtNewUserUsername
            // 
            txtNewUserUsername.Font = new Font("Segoe UI", 9.75F);
            txtNewUserUsername.Location = new Point(12, 77);
            txtNewUserUsername.Name = "txtNewUserUsername";
            txtNewUserUsername.PlaceholderText = "Username...";
            txtNewUserUsername.Size = new Size(178, 25);
            txtNewUserUsername.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 1;
            label4.Text = "Username \\ Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 17);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 0;
            label3.Text = "Create Account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnClearNewUser);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtNewUserConfirmPassword);
            panel2.Controls.Add(btnCopy);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnCreateAccount);
            panel2.Controls.Add(txtJWBToken);
            panel2.Controls.Add(txtNewUserPassword);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtNewUserUsername);
            panel2.Controls.Add(txtLoginPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtLoginUsername);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(21, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 408);
            panel2.TabIndex = 4;
            // 
            // btnClearNewUser
            // 
            btnClearNewUser.BackColor = Color.LightGray;
            btnClearNewUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearNewUser.Location = new Point(733, 74);
            btnClearNewUser.Name = "btnClearNewUser";
            btnClearNewUser.Size = new Size(64, 29);
            btnClearNewUser.TabIndex = 14;
            btnClearNewUser.Text = "Clear";
            btnClearNewUser.UseVisualStyleBackColor = true;
            btnClearNewUser.Click += btnClearNewUser_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(68, 142);
            label11.Name = "label11";
            label11.Size = new Size(136, 17);
            label11.TabIndex = 13;
            label11.Text = "\\ Generate JWT Token";
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopy.Location = new Point(737, 356);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(64, 29);
            btnCopy.TabIndex = 12;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 238);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 11;
            label7.Text = "JWT Token Response";
            // 
            // txtJWBToken
            // 
            txtJWBToken.Enabled = false;
            txtJWBToken.Location = new Point(12, 262);
            txtJWBToken.Multiline = true;
            txtJWBToken.Name = "txtJWBToken";
            txtJWBToken.Size = new Size(789, 82);
            txtJWBToken.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(475, 192);
            button3.Name = "button3";
            button3.Size = new Size(64, 29);
            button3.TabIndex = 9;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(398, 192);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(64, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Segoe UI", 9.75F);
            txtLoginPassword.Location = new Point(206, 196);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PlaceholderText = "Password...";
            txtLoginPassword.Size = new Size(178, 25);
            txtLoginPassword.TabIndex = 4;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(206, 172);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 3;
            label8.Text = "Password";
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Font = new Font("Segoe UI", 9.75F);
            txtLoginUsername.Location = new Point(12, 196);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.PlaceholderText = "Username...";
            txtLoginUsername.Size = new Size(178, 25);
            txtLoginUsername.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 172);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 1;
            label9.Text = "Username \\ Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 136);
            label10.Name = "label10";
            label10.Size = new Size(59, 25);
            label10.TabIndex = 0;
            label10.Text = "Login";
            // 
            // txtAPIAddress
            // 
            txtAPIAddress.BackColor = SystemColors.Info;
            txtAPIAddress.Font = new Font("Segoe UI", 9.75F);
            txtAPIAddress.Location = new Point(616, 12);
            txtAPIAddress.Name = "txtAPIAddress";
            txtAPIAddress.PlaceholderText = "API Address...";
            txtAPIAddress.Size = new Size(246, 25);
            txtAPIAddress.TabIndex = 23;
            txtAPIAddress.Text = "https://localhost:7138";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(423, 12);
            label21.Name = "label21";
            label21.Size = new Size(187, 25);
            label21.TabIndex = 24;
            label21.Text = "Product API Address";
            // 
            // SecureProductAPIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 511);
            Controls.Add(label21);
            Controls.Add(txtAPIAddress);
            Controls.Add(panel2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SecureProductAPIForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Identity Management Client";
            Load += APIForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtNewUserUsername;
        private Button btnCreateAccount;
        private TextBox txtNewUserPassword;
        private Label label5;
        private TextBox txtNewUserConfirmPassword;
        private Label label6;
        private Panel panel2;
        private Button btnLogin;
        private TextBox txtLoginPassword;
        private Label label8;
        private TextBox txtLoginUsername;
        private Label label9;
        private Label label10;
        private Button button3;
        private Label label7;
        private TextBox txtJWBToken;
        private Button btnCopy;
        private Label label11;
        private TextBox txtAPIAddress;
        private Label label21;
        private Button btnClearNewUser;
    }
}