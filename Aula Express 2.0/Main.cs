using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_Express_2._0
{
   
    public partial class Form1: Form
    {
        conexion conMysql = new conexion();
        public Form1()
        {
            InitializeComponent();
            try
            {
                conMysql.Connect();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRegIntru_Click(object sender, EventArgs e)
        {
            NewUserInstructor userInstructor = new NewUserInstructor();
            userInstructor.Show();
            this.Hide();
        }

        private void btnRegEst_Click(object sender, EventArgs e)
        {
            NewUserStudent userStudent = new NewUserStudent();
            userStudent.Show();
            this.Hide();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Login frmIniSesion = new Login();
            frmIniSesion.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
