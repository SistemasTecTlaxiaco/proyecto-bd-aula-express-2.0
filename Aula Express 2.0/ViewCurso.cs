using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aula_Express_2._0
{
    public partial class Form6 : Form
    {
        conexion conMysql = new conexion();

        public Form6()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            textCodigo.Text = " ";
            textNombre.Text = " ";
            textDescricion.Text = " ";
            textObjetivo.Text = " ";
            textImparte.Text = " ";
            dataGridView1.ClearSelection();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text.Trim() == String.Empty &&
               textNombre.Text.Trim() == String.Empty &&
               textDescricion.Text.Trim() == String.Empty &&
               textObjetivo.Text.Trim()== String.Empty &&
               textImparte.Text.Trim() == String.Empty)
            {
                MessageBox.Show("!!!... Error, los campos no pueden estar vacios ...!!!");
                return;
            }

            if (textCodigo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar un Código");
                return;
            }

            if (textNombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar un Nombre al Curso");
                return;
            }

            if (textDescricion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar una Descripcion");
                return;
            }
            if (textObjetivo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar el objetivo");
                return;
            }
            if (textImparte.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar quien imparte el curso");
                return;
            }

            String sql = String.Format("INSERT INTO `cursos`(`id`, `nombre`, `descripcion`, `objetivo`, `id_instructor`) VALUES " + "('"
                                  + textCodigo.Text + "','" + textNombre.Text + "','" + textDescricion.Text + "','" + textObjetivo.Text + "','" + textImparte.Text + "')",
                                   textCodigo.Text.Trim(), textNombre.Text.Trim(), textDescricion.Text.Trim(), textObjetivo.Text.Trim(), textImparte.Text.Trim());

            try
            {
                if (conMysql.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... guardado con éxito ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo guardar ...!!!");
                }
                limpiar();
                MessageBox.Show(sql);
            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Btnborrar_Click(object sender, EventArgs e)
        {
            string sql = String.Format("DELETE FROM `cursos` WHERE `cursos`.`id` = '" + textCodigo.Text +"'", dataGridView1.SelectedRows);
            if (MessageBox.Show("¿Deseas Eliminar El Curso?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (conMysql.Query(sql) == 1)
                    {
                        MessageBox.Show("!!!... Curso Eliminado ...!!!");
                    }
                    else
                    {
                        MessageBox.Show("!!!... ERROR, No se pudo eliminar ...!!!");
                    }
                    limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas salir?", "CURSOS EXPRESS",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                MessageBox.Show("!!!... CERRANDO SESSION ...!!!");
                this.Close();
                Application.Exit();
            }
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

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `cursos`";
            dataGridView1.Select();
            dataGridView1.DataSource = ListCursos(sql);
        }

        private void BtnCerrarsecion_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }
    }
}
