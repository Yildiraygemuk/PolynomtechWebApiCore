using Polynomtech.PolynomTech.Bll.Abstract;
using Polynomtech.PolynomTech.Dal.Abstract;
using Polynomtech.PolynomtechEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polynomtech.PolynomTech.Bll.Concrate
{
    public class ParfumeBusiness : IParfumeBusiness
    {
        private readonly IRepositoryParfume repoParfume;
        public ParfumeBusiness(IRepositoryParfume repoParfume)
        {
            this.repoParfume = repoParfume;
        }

        

        public IEnumerable<Parfume> MainPageParfumeList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Parfume> MainPageParfumeTable()
        {
            var getTblParfume = repoParfume.GetTable();
            return getTblParfume;
        }

        public void ParfumeAdd(Parfume parfume)
        {
            repoParfume.Add(parfume);

        }
    }
}
