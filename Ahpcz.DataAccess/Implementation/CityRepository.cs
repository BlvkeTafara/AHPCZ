using Ahpcz.DataAccess.Context;
using Ahpcz.Domain.Entities;
using Ahpcz.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahpcz.DataAccess.Implementation
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(AhpczDbContext context) : base(context)
        {
            
        }
    }
}
