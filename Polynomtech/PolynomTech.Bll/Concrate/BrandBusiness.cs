using Polynomtech.PolynomTech.Bll.Abstract;
using Polynomtech.PolynomTech.Dal.Abstract;
using Polynomtech.PolynomtechEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polynomtech.PolynomTech.Bll.Concrate
{
    public class BrandBusiness : IBrandBusiness
    {
        private readonly IRepositoryBrand repoBrand;
        public BrandBusiness(IRepositoryBrand repoBrand)
        {
            this.repoBrand = repoBrand;
        }

        public IEnumerable<Brand> MainPageParfumeList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Brand> MainPageParfumeTable()
        {
            var getTblBrand = repoBrand.GetTable();
            return getTblBrand;
        }
    }
}
