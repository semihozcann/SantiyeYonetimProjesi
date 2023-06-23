using SantiyeYonetim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.Concrete
{
    public class Company : BaseEntitiy
    {
        public string CompanyName { get; set; }
        public string Description { get; set; }


        public List<Project> Projects { get; set; }

    }
}
