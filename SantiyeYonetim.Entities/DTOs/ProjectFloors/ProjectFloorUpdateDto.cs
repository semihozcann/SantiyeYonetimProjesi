using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.DTOs.ProjectFloors
{
    public class ProjectFloorUpdateDto
    {
        public int Id { get; set; }
        public int ProjectBlockId { get; set; }
        public string Name { get; set; }
    }
}
