using Microsoft.EntityFrameworkCore;
using Polynomtech.PolynomTech.Dal.Abstract;
using Polynomtech.PolynomtechEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web.Http.OData;

namespace Polynomtech.PolynomTech.Dal.Concrate
{
    public class RepositoryParfume : IRepositoryParfume
    {
        private readonly PolynomDbContext db;
        private DbSet<Parfume> _objectset;
        public RepositoryParfume(PolynomDbContext db)
        {
            this.db = db;
            _objectset = db.Set<Parfume>();//Class çağrıldığı anda construtor tanımlaması ile  veritabanında bir kere set edilme gerçekleşir.Performans için yapıldı.         
        }

        public void Add(Parfume parfume)
        {
            _objectset.Add(parfume);
            db.SaveChanges();
        }

        public IQueryable<Parfume> GetList(Expression<Func<Parfume, bool>> Linq)
        {
            return _objectset.Where(Linq);

        }
        public IQueryable<Parfume> GetTable()
        {
            return _objectset.AsQueryable();
        }
        
    }
}
