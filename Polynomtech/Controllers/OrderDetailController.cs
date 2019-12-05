using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polynomtech.PolynomTech.Bll.Abstract;
using Polynomtech.PolynomtechEntities;

namespace Polynomtech.Controllers
{
    public class OrderDetailController : Controller

    {
        private readonly IOrderDetailBusiness OrderDetailBusiness;
        public OrderDetailController(IOrderDetailBusiness OrderDetailBusiness)
        {
            this.OrderDetailBusiness = OrderDetailBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailBusiness.OrderDetailAdd(orderDetail);
            return View();
        }
    }
}