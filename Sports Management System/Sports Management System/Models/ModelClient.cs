using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sports_Management_System.Models
{
    public class ModelClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}