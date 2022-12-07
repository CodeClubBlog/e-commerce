using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Common
{
    public abstract class Auditable
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
