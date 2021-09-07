using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Domains
{
    public class VeiculoDomain
    {
        public int idVeiculo { get; set; }
        public int idModelo { get; set; }
        public int idEmpresa { get; set; }
        public string placa { get; set; }
    }
}
