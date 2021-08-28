using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testTrain.Data;
using testTrain.Model;
using System.Text.Encodings.Web;
using System.Net.Http.Json;


namespace testTrain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class delieveryMenController : ControllerBase
    {
        

        private readonly DataContext _context;

        public delieveryMenController(DataContext context)
        {
            _context = context;
        }

        // GET: api/delieveryMen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<delieveryMan>>> GetdelieveryDrivers()
        {
            return await _context.delieveryDrivers.ToListAsync();
        }

        // GET: api/delieveryMen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<delieveryMan>> GetdelieveryMan(int id)
        {
            var delieveryMan = await _context.delieveryDrivers.FindAsync(id);

            if (delieveryMan == null)
            {
                return NotFound();
            }

            return delieveryMan;
        }

        // PUT: api/delieveryMen/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutdelieveryMan(int id, delieveryMan delieveryMan)
        {
            if (id != delieveryMan.Id)
            {
                return BadRequest();
            }

            _context.Entry(delieveryMan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!delieveryManExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/delieveryMen
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<delieveryMan>> PostdelieveryMan(delieveryMan delieveryMan)
        {
            _context.delieveryDrivers.Add(delieveryMan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetdelieveryMan", new { id = delieveryMan.Id }, delieveryMan);
        }
        

        // DELETE: api/delieveryMen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletedelieveryMan(int id)
        {
            var delieveryMan = await _context.delieveryDrivers.FindAsync(id);
            if (delieveryMan == null)
            {
                return NotFound();
            }

            _context.delieveryDrivers.Remove(delieveryMan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool delieveryManExists(int id)
        {
            return _context.delieveryDrivers.Any(e => e.Id == id);
        }

        //public JsonResult TestFunction(string nationalID, string phoneNumber, string fullName, string password, string carType, string plateNumbers, string plateLetters, string pickUpLocation, float capacity)
        //{
        //    return Json(new
        //    {
        //        result = "OK"
        //    });
        //}

        //private JsonResult Json(object p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
