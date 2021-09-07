using SENAI.Rental.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Interfaces
{
    interface IClienteRepository
    {
        List<ClienteDomain> ListarTodos();
        ClienteDomain BusscarPorId(int IdCliente);
        void Cadastrar(ClienteDomain NovoCliente);
        void AtualizarPorUrl(int IdCliente, ClienteDomain ClienteAtualizado);
        void Deletar(int IdCliente);
    }
}
