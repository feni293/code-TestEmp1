using Microsoft.Extensions.Configuration;
using ProjectTest.Data;
using ProjectTest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTest.Business
{
    public class TestServer
    {
        private readonly IConfiguration Configuration;

        public TestServer(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<CustomerModel> get()
        {
            Test test = new Test(Configuration);

            List<CustomerModel> customers = test.get();

            return customers;
        }

        public void create(CustomerModel customer)
        {
            Test test = new Test(Configuration);

            test.create(customer);
        }
    }
}
