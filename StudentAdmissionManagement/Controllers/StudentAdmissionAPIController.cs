using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionAPIController : ControllerBase
    {
        // GET: api/<StudentAdmissionAPIController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            StudentAdmissionDetailsModel admissionobj1 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel admissionobj2 = new StudentAdmissionDetailsModel();
            admissionobj1.StudentID = 1;
            admissionobj1.StudentName = "Biplob";
            admissionobj1.StudentClass = "X";
            admissionobj1.DateofJoining = DateTime.Now;

            admissionobj2.StudentID = 2;
            admissionobj2.StudentName = "Nishi";
            admissionobj2.StudentClass = "IX";
            admissionobj2.DateofJoining = DateTime.Now;
            List<StudentAdmissionDetailsModel> listofobj = new List<StudentAdmissionDetailsModel>
            {
                admissionobj1,
                admissionobj2
            };
            return listofobj;
        }

        // GET api/<StudentAdmissionAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAdmissionAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAdmissionAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAdmissionAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
