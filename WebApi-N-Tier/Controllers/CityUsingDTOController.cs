//using Business_Access_Layer;
////using Data_Access_Layer.Entities;
//using Data_Access_Layer.Repository.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using WebApi_N_Tier.DTOs;

//namespace WebApi_N_Tier.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CityUsingDTOController : ControllerBase
//    {
//        private CityBal _bal;
//        public CityUsingDTOController() {
//            _bal = new CityBal();
//        }


//        [HttpGet]
//        public IActionResult Get()
//        {List<City> cities = _bal.GetCitys();
//            List<CityDTO> list = new List<CityDTO>();
//            foreach (City c in cities)
//            {
//                CityDTO dto = new CityDTO()
//                {
//                    Id = c.Id,
//                    Name = c.Name
//                };
//                list.Add(dto);
//            }
//            return Ok(list);
//        }
//        [HttpGet("{id}")]
//        public IActionResult GetById(int id)
//        {

//            return Ok(_bal.GetCityById(id));
//        }

//        [HttpPost]
//        public IActionResult Add(CityDTO cityDto)
//        {
//            var city = new City
//            {
//                Name = cityDto.Name,
//                UpdatedBy = 1,
//                UpdatedOn = DateTime.Now
//            };
//            _bal.AddCity(city);
//            return Created("rec has been added", city);
//        }

//    }
//}
