using Microsoft.AspNetCore.Mvc;
using SMS.Models.TimeTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetableController : ControllerBase
    {
        private readonly MysqlDataContext _dbcontext;
        public TimetableController(MysqlDataContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        // GET: api/<TimetableController>
        [HttpGet]
        public void Get([FromBody] ClassTimeTableReq classTimeTableReq)
        {
           //return _dbcontext.ClassTimeTable.Where(X => X.Class == classTimeTableReq.Class
              //&& X.Section == classTimeTableReq.Section && X.Year == classTimeTableReq.Year).ToList();
        }

        // GET api/<TimetableController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TimetableController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TimetableController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TimetableController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
