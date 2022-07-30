using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_Express_2._0
{
    public partial class NewUserInstructor : Form
    {
        conexion conMysql = new conexion();
        Form1 frmMain = new Form1();

        public NewUserInstructor()
        {
            InitializeComponent();
        }
        public void guardarUser()
        {
            //Correccion de sitaxis, nombre_apellidos
            string sql = string.Format("INSERT INTO `login_instructor`(`id`, `usuario`, `nombre`, `contraseña`)" +
                                        "VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')",
                                          textBox1.Text, textBox2.Text, textBox3.Text);
            
            try
            {

                if (conMysql.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Registro de Usuario éxitoso ...!!!");
                    
                    Login frmIniciarSesion = new Login();
                    frmIniciarSesion.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo registar ...!!!");

                    frmMain.Show();
                    this.Hide();
                }
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //Acceder
        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == String.Empty && textBox2.Text.Trim() == String.Empty && textBox3.Text.Trim() == String.Empty)
            {
                MessageBox.Show("!!!... Error, los campos no pueden estar vacios ...!!!");
                return;
            }
            guardarUser();
        }

        //Boton atras
        private void button1_Click(object sender, EventArgs e)
        {
            frmMain.Show();
            this.Hide();
        }

        private void NewUserInstructor_Load(object sender, EventArgs e)
        {



        }
    }
}

