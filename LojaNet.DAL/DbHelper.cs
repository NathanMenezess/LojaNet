﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace LojaNet.DAL
{
    public static class DbHelper
    {
        private static string conexao { 
            get
            {
                return @"Data Source=DESKTOP-JT6KL2F\SQLEXPRESS; 
                        Initial Catalog=LojaNetDb; 
                        Integrated Security=true";

            }


        }

        public static SqlDataReader ExecuteReader (string stroredProcedure, params object[] parametros)
        {
            var cn = new SqlConnection(conexao);
            var cmd = new SqlCommand(stroredProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            PreencherParametros(parametros, cmd);
            cn.Open();
            var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader; 
        }

        public static int ExecuteNonQuery(string storedProcedure, params object[] parametros )
        {
            int retorno = 0; 
            using (var cn = new SqlConnection(conexao))
            {
                using (var cmd = new SqlCommand(storedProcedure, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    PreencherParametros(parametros, cmd);
                    cn.Open();
                    retorno = cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            return retorno;
        }

        private static void PreencherParametros(object[] parametros, SqlCommand cmd)
        {
            if (parametros.Length > 0)
            {
                for (int i = 0; i < parametros.Length; i += 2)
                {
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                }
            }
        }
    }
}
