using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangkoo.FullStack.MerchItem
{
    public class MerchItem
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
        public string? Description { get; set; }
    }
}
