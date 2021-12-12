using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectTest.Business;
using ProjectTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : Controller
    {
        readonly IConfiguration Configuration;

        public CustomerController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        [Route("get")]
        public List<CustomerModel> get()
        {
            TestServer testServer = new TestServer(Configuration);

            List<CustomerModel> customers = testServer.get();

            return customers;
        }
    }
}
