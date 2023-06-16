using Ahpcz.DataAccess.Context;
using Ahpcz.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahpcz.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AhpczDbContext _context;

        public UnitOfWork(AhpczDbContext context)
        {
            _context = context;
            City = new CityRepository(_context);
            District = new  DistrictRepository(_context);
            Province = new ProvinceRepository(_context);
        }
        public ICityRepository City { get; private set; }
        public IDistrictRepository District { get; private set; }
        public IProvinceRepository Province { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
