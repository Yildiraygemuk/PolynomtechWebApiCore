using Polynomtech.PolynomtechEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Polynomtech.PolynomTech.Dal.Abstract
{
    public interface IRepositoryParfume
    {
        IQueryable<Parfume> GetList(Expression<Func<Parfume, bool>> Linq);

        IQueryable<Parfume> GetTable();
        void Add(Parfume parfume);

    }
}
