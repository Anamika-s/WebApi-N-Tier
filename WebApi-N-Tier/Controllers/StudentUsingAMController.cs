//using Business_Access_Layer;
////using Data_Access_Layer.Entities;
////using Data_Access_Layer.Repository.Entities;
//using Business_Access_Layer.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApi_N_Tier.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class StudentUsingAMController : ControllerBase
//    {
//        private StudentBal1 _bal;
//        public StudentUsingAMController()
//        {
//            _bal = new StudentBal1();
//        }

//        [HttpGet]
//        public IActionResult Get()
//        {
//            return Ok(_bal.GetStudents().ToList());
//        }
//        [HttpGet("{id}")]
//        public IActionResult GetById(int id)
//        {
//            return Ok(_bal.GetStudentById(id));
//        }

//        [HttpPost]
//        public IActionResult Add(StudentModel student)
//        {
//            _bal.AddStudent(student);
//            return Created("rec has been added", student);
//        }

//    }
//}
