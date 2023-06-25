using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.DTOs.Producions
{
    public class ProductionAddDto
    {
        public int ProductionTypeId { get; set; }
        public int ProductionRowNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
