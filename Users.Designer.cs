namespace SupermarketDesktop
{
    partial class Users
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
            dgUsers = new DataGridView();
            btnCreateUser = new Button();
            btnReadUsers = new Button();
            btnUpdateuser = new Button();
            btnDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            SuspendLayout();
            // 
            // dgUsers
            // 
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Location = new Point(12, 38);
            dgUsers.Name = "dgUsers";
            dgUsers.RowHeadersWidth = 51;
            dgUsers.Size = new Size(755, 315);
            dgUsers.TabIndex = 0;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(24, 387);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(94, 51);
            btnCreateUser.TabIndex = 1;
            btnCreateUser.Text = "Create";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnReadUsers
            // 
            btnReadUsers.Location = new Point(181, 387);
            btnReadUsers.Name = "btnReadUsers";
            btnReadUsers.Size = new Size(94, 51);
            btnReadUsers.TabIndex = 2;
            btnReadUsers.Text = "Read";
            btnReadUsers.UseVisualStyleBackColor = true;
            // 
            // btnUpdateuser
            // 
            btnUpdateuser.Location = new Point(342, 387);
            btnUpdateuser.Name = "btnUpdateuser";
            btnUpdateuser.Size = new Size(94, 51);
            btnUpdateuser.TabIndex = 3;
            btnUpdateuser.Text = "Update";
            btnUpdateuser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(510, 387);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(94, 51);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 450);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnUpdateuser);
            Controls.Add(btnReadUsers);
            Controls.Add(btnCreateUser);
            Controls.Add(dgUsers);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgUsers;
        private Button btnCreateUser;
        private Button btnReadUsers;
        private Button btnUpdateuser;
        private Button btnDeleteUser;
    }
}