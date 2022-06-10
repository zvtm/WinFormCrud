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

namespace WinFormCrud
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Form1()
        {
            InitializeComponent();
        }
        #region Methods
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("fio", "ФИО");
            dataGridView1.Columns.Add("den_rojdeniya", "Дата Рождения");
            dataGridView1.Columns.Add("sex", "Пол");
            dataGridView1.Columns.Add("post_job", "Должность");
            dataGridView1.Columns.Add("info", "Информация");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDateTime(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.Modified);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from test1_db";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void ClearFields()
        {
            _textBox_fio.Text = "";
            _textBox_brthDay.Text = "";
            _textBox_sex.Text = "";
            _comboBox__postJob.Text = "";
            _textBox_info.Text = "";

        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void UpdateTable()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from test1_db where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var fio = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var dataRojd = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var sex = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var postJob = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    string info = dataGridView1.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update test1_db set fio = '{fio}', den_rojdeniya = '{dataRojd}', sex = '{sex}', post_job = '{postJob}', info = '{info}' where id = '{id}' "; //

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            dataBase.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = dataGridView1.Rows[0].Cells[0].Value.ToString();
            var fio = _textBox_fio.Text;
            var dataRojd = _textBox_brthDay.Text;
            var sex = _textBox_sex.Text;
            var postJob = _comboBox__postJob.Text;
            string info = _textBox_info.Text;

            if (dataGridView1.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, fio, dataRojd, sex, postJob, info);
                dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
            }

        }

        //private void Search(DataGridView dgw)
        //{
        //    dgw.Rows.Clear();

        //    string searchString = $"select * from test1_db where concat (id,fio,den_rojdeniya,sex,post_job) like'%" + _textBox_search.Text + "% '";
        //    SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

        //    dataBase.openConnection();
        //    SqlDataReader read = com.ExecuteReader();

        //    while (read.Read())
        //    {
        //        ReadSingleRow(dgw, read);
        //    }

        //    read.Close();
        //}
        //Поиск не работает
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            _comboBox__postJob.DataSource = Enum.GetValues(typeof(Job)).Cast<Job>().ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                _textBox_fio.Text = row.Cells[1].Value.ToString();
                _textBox_brthDay.Text = row.Cells[2].Value.ToString();
                _textBox_sex.Text = row.Cells[3].Value.ToString();
                _comboBox__postJob.Text = row.Cells[4].Value.ToString();
                _textBox_info.Text = row.Cells[5].Value.ToString();
            }
        }

        private void _button_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void _button_newRecord_Click(object sender, EventArgs e)
        {
            Add_Form addForm = new Add_Form();
            addForm.Show();
        }

        private void _textBox_search_TextChanged(object sender, EventArgs e)
        {
            //Search(dataGridView1);
        }

        private void _button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void _button_save_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void _button_edit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void _button_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
