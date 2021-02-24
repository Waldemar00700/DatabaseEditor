using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEditor
{
    class Client
    {
        public int ClientId { get; private set; }
        public string Name { get; private set; }
        public string Country { get; private set; }
        public string City { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        public Client(int id, string name, string country, string city, string address, string  phone, string email)
        {
            ClientId = id;
            Name = name;
            Country = country;
            City = city;
            Address = address;
            Phone = phone;
            Email = email;
        }

    }
}
