using SantiyeYonetim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.Concrete
{
    public class Project : BaseEntitiy
    {
        public int CompanyId { get; set; }
        public int ProjectTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }



        public Company Company { get; set; }
        public ProjectType ProjectType { get; set; }



    }
}
