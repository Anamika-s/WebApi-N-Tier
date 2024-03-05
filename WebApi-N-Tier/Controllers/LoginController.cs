//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApi_N_Tier.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class LoginController : ControllerBase
//    {
//        [HttpPost]
//        public IActionResult Login(string username, string password)
//        {
//            IActionResult response = Unauthorized();
//            var user = Authenticate(User);
//           if(user!=null)
//            {

//           }


//        }

//        private string Authenticate(string username, string password)
//        {
//            if (username == "user1" && password = "password")
//            {
//                return "found";

//            }
//            else
//                return null;
//        }

//        private string GenerateJSONWebToken(string username , string password)
//        {
//            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
//            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms);

//            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
//              _config["Jwt:Issuer"],
//              null,
//              expires: DateTime.Now.AddMinutes(120),
//              signingCredentials: credentials);

//            return new JwtSecurityTokenHandler().WriteToken(token);
//        }


//    }
//}
