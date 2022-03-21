using SistemaPastelando.BLL.Models;
using SistemaPastelando.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPastelando.DAL.Repositories
{
    public class CardapioRepository : GenericRepository<Cardapio>, ICardapioRepository
    {
        public CardapioRepository(Context context) : base(context)
        {
        }
    }
}
