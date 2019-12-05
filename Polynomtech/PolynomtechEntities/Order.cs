using System;

namespace Polynomtech.PolynomtechEntities
{
    public class Order 
    {
        public int OrderId { get; set; }
        public int UserDetailId { get; set; }
        public string ShipAdress { get; set; }
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public UserDetail UserDetail { get; set; }
    }
}