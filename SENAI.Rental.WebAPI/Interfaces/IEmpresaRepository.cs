using SENAI.Rental.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Interfaces
{
    interface IEmpresaRepository
    {
        List<EmpresaDomain> ListarTodos();
        EmpresaDomain BusscarPorId(int IdEmpresa);
        void Cadastrar(EmpresaDomain NovaEmpresa);
        void AtualizarPorUrl(int IdEmpresa, EmpresaDomain EmpresaAtualizada);
        void Deletar(int IdEmpresa);
    }
}
