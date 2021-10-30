using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PMS.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PMS.Controllers
{
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private readonly DBContext context;

        public ItemController(DBContext context)
        {
            this.context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return context.Item.Where(a=>a.Status==1).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
