using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFamily.Models
{
    public class Adult : Person
    {
        public string LicenseNumber { get; set; }
        public string Job { get; set; }
    }
}
