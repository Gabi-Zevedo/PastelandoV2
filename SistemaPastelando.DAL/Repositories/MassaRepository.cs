using SistemaPastelando.BLL.Models;
using SistemaPastelando.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPastelando.DAL.Repositories
{
    public class MassaRepository : GenericRepository<Massa>, IMassaRepository
    {
        private readonly Context _context;

        public MassaRepository(Context context) : base (context)
        {
            _context = context;
        }
    }
}
