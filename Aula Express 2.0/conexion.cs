using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Aula_Express_2._0
{
    class conexion
    {
        const string HOST = "localhost";
        const string USER = "root";
        const string PASS = "''";
        const string DB = "systema_cursosv";

        MySqlConnection MiConexion = new MySqlConnection();

        public conexion()
        {
            this.Connect();
        }

        public void Connect()
        {
            if (MiConexion.State == ConnectionState.Closed)
            {
                MiConexion.ConnectionString = String.Format("Server={0}; Database={1}; User ID={2}; Password={3}; Pooling=false;",
                    HOST, DB, USER, PASS);
                MiConexion.Open();
            }
        }

        public int Query(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, MiConexion); 
            return command.ExecuteNonQuery();
        }

        public DataTable getData(string sql)
        {
            this.Connect();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, MiConexion);
            adapter.Fill(table);
            return table;
        }

        public DataRow getRow(string sql)
        {
            DataRow row = null;
            if (this.getData(sql).Rows.Count == 0)
            {
                return null;
            }
            row = this.getData(sql).Rows[0];
            return row;
        }
    }
}
