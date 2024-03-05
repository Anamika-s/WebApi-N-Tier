//using Business_Access_Layer;
////using Data_Access_Layer.Entities;
//using Data_Access_Layer.Repository.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApi_N_Tier.Controllers
//{
//    //[Route("api/v{v:apiVersion}/[controller]")]
//    [Route("api/[controller]")]
//    [ApiController]
//    [ApiVersion("1.0")]
//    [ApiVersion("2.0")]
//    public class StudentAsyncController : ControllerBase
//    {
//        private StudentAsyncBal _bal;
//        public StudentAsyncController()
//        {
//            _bal = new StudentAsyncBal();
//        }

//        [HttpGet, MapToApiVersion("1.0")]

//        public async Task<List<Student>> Get()
//        {
//            return await _bal.GetStudents();
//        }


//        [HttpGet, MapToApiVersion("2.0")]

//        public IActionResult GetStudents()
//        {
//            List<string> list = new List<string>()
//            { "aa", "bb", "cc"};
            
             

//            return Ok(list);
//        }
//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetById(int id)
//        {
//            return Ok(_bal.GetStudentById(id));
//        }

//        [HttpPost]
//        public IActionResult Add(Student student)
//        {
//            _bal.AddStudent(student);
//            return Created("rec has been added", student);
//        }

//    }
//}
