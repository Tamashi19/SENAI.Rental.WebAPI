using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Domains
{
    public class AluguelDomain
    {
        public int idAluguel { get; set; } 
        public int idVeiculo { get; set; }
        public int idCliente { get; set; }

    }
}
