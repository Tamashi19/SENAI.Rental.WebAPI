using SENAI.Rental.WebAPI.Domains;
using SENAI.Rental.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Repositories
{
    public class AluguelRepository : IAluguelRepository
    {
        private string stringConexao = "Data Source=DEV/SQLEXPRESS; initial catalog=T_Rental_DB; user Integrated Security=true";
        public void AtualizarPorUrl(int IdAluguel, AluguelDomain AluguelAtualizado)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdateUrl = "UPDATE ALUGUEL SET = @idCliente, @idVeiculo, @dataInicio, @dataFim WHERE idAluguel = @idAluguel";

                using (SqlCommand cmd = new SqlCommand(queryUpdateUrl, con))
                {
                    cmd.Parameters.AddWithValue("@idAluguel", IdAluguel);
                    cmd.Parameters.AddWithValue("@idCliente", AluguelAtualizado.Cliente.idCliente);
                    cmd.Parameters.AddWithValue("@idVeiculo", AluguelAtualizado.veiculo.idVeiculo);
                    cmd.Parameters.AddWithValue("@dataInicio", AluguelAtualizado.dataInicio);
                    cmd.Parameters.AddWithValue("@dataFim", AluguelAtualizado.dataFim);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public AluguelDomain BuscarPorId(int idAluguel)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectById = @"SELECT A.dataAluguel, 
                                                   A.dataDevolucao, 
	                                               C.nomeCliente, 
                                                   C.sobrenomeCliente,
                                                   V.placa,
	                                               M.nomeModelo,
	                                               MA.nomeMarca
                                              FROM ALUGUEL A
                                             INNER JOIN CLIENTE C
                                                ON A.idCliente = C.idCliente
                                             INNER JOIN VEICULO V
                                                ON A.idVeiculo = V.idVeiculo
                                             INNER JOIN MODELO M
                                                ON V.idModelo = M.idModelo
                                             INNER JOIN MARCA MA
                                                ON M.idMarca = MA.idMarca
                                             WHERE idAluguel = @idAluguel";

                con.Open();

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@idAluguel", idAluguel);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        AluguelDomain AluguelBuscado = new AluguelDomain()
                        {
                            idAluguel = Convert.ToInt32(reader["idAluguel"]),

                            Cliente = new ClienteDomain()
                            {
                                idCliente = Convert.ToInt32(reader["idCliente"]),
                            },

                            veiculo = new VeiculoDomain()
                            {
                                idVeiculo = Convert.ToInt32(reader["idVeiculo"])
                            },

                            dataInicio = Convert.ToDateTime(reader["dataInicio"]),

                            dataFim = Convert.ToDateTime(reader["dataFim"])
                        };

                        return AluguelBuscado;
                    }

                    return null;
                }
            }
        }

        public AluguelDomain BusscarPorId(int IdAluguel)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(AluguelDomain novoAluguel)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Aluguel(idCliente, idVeiculo, dataInicio, dataFim) VALUES (@idCliente, @idVeiculo, @dataInicio, @dataFim)";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@idAluguel", novoAluguel.idAluguel);
                    cmd.Parameters.AddWithValue("@idCliente", novoAluguel.Cliente.idCliente);
                    cmd.Parameters.AddWithValue("@idVeiculo", novoAluguel.veiculo.idVeiculo);
                    cmd.Parameters.AddWithValue("@dataInicio", novoAluguel.dataInicio);
                    cmd.Parameters.AddWithValue("@dataFim", novoAluguel.dataFim);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Deletar(int idAluguel)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM ALUGUEL WHERE idAluguel = @idAluguel";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@idAluguel", idAluguel);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<AluguelDomain> ListarTodos()
        {
            List<AluguelDomain> listaAlugueis = new List<AluguelDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idAluguel, idCliente, idVeiculo, dataInicio, dataFim FROM ALUGUEL";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        AluguelDomain Aluguel = new AluguelDomain()
                        {
                            idAluguel = Convert.ToInt32(rdr[0]),
                            Cliente = new ClienteDomain()
                            {
                                idCliente = Convert.ToInt32(rdr[1]),
                            },
                            veiculo = new VeiculoDomain()
                            {
                                idVeiculo = Convert.ToInt32(rdr[2]),
                            },

                            dataInicio = Convert.ToDateTime(rdr[3]),

                            dataFim = Convert.ToDateTime(rdr[4]),

                        };

                        listaAlugueis.Add(Aluguel);

                    }
                }

            }
            return listaAlugueis;
        }
    }
}