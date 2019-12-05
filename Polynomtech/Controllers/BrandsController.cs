using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Polynomtech.PolynomTech.Bll.Abstract;

namespace Polynomtech.Controllers
{
    [ODataRoutePrefix("Parfumes")]
    public class BrandsController : ODataController
    {
        private readonly IBrandBusiness BrandBusiness;
        public BrandsController(IBrandBusiness BrandBusiness)
        {
            this.BrandBusiness = BrandBusiness;
        }

        [ODataRoute]
        [EnableQuery(PageSize = 20, AllowedQueryOptions = AllowedQueryOptions.All)]
        [HttpGet]
        public IQueryable Get()
        {
            return BrandBusiness.MainPageParfumeTable();
        }

    }
}