using SENAI.Rental.WebAPI.Domains;
using SENAI.Rental.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private string stringConexao = "Data Source=DEV/SQLEXPRESS; initial catalog=T_Rental_DB; user Integrated Security=true";
        public void AtualizarPorUrl(int IdCliente, ClienteDomain ClienteAtualizado)
        {
            throw new NotImplementedException();
        }

        public ClienteDomain BusscarPorId(int IdCliente)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ClienteDomain NovoCliente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int IdCliente)
        {
            throw new NotImplementedException();
        }

        public List<ClienteDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
