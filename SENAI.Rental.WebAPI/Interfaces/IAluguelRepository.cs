using SENAI.Rental.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Interfaces
{
    interface IAluguelRepository
    {
        List<AluguelDomain> ListarTodos();
        AluguelDomain BusscarPorId(int IdAluguel);
        void Cadastrar(AluguelDomain NovoAluguel);
        void AtualizarPorUrl(int IdAluguel, AluguelDomain AluguelAtualizado);
        void Deletar(int IdAluguel);
    }
}
