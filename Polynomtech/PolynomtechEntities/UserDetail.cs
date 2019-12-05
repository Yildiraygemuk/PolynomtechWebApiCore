using System.Collections.Generic;

namespace Polynomtech.PolynomtechEntities
{
    public class UserDetail 
    {
        public int UserDetailId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}