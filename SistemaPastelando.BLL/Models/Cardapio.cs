using SistemaPastelando.BLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPastelando.BLL.Models
{
    public class Cardapio
    {
        public int ItemId { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double ValorAdicional { get; set; }
        public TipoIngrediente Tipo { get; set; }
    }
}
