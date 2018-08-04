using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    ///http://localhost:5000/api/Values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private DataContext _Context ;
        public ValuesController(DataContext context){
            this._Context = context  ;     
        }


        // GET api/values
        [HttpGet]
        public async Task<IActionResult>  GetValues()
        {
            //return new string[] { "value1", "value3" };
            var values = await _Context.Values.ToListAsync() ;
            return Ok(values) ;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            //throw new Exception ("bad news - it didnt work!");
            var values = await _Context.Values.FirstOrDefaultAsync(x => x.Id == id);
            // ToList() ;
            
            //return Ok("value was " + values.Name + " so deal with it!");
            return Ok(values);
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
