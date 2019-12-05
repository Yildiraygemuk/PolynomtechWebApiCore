using Polynomtech.PolynomtechEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Polynomtech.PolynomTech.Dal.Abstract
{
    public interface IRepositoryBrand
    {
        IQueryable<Brand> GetList(Expression<Func<Brand, bool>> Linq);

        IQueryable<Brand> GetTable();
    }
}
