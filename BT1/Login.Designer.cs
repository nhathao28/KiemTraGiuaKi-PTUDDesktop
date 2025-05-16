using System.Data.SqlClient;
namespace BT1
{
    partial class Login
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
        private SqlConnection ConnectToDatabase()
        {
            string connectioString = "Data Source=.;Initial Catalog=Bank_DB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectioString);
            return connection;
        }
        private bool CheckLogin(string accountId, string password)
        {
            string connectionString = "Data Source=.;Initial Catalog=Bank_DB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string querry = "SELECT COUNT(*) FROM bank_account WHERE account_id = @id AND password = @pass";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@id", accountId);
                cmd.Parameters.AddWithValue("@pass", password);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count > 0;   
            }    
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAccountID = new Label();
            txtAccountID = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblAccountID
            // 
            lblAccountID.AutoSize = true;
            lblAccountID.Location = new Point(77, 84);
            lblAccountID.Name = "lblAccountID";
            lblAccountID.Size = new Size(72, 15);
            lblAccountID.TabIndex = 0;
            lblAccountID.Text = "Account ID :";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(179, 81);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(181, 23);
            txtAccountID.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(77, 121);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(179, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(181, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(221, 162);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 260);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtAccountID);
            Controls.Add(lblAccountID);
            Name = "Login";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountID;
        private TextBox txtAccountID;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
