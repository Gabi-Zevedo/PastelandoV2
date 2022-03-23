using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPastelando.BLL.Models
{
    public class Complemento
    {
        public int ComplementoId { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double ValorAdicional { get; set; }
    }
}
