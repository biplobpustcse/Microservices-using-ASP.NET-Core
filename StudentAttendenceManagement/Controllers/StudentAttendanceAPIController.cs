using Microsoft.AspNetCore.Mvc;
using StudentAttendenceManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendenceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceAPIController : ControllerBase
    {
        // GET: api/<StudentAttendanceAPIController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel attendanceObj1 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel attendanceObj2 = new StudentAttendanceDetailsModel();
            attendanceObj1.StudentID = 1;
            attendanceObj1.StudentName = "Biplob MS2";
            attendanceObj1.AttendencePercentage = 83.02;

            attendanceObj2.StudentID = 2;
            attendanceObj2.StudentName = "Nishi MS2";
            attendanceObj2.AttendencePercentage = 71.02;
            List<StudentAttendanceDetailsModel> listObj = new List<StudentAttendanceDetailsModel>
            {
                attendanceObj1,
                attendanceObj2
            };
            return listObj;
        }

        // GET api/<StudentAttendanceAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAttendanceAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAttendanceAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAttendanceAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
