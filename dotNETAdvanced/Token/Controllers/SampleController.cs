using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using TokenBasedAuthentication.Model;

// For more Tinformation on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TokenBasedAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SampleController : ControllerBase
    {
        private readonly IConfiguration _config;

        public SampleController(IConfiguration config)
        {
            this._config = config;
        }

        // GET: api/<SampleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SampleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SampleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("authenticate")]
        //public string Authenticate(string username, string password)
           public string Authenticate([FromBody]User user )
        {
            //validate user from database DAL
            if (user.username == "admin" && user.password == "abc")
            {
                //generate JSON Web token with valid details and return 
                var key = Encoding.UTF8.GetBytes(_config["JWT:Key"]);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    //issuer
                    Issuer = _config["JWT:Issuer"],
                    //audience
                    Audience = _config["JWT:Audience"],
                    //expiry
                    Expires = DateTime.UtcNow.AddMinutes(10),
                    //signing key
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),

                };

                //create the token with above descriptions
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);

                //write the token 
                return tokenHandler.WriteToken(token);
            }
            else
            {
                return "invalid username or password";
            }
        }
    }
}
