namespace SupermarketDesktop
{
    partial class CreateUserScreen
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
            cbxUserRules = new ComboBox();
            maskedPassword = new MaskedTextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnCreateUser = new Button();
            Password = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            maskedConfPass = new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbxUserRules
            // 
            cbxUserRules.FormattingEnabled = true;
            cbxUserRules.Location = new Point(348, 215);
            cbxUserRules.Name = "cbxUserRules";
            cbxUserRules.Size = new Size(151, 28);
            cbxUserRules.TabIndex = 0;
            cbxUserRules.SelectedIndexChanged += cbxUserRules_SelectedIndexChanged;
            // 
            // maskedPassword
            // 
            maskedPassword.Location = new Point(201, 125);
            maskedPassword.Name = "maskedPassword";
            maskedPassword.PasswordChar = '*';
            maskedPassword.Size = new Size(298, 27);
            maskedPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 84);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(405, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(201, 278);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(94, 29);
            btnCreateUser.TabIndex = 4;
            btnCreateUser.Text = "Create";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += button2_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(122, 132);
            Password.Name = "Password";
            Password.Size = new Size(73, 20);
            Password.TabIndex = 5;
            Password.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(201, 81);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(298, 27);
            txtUsername.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 172);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 9;
            label3.Text = "Confirm Password:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxUserRules);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(maskedConfPass);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(btnCreateUser);
            groupBox1.Controls.Add(maskedPassword);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 364);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create User";
            // 
            // maskedConfPass
            // 
            maskedConfPass.Location = new Point(201, 169);
            maskedConfPass.Name = "maskedConfPass";
            maskedConfPass.PasswordChar = '*';
            maskedConfPass.Size = new Size(298, 27);
            maskedConfPass.TabIndex = 8;
            // 
            // CreateUserScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 388);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateUserScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create User";
            Load += CreateUserScreen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbxUserRules;
        private MaskedTextBox maskedPassword;
        private Label label1;
        private Button btnCancel;
        private Button btnCreateUser;
        private Label Password;
        private TextBox txtUsername;
        private Label label3;
        private GroupBox groupBox1;
        private MaskedTextBox maskedConfPass;
    }
}