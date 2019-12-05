using Polynomtech.PolynomTech.Bll.Abstract;
using Polynomtech.PolynomTech.Dal.Abstract;
using Polynomtech.PolynomtechEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polynomtech.PolynomTech.Bll.Concrate
{
    public class OrderDetailBusiness : IOrderDetailBusiness
    {
        private readonly IRepositoryOrderDetail repoOrderDetail;
        public OrderDetailBusiness(IRepositoryOrderDetail repoOrderDetail)
        {
            this.repoOrderDetail = repoOrderDetail;
        }


        public IEnumerable<OrderDetail> MainPageOrderDetailList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<OrderDetail> MainPageOrderDetailTable()
        {
            var getTblOrderDetail = repoOrderDetail.GetTable();
            return getTblOrderDetail;
        }

        public void OrderDetailAdd(OrderDetail orderDetail)
        {
            repoOrderDetail.Add(orderDetail);
        }
    }
}
