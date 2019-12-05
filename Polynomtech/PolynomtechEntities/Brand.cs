using System.Collections.Generic;

namespace Polynomtech.PolynomtechEntities
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public List<Parfume> Parfumes { get; set; }
    }
}