using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.DTOs.ProductionTypes
{
    public class ProductionTypeUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char SmallName { get; set; }
    }
}
