using SENAI.Rental.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Interfaces
{
    interface IModeloRepository
    {
        List<ModeloDomain> ListarTodos();
        ModeloDomain BusscarPorId(int IdMarca);
        void Cadastrar(ModeloDomain NovoModelo);
        void AtualizarPorUrl(int IdModelo, ModeloDomain ModeloAtualizado);
        void Deletar(int IdModelo);
    }
}
