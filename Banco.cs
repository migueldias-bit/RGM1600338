using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RECREGM1600338
{
    public class Banco
    {
        private static string strconn;

        public static MySqlCommand Abrir()
        {
            strconn = @"server=127.0.0.1;user id=root;database=atividadeDB_td;password=root"; // String de conexao MySQL WORKBENCH****
            MySqlConnection cn = new MySqlConnection();
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            return comm;
        }

        public static void Fechar(MySqlCommand comm)

        {
            var cn = comm.Connection;
            if(cn.State == ConnectionState.Open)
            {
                comm.Connection.Close();
            }
    }
}
}