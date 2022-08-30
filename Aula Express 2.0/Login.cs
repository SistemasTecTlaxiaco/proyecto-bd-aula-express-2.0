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
    public partial class Login : Form
    {
        conexion conMysql = new conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(radEstudiante.Checked==false && radInstructor.Checked == false)
            {
                MessageBox.Show("SELECIONE QUE USUARIO INICIA SESION");
                return;
            }
            else
            {
                BuscarUsuario();
            }

            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Form1 frmMain = new Form1();
            frmMain.Show();
            this.Hide();
        }

        private void BuscarUsuario()
        {
            if (radInstructor.Checked)
            {
                String sql1 = String.Format(@"select correo_instructor,contraseña_instructor from login_instructor where correo_instructor='" + textBox1.Text + "' and contraseña_instructor='" + textBox2.Text + "'");
                DataRow fila = conMysql.getRow(sql1);

                if (fila != null)
                {
                    Form6 frmCurso = new Form6();
                    frmCurso.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("USUARIO NO ENCONTRADO");
                    return;
                }


            }
            else
            {
                if (radEstudiante.Checked)
                {
                    String sql1 = String.Format(@"select correo_estudiante,Contraseña_estudiante from login_studen where correo_estudiante='" + textBox1.Text + "' and Contraseña_estudiante='" + textBox2.Text + "'");
                    DataRow fila = conMysql.getRow(sql1);
                    if (fila != null)
                    {
                        Form5 frmCurso = new Form5();
                        frmCurso.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("USUARIO NO ENCONTRADO");
                        return;
                    }
                }
            }

        }

    }
}
