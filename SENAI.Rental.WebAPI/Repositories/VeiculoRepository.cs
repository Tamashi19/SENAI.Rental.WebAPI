using SENAI.Rental.WebAPI.Domains;
using SENAI.Rental.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private string stringConexao = "Data Source=DEV/SQLEXPRESS; initial catalog=T_Rental_DB; user Integrated Security=true";
        public void AtualizarPorUrl(int IdVeiculo, VeiculoDomain VeiculoAtualizado)
        {
            throw new NotImplementedException();
        }

        public VeiculoDomain BusscarPorId(int IdVeiculo)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(VeiculoDomain NovoVeiculos)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int IdVeiculo)
        {
            throw new NotImplementedException();
        }

        public List<VeiculoDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
