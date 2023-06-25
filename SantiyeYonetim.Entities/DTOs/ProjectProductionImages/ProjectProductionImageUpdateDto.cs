using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.DTOs.ProjectProductionImages
{
    public class ProjectProductionImageUpdateDto
    {
        public int Id { get; set; }
        public int ProjectProductionId { get; set; }
        public string ImageUrl { get; set; }
    }
}
