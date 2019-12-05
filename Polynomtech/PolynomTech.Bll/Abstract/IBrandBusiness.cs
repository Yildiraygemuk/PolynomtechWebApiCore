using Polynomtech.PolynomtechEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polynomtech.PolynomTech.Bll.Abstract
{
    public interface IBrandBusiness
    {
        IEnumerable<Brand> MainPageParfumeList();

        IQueryable<Brand> MainPageParfumeTable();
    }
}
