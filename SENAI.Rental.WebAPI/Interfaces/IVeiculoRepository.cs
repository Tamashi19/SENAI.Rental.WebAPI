using SENAI.Rental.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Interfaces
{
    interface IVeiculoRepository
    {
        List<VeiculoDomain> ListarTodos();
        VeiculoDomain BusscarPorId(int IdVeiculo);
        void Cadastrar(VeiculoDomain NovoVeiculos);
        void AtualizarPorUrl(int IdVeiculo, VeiculoDomain VeiculoAtualizado);
        void Deletar(int IdVeiculo);
    }
}
