using Microsoft.Extensions.Configuration;
using ProjectTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTest.Data
{
    class Test : CustomerDbContext
    {
        readonly IConfiguration Configuration;

        public Test(IConfiguration configuration) : base(configuration)
        {
            Configuration = configuration;
        }

        public List<CustomerModel> get() {

            using (CustomerDbContext context = new CustomerDbContext(Configuration))
            {

                List<CustomerModel> customers = context.Customer.ToList();

                return customers;

            }

        }

        public void create(CustomerModel customer)
        {
            using (CustomerDbContext context = new CustomerDbContext(Configuration))
            {

                context.Customer.Add(customer);

                context.SaveChanges();

            }
        }
    }
}
