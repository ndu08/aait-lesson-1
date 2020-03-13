using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFamily.Models
{
     public class Person
     {

        public int PersonId { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

    }
}
