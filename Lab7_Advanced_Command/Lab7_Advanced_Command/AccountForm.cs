using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            downloadForm();
        }

        private void downloadForm()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            string sql = "select [AccountName], [Password], [FullName], [Email], [Tell], [DateCreated] from Account ";
            conn.Open();
            cmd.CommandText = sql;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable("Food");
            adapter.Fill(table);
            dgvAcc.DataSource = table;
            conn.Close();
            conn.Dispose();
        }
    }
}
