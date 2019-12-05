using Microsoft.EntityFrameworkCore;
using Polynomtech.PolynomTech.Dal.Abstract;
using Polynomtech.PolynomtechEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Polynomtech.PolynomTech.Dal.Concrate
{
    public class RepositoryBrand:IRepositoryBrand
    {
        private readonly PolynomDbContext db;
        private DbSet<Brand> _objectset;
        public RepositoryBrand(PolynomDbContext db)
        {
            this.db = db;
            _objectset = db.Set<Brand>();//Class çağrıldığı anda construtor tanımlaması ile  veritabanında bir kere set edilme gerçekleşir.Performans için yapıldı.         
        }
        public IQueryable<Brand> GetList(Expression<Func<Brand, bool>> Linq)
        {
            return _objectset.Where(Linq);

        }
        public IQueryable<Brand> GetTable()
        {
            return _objectset.AsQueryable();
        }
    }
}
