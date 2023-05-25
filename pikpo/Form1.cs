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
using System.Reflection;

namespace pikpo
{
    public partial class Form1 : Form
    {
        //private readonly CheckUser _user;

        enum RoWState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }

        DataBase dataBase = new DataBase();

        int selectedRow;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //_user = user;
        }

        /*private void IsAdmin()
        {
            управлениеToolStripMenuItem.Enabled = _user.IsAdmin;
            buttondel.Enabled = _user.IsAdmin;
            buttonedit.Enabled = _user.IsAdmin;
            buttonsave.Enabled = _user.IsAdmin;
            buttonnew.Enabled = _user.IsAdmin;
        }*/

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add ("tape", "Товар");
            dataGridView1.Columns.Add("count", "Количество");
            dataGridView1.Columns.Add("provider", "Поставщик");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            textBoxid.Text = "";
            textBoxtype.Text = "";
            textBoxcount.Text = "";
            textBoxprovider.Text = "";
            textBoxprice.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //toolStripTextBox1.Text = $"{_user.Login}:{_user.Status}";
            //IsAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), RoWState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        { 
            dgw.Rows.Clear();

            string queryString = $"select * from test_db";

            
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
           
            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            { 
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0 )
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxid.Text = row.Cells[0].Value.ToString();
                textBoxtype.Text = row.Cells[1].Value.ToString();
                textBoxcount.Text = row.Cells[2].Value.ToString();
                textBoxprovider.Text = row.Cells[3].Value.ToString();
                textBoxprice.Text = row.Cells[4].Value.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void buttonnew_Click(object sender, EventArgs e)//создание новой записи
        {
            Add_Form add_Form = new Add_Form();
            add_Form.Show();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from test_db where concat(id, type, count, provider, price) like '%" + textBox1.Text + "%'";
            
            SqlCommand command = new SqlCommand(searchString, dataBase.GetConnection());

            
            dataBase.openConnection();
            
            SqlDataReader read = command.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RoWState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RoWState.Deleted;
            
        }
        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RoWState)dataGridView1.Rows[index].Cells[5].Value;
                if (rowState == RoWState.Existed)
                    continue;

                if (rowState == RoWState.Deleted) 
                { 
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from test_db where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RoWState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var count = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var provider = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update test_db set type = '{type}', count = '{count}', provider = '{provider}', price = '{price}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void buttondel_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBoxid.Text;
            var type = textBoxtype.Text;
            var count = textBoxcount.Text;
            var provider = textBoxprovider.Text;
            int price;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(textBoxprice.Text, out price))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, type, count, provider, price);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RoWState.Modified;    
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
