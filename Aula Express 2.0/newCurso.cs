using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aula_Express_2._0
{
    public partial class Form5 : Form
    {
        conexion conMysql = new conexion();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        public DataTable ListCursos(string sql)
        {
            conMysql.Connect();
            DataTable ver = new DataTable();
            conMysql.Query(sql);
            conMysql.getData(sql);
            conMysql.getRow(sql);
            dataGridView1.DataSource = ver;
            return conMysql.getData(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "SELECT * FROM `cursos`";
            dataGridView1.Select();
            dataGridView1.DataSource = ListCursos(sql);
        }
    }
}
