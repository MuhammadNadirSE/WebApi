using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIs.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }
        public string Get(int id, string name)
        {
            return "value";
        }
        // GET: api/Products/phone
        [HttpGet]
        //[Route("api/Products/myfunc")]
        public string Custom(string id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post()
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
