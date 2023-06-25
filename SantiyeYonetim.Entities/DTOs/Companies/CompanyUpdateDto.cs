using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.DTOs.Companies
{
    public class CompanyUpdateDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
    }
}
