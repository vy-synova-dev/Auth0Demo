using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIApplication.Controllers
{
    [Route("api")]
    public class PingController : Controller
    {
        [HttpGet]
        [Route("ping")]
        public object Ping()
        {
            return new { message = "Ponggggggg. This is a public call without any authentication." };
        }

        [Authorize]
        [HttpGet("claims")]
        public object Claims()
        {
            return User.Claims.Select(c =>
            new
            {
                Type = c.Type,
                Value = c.Value
            });
        }

        [Authorize]
        [HttpGet]
        [Route("ping/secure")]
        public object PingSecured()
        {
            return new { message = "Ponggggggg. This is a private call. You must be authenticated." };
        }

        [Authorize("read:messages")]
        [HttpGet]
        [Route("ping/secure/scope")]
        public object PingSecuredWithScope()
        {
            return new { message = "Ponggggggg. This is a private call. You must be authenticated and have scope \"read: messages\"." };
        }
    }
}
