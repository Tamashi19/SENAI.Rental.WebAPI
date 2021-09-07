using SENAI.Rental.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Interfaces
{
    interface IMarcaRepository
    {
        List<MarcaDomain> ListarTodos();
        MarcaDomain BusscarPorId(int IdMarca);
        void Cadastrar(MarcaDomain NovaMarca);
        void AtualizarPorUrl(int IdMarca, MarcaDomain MarcaAtualizada);
        void Deletar(int IdMarca);
    }
}
