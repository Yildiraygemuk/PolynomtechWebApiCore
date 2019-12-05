
namespace Polynomtech.PolynomtechEntities
{
    public class Parfume 
    {
        public int ParfumeID { get; set; }
        public string ParfumeName { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public string PhotoPath { get; set; }
        public Brand Brand { get; set; }
    }
}