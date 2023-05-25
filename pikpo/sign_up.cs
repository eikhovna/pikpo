using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace pikpo
{
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '*';
        }

        private void button_reg2_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login2.Text;
            var passUser = textBox_password2.Text;

            string querystring = $"insert into registration(login_user, password_user) values('{loginUser}', '{passUser}', 0)";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            
            dataBase.openConnection();
            
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account create!");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error!");
            }

            dataBase.closeConnection();
        }

        private Boolean checkuser()
        {
            var loginUse = textBox_login2.Text;
            var passwordUse = textBox_password2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from registration where login_user = '{loginUse}' and password_user = '{passwordUse}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            
            adapter.SelectCommand= command;
            adapter.Fill(table);

            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("Account already exists!");
                return true;
            }
            else
            { 
                return false;   
            }
        }
        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
