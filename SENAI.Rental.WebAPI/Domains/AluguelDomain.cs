using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Rental.WebAPI.Domains
{
    public class AluguelDomain
    {
        public int idAluguel { get; set; } 
        public VeiculoDomain veiculo{ get; set; }
        public ClienteDomain Cliente { get; internal set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
    }
}
