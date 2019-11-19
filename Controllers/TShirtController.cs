using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using ContosoPets.Api.Data;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TShirtController : ControllerBase
    {
        private readonly ContosoPetsContext _context;

        public TShirtController(ContosoPetsContext context)
        {
            _context = context;
        }
        // GET: api/TShirt
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TShirt/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TShirtOrder>> GetById(long id)
        {
            var product = await _context.TShirtOrders.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
        // POST: api/TShirt
        [HttpPost]
        public async Task<ActionResult<TShirtOrder>> Post([FromBody]TShirtOrder shirtOrder)
        { 
            
            _context.TShirtOrders.Add(shirtOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = shirtOrder.Id }, shirtOrder);
        }

        // PUT: api/TShirt/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
