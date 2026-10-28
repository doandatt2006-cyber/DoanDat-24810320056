namespace DoanDat_24810320056
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnExit = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 13);
            label1.Name = "label1";
            label1.Size = new Size(110, 100);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:\r\n\r\n\r\n\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(167, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 56);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:\r\n";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(167, 56);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(167, 105);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(127, 24);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(67, 150);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(182, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnExit;
        private ErrorProvider errorProvider1;
    }
}
