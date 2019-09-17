using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace myweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class aController : ControllerBase
    {
        [HttpGet]
        public string Get(string A,string B)
        {
            return "zzjBBBByyuu," + A + "," + B;
        }
    }
}