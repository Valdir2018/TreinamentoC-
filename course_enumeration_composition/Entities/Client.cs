using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_enumeration_composition.Entities
{
    class Client
    {
        public string Name{ get; set; }
        public string Email{ get; set; }
        public DateTime BirthDate  { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        // Código do professor Nelio Alves
        public override string ToString()
        {
            return Name
                +  ",(" 
                +  BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
