using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StajyerBlog.Core.Data.DTO;

namespace StajyerBlog.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        public object onPost(AuthFilter entity)
        {
            if (entity.Email == "ismetandac@gmail.com")
            {
                var rnt = new AuthDTO();
                rnt.Id = 1;
                return Ok(rnt);
            }
            return NotFound();
        }
    }
}
