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
    enum Job{
        Director = 0,
        Rukovoditel = 1,
        Kontroller = 2,
        Rabochiy = 3
    }
    public partial class Add_Form : Form
    {

        DataBase database = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {
            _comboBox_postJobF2.DataSource = Enum.GetValues(typeof(Job)).Cast<Job>().ToList();
                //.Select(p => new { })
        }

        private void _button_saveF2_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var fio = _textBox_fioF2.Text;
            var dataRojd = _textBox_birthDayF2.Text;
            var sex = _textBox_sexF2.Text;
            var post = _comboBox_postJobF2.Text;
            string info = _textBox_infoF2.Text;

            //if(Enum.GetName(typeof(Job), Job.Director) == post)
            //{
            //    _textBox_infoF2.Text = "Ген.Дир";
            //}
            //else if(Enum.GetName(typeof(Job), Job.Rukovoditel) == post)
            //{
            //    _textBox_infoF2.Text = "Рук.разраб";
            //}
            //else if (Enum.GetName(typeof(Job), Job.Kontroller) == post)
            //{
            //    _textBox_infoF2.Text = "Контр.разраб";
            //}
            //else
            //{
            //    _textBox_infoF2.Text = "Раб.разраб";
            //}
            

            var addQuery = $"insert into test1_db (fio, den_rojdeniya, sex, post_job, info) values ('{fio}', '{dataRojd}', '{sex}', '{post}', '{info}')";
            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();
        }
    }
}
