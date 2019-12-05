using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Polynomtech.PolynomTech.Bll.Abstract;
using Polynomtech.PolynomTech.Dal.Abstract;
using Polynomtech.PolynomtechEntities;
using System.Linq;

namespace Polynomtech.Controllers
{
    [ODataRoutePrefix("Parfumes")]
    public class ParfumesController : ODataController
    {

        private readonly IParfumeBusiness ParfumeBusiness;
        public ParfumesController(IParfumeBusiness ParfumeBusiness)
        {
            this.ParfumeBusiness = ParfumeBusiness;
        }

        [ODataRoute]
        [EnableQuery(PageSize = 20, AllowedQueryOptions = AllowedQueryOptions.All)]
        [HttpGet]
        public IQueryable Get()
        {
            return ParfumeBusiness.MainPageParfumeTable();
        }


    }
}