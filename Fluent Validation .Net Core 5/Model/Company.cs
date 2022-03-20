using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluent_Validation_.Net_Core_5.Model
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Sector { get; set; }
        public string Email { get; set; }
        public int EmployeeCount { get; set; }
    }
}
