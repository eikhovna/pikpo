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
    public partial class Add_Form : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Form()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var type = textBox_type.Text;
            var count = textBox_count.Text;
            var provider = textBox_provider.Text;
            int price;

            if(int.TryParse(textBox_price.Text, out price) ) 
            { 
                var addQuery = $"insert into test_db (type, count, provider, price) values('{type}', '{count}', '{provider}', '{price}')";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Entry create!");
            }
            else 
            {
                MessageBox.Show("Error");
            }
            dataBase.closeConnection();
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
