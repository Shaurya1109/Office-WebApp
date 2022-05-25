using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebApp.Models;
using EmployeeWebApp.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly officeContext _officecontext;
        public EmployeeController(officeContext context)
        {
            _officecontext = context;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_officecontext.Employee.ToList());
        }


        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {

            var result = _officecontext.Employee.First(obj => obj.Id == id);







            return Ok(result);

        }

        [HttpGet("Employee/{value}")]
        public IActionResult Get(string value)
        {



            var result = _officecontext.Employee.Where(obj => obj.EmployeeName.Contains(value));
            return Ok(result);



        }
        // GET: api/Employee


        // GET: api/Employee/5


        // POST: api/Employee


        [HttpPost]
        public void Post([FromBody] Class value)
        {
           Employee obj = new Employee();
            obj.EmployeeName = value.EmployeeName;
            obj.EmployeeGender = value.EmployeeGender;
            obj.EmployeeAge = value.EmployeeAge;
            obj.EmployeePhonenumber = value.EmployeePhonenumber;
            _officecontext.Employee.Add(obj);
            _officecontext.SaveChanges();




        }

        // PUT: api/Employee/5
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
