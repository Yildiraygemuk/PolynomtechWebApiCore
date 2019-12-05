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
    public class RepositoryOrderDetail : IRepositoryOrderDetail
    {
        private readonly PolynomDbContext db;
        private DbSet<OrderDetail> _objectset;
        public RepositoryOrderDetail(PolynomDbContext db)
        {
            this.db = db;
            _objectset = db.Set<OrderDetail>();//Class çağrıldığı anda construtor tanımlaması ile  veritabanında bir kere set edilme gerçekleşir.Performans için yapıldı.         
        }

        public void Add(OrderDetail orderDetail)
        {
            _objectset.Add(orderDetail);
            db.SaveChanges();
        }

        public IQueryable<OrderDetail> GetList(Expression<Func<OrderDetail, bool>> Linq)
        {
            return _objectset.Where(Linq);

        }
        public IQueryable<OrderDetail> GetTable()
        {
            return _objectset.AsQueryable();
        }

    }
}
