using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class RepositorioMySQL : IRepositorio
    {
        private readonly string stringDeConexao = "server=localhost;user id=root;pwd=190618;database=duas_camadas2";
        private void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            MySqlConnection con = ObterConexao();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                foreach (MySqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void Inserir(Moedas moedas)
        {
            try
            {
                ExecuteNonQuery($"INSERT INTO Moedas (Moeda, Territorio, Simbolo, CodigoIso, UnidadeFracionaria, valorEmReal) values (@Moeda, @Territorio, @Simbolo, @CodigoIso, @UnidadeFracionaria, @valorEmReal)", new MySqlParameter("@Moeda", moedas.Moeda), new MySqlParameter("@Territorio", moedas.Territorio), new MySqlParameter("@Simbolo", moedas.Simbolo), new MySqlParameter("@CodigoIso", value: moedas.CodigoIso), new MySqlParameter("@UnidadeFracionaria", moedas.UnidadeFracionaria), new MySqlParameter(@"valorEmReal", moedas.valorEmReal));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Deletar(string Territorio)
        {
            try
            {
                ExecuteNonQuery($"DELETE FROM Moedas WHERE Territorio = @Territorio", new MySqlParameter("@Territorio", Territorio));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Moedas Consultar(string Territorio)
        {
            Moedas moedas = null;
            MySqlConnection con = ObterConexao();
            MySqlDataReader dr = null;
            try
            {
                dr = ExecuteReader(con, $"SELECT * FROM Moedas WHERE like @Territorio", new MySqlParameter("@Territorio", Territorio));
                while (dr.Read())
                {
                    moedas = new Moedas(dr.GetInt32("Id"), dr.GetString("Moeda"), dr.GetString("Territorio"), dr.GetString("Simbolo"), dr.GetString("CodigoIso"), dr.GetString("UnidadeFracionaria"), dr.GetInt32("valorEmReal"));
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexaoEDataReader(con, dr);
            }
            return moedas;
        }

        public List<Moedas> Listar()
        {
            List<Moedas> moedas = null;
            MySqlConnection con = ObterConexao();
            MySqlDataReader dr = null;
            try
            {
                dr = ExecuteReader(con, $"SELECT * FROM Moedas");
                if (dr.HasRows)
                {
                    moedas = new List<Moedas>();
                    while (dr.Read())
                    {
                        moedas.Add(new Moedas(dr.GetInt32("Id"), dr.GetString("Moeda"), dr.GetString("Territorio"), dr.GetString("Simbolo"), dr.GetString("CodigoIso"), dr.GetString("UnidadeFracionaria"), dr.GetInt32("valorEmReal")));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexaoEDataReader(con, dr);
            }
            return moedas;
        }

        private static void FecharConexaoEDataReader(MySqlConnection con, MySqlDataReader dr)
        {
            con.Close();
            if (dr != null)
            {
                dr.Close();
            }
        }
        private static MySqlDataReader ExecuteReader(MySqlConnection con, string sql, params MySqlParameter[] parameters)
        {
            MySqlDataReader dr;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            foreach (MySqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            dr = cmd.ExecuteReader();
            return dr;
        }

        private MySqlConnection ObterConexao()
        {
            return new MySqlConnection(stringDeConexao);
        }

        Moedas IRepositorio.Consultar(string Territorio)
        {
            throw new NotImplementedException();
        }

        List<Moedas> IRepositorio.Listar()
        {
            throw new NotImplementedException();
        }
    }
}
