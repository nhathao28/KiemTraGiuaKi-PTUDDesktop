using System.Data.SqlClient;
namespace BT1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountId = txtAccountID.Text.Trim();
            string password = txtPassword.Text.Trim();
            string connectionString = "Data Source=.Initial Catalog=Bank_DB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM bank_account WHERE account_id =@id AND password = @pw";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", accountId);
                    cmd.Parameters.AddWithValue("@pw", password);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!");

                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);                
                }
            }
        }
    }
}


