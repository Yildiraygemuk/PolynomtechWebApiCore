using Polynomtech.PolynomtechEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polynomtech.PolynomTech.Dal.Abstract
{
    public interface IRepositoryOrderDetail
    {
        IQueryable<OrderDetail> GetTable();
        void Add(OrderDetail orderDetail);
    }
}
