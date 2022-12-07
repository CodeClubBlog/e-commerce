using Project.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.Users
{
    public class Address : Auditable
    {
        public string Country { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Street { get; set; } = String.Empty;
        public string HomeNumber { get; set; } = String.Empty;
    }
}
