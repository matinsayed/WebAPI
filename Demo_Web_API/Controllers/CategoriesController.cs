using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo_Web_API.Controllers
{
    [Authorize]
    public class CategoriesController : ApiController
    {
        public IEnumerable<Models.Category> Get()
        {
            Models.Northwind3Entities context = new Models.Northwind3Entities();
            return context.Categories;
        }

        public Models.Category Get(int id)
        {
            Models.Northwind3Entities context = new Models.Northwind3Entities();
            return context.Categories.Where(a => a.CategoryID == id).FirstOrDefault();
        }
    }
}
