using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("Authentication")]
    public class AuthenticationController: ControllerBase
    {
        private readonly IServiceManager _ServiceManager;
        public AuthenticationController(IServiceManager serviceManager)
        {
            _ServiceManager = serviceManager;
        }
       // [HttpPost("login")]
        //public async Task<IActionResult>LoginAsync()
        //{

        //}
    }
}
