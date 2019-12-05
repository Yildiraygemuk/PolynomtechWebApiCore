using System.Collections.Generic;

namespace Polynomtech.PolynomtechEntities
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ParfumeId { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public List<Parfume> Parfumes { get; set; }
        public List<Order> Orders { get; set; }
    }
}