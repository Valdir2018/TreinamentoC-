using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_enumeration_composition.Entities
{
    class Client
    {
        public string name{ get; set; }
        public string email{ get; set; }
        public DateTime birthDate  { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }
    }
}
