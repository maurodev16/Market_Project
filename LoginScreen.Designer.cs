namespace WinFormsApp1
{
    partial class LoginScreen
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
            btnLogin = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            maskedPassword = new MaskedTextBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(225, 224);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(378, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 79);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 151);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(225, 102);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 27);
            txtUsername.TabIndex = 4;
            // 
            // maskedPassword
            // 
            maskedPassword.Location = new Point(225, 174);
            maskedPassword.Name = "maskedPassword";
            maskedPassword.PasswordChar = '*';
            maskedPassword.Size = new Size(247, 27);
            maskedPassword.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 282);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 306);
            Controls.Add(maskedPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginScreen";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private MaskedTextBox maskedPassword;
        private GroupBox groupBox1;
    }
}