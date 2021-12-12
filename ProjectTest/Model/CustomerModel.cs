using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTest.Model
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public int IdentificationType { get; set; }

        public int IdentificationNumber { get; set; }

        public string CompanyName { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string FirstLastName { get; set; }

        public string SecondLastName { get; set; }

        public string Email { get; set; }

        public bool esSendMessageCell { get; set; }

        public bool esSendMessageEmail { get; set; }
    }
}
