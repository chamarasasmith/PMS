using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMS.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PMS.Controllers
{
    [Route("api/[controller]")]
    public class RequisitionController : Controller
    {
        private readonly DBContext context;

        public RequisitionController(DBContext context)
        {
            this.context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<dynamic> Get()
        {
            try
            {
                var obj1 = context?.PurchaseRequisition?.Include(a => a.Item)?.Include(a => a.Item != null ? a.Item.Supplier : null)?.Include(b => b.Location)?.Where(a => a.Status == 1)?.Include(a=>a.CreatedBy)?.ToList()?.Select(a => new
                {
                    a.PurchaseRequisitionID,
                    a.ItemID,
                    ItemName = a.Item?.Name?.Trim() ?? "",
                    a.Quantity,
                    CreatedBy = a.CreatedBy?.Name?.Trim() ?? "",
                    MeasureType = a.Item?.MeasureType?.Trim() ?? "",
                    Supplier = a.Item?.Supplier?.Name?.Trim() ?? "",
                    Location = a.Location?.Name?.Trim() ?? "",
                    CreatedDate = a.CreatedDate.ToString("yyyy-MM-dd") ?? "",
                });
                return obj1;
            }
            catch (Exception)
            {
                return null;
            }
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
