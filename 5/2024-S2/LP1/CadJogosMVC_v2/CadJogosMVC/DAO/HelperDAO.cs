﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadJogosMVC.DAO
{
    public static class HelperDAO
    {
        public static void ExecutaSQL(String sql,
                           SqlParameter[] parametros)
        {
            using (var cx = ConexaoBD.GetConexao())
            {
                using (var cmd = new SqlCommand(sql, cx))
                {
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    conexao.Close();
                    return tabela;
                }
            }
        }
    }
}