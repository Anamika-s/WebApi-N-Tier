//using Business_Access_Layer;
 
//using Data_Access_Layer.Repository.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApi_N_Tier.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CityController : ControllerBase
//    {
//        private CityBal _bal;
//        public CityController() {
//            _bal = new CityBal();
//        }


//        [HttpGet]
//        public IActionResult Get()
//        {
//            return Ok(_bal.GetCitys().ToList());
//        }
//        [HttpGet("{id}")]
//        public IActionResult GetById(int id)
//        {
//            return Ok(_bal.GetCityById(id));
//        }

//        [HttpPost]
//        public IActionResult Add(City city)
//        {
//            _bal.AddCity(city);
//            return Created("rec has been added", city);
//        }

//    }
//}
