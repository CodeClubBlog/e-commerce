using Project.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.Categories
{
    public class Category : Auditable
    {
        public string Name { get; set; } = String.Empty;

    }
}
