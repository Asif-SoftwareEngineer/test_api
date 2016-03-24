using System.Web.Http;
using test_jade_app.Models;
using System.Web.Http.Cors;

namespace test_jade_app.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        private User _user;

        public UserController() { }

        public UserController(User param_user)
        {
            _user = param_user;
        }

        [HttpPost]
        public IHttpActionResult SaveUser([FromBody] User u)
        {
            if ((u == null)) 
            {
                return BadRequest();
            }
            else
            {
                _user = u;

                if (_user.FirstName == string.Empty)
                {
                    return BadRequest("FirstName invalid");
                }
                else if (_user.LastName == string.Empty)
                {
                    return BadRequest("LastName invalid");
                }

                return Ok(_user);

            }
        }
    }
}
