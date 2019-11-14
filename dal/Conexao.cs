using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using MySql.Data.MySqlClient;
using System.Data;
using Npgsql;

namespace dal
{
    public class Conexao
    {
        /* //private MySqlConnection conexao;
         public string stringConexao = "SERVER=127.0.0.1; DATABASE=SORVETERIABIKOTA;UID=root;PASSWORD=102030br";
     //Metodo para nao retornar valor. utilizado em insertions
         public void executarInsUpDel(object sql)
         {
             string caminho = "SERVER=127.0.0.1; DATABASE=SORVETERIABIKOTA;UID=root;PASSWORD=102030br";
             try
             {
                 //conexao = new MySqlConnection(caminho);
                 //conexao.Open();
                 //MySqlCommand comandos = new MySqlCommand(sql.ToString(), conexao);
                 //comandos.ExecuteReader();
                 //conexao.Close();

             }
             catch (Exception error)
             {
                 throw new Exception("Erro de comandos " + error.Message); ;
             }
         }

     //Metodo para retornar uma datareade. utilizado em selects
         public DataTable executarSelect(object sql)
         {
             string caminho = "SERVER=127.0.0.1; DATABASE=SORVETERIABIKOTA;UID=root;PASSWORD=102030br";
             try
             {
                 //conexao = new MySqlConnection(caminho);
                 //conexao.Open();
                 //MySqlCommand comandos = new MySqlCommand(sql.ToString(), conexao);
                 //IDataReader dr = comandos.ExecuteReader();
             IDataReader dr = null;

                 DataTable dtRetorno = new DataTable();

                 foreach (DataRow nomeColuna in dr.GetSchemaTable().Rows)
                 {
                     DataColumn dtColuna = new DataColumn();
                     dtColuna.ColumnName = nomeColuna["ColumnName"].ToString();
                     dtColuna.DataType = Type.GetType(nomeColuna["DataType"].ToString());
                     dtColuna.ReadOnly = (bool)nomeColuna["isReadOnly"];
                     dtColuna.AutoIncrement = (bool)nomeColuna["isAutoIncrement"];
                     dtColuna.Unique = (bool)nomeColuna["isUnique"];

                     dtRetorno.Columns.Add(dtColuna);
                 }

                 while (dr.Read())
                 {
                     DataRow dtRow = dtRetorno.NewRow();

                     for (int i = 0; i < dtRetorno.Columns.Count; i++)
                     {
                         dtRow[i] = dr[i];
                     }

                     dtRetorno.Rows.Add(dtRow);
                 }
                 //conexao.Close();

                 return dtRetorno;
             }
             catch (Exception error)
             {
                 throw new Exception("Erro de comandos " + error.Message);
             }
         }
         */

        NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=2345;User Id=postgres;Password=xxx;Database=xxx;");

        public NpgsqlConnection retornaConexao()
        {
            conn.Open();
            return conn;
        }

        public DataTable executarSelect(string pSql)
        {
            try
            {
                DataTable dt = new DataTable();
                NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(pSql, conn);
                Adpt.Fill(dt);

                conn.Close();
                return dt;
            }
            catch (Exception error)
            {
                throw new Exception("Erro de comandos " + error.Message);
            }
        }
        public DataTable executarSelect (NpgsqlCommand pSql, NpgsqlConnection pConnection)
        {
            try
            {
                DataTable dt = new DataTable();
                pSql.Connection = pConnection;

                NpgsqlDataReader Adpt = pSql.ExecuteReader();
                dt.Load(Adpt);

                pConnection.Close();
                return dt;
            }
            catch (Exception error)
            {
                throw new Exception("Erro de comandos " + error.Message);
            }
        }
        
        public void executarInsUpDel(NpgsqlCommand pSql, NpgsqlConnection pConnection)
        {
            try
            {
                pSql.Connection = pConnection;

                pSql.ExecuteNonQuery();
                pConnection.Close();
            }
            catch (Exception error)
            {
                throw new Exception("Erro de comandos " + error.Message); ;
            }
        }
        public void executarInsUpDel(string pSql)
        {
            try
            {
                conn.Open();
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(pSql, conn))
                {
                pgsqlcommand.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception error)
            {
                throw new Exception("Erro de comandos " + error.Message); ;
            }
        }

        public NpgsqlTransaction startTransaction(NpgsqlConnection pConnection)
        {
            return (NpgsqlTransaction)pConnection.BeginTransaction();
        }

        public void cancelTransaction(NpgsqlTransaction pTransaction)
        {
            pTransaction.Rollback();
        }

        public void commitTransaction(NpgsqlTransaction pTransaction)
        {
            pTransaction.Commit();
        }
    }
}
