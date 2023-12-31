﻿using SantiyeYonetim.Entities.Concrete;

namespace SantiyeYonetim.WebMVC.Models.Projects
{
    public class ProjectDetailViewModel : BaseViewModel
    {
        public Project Project { get; set; }


        //Yeni block eklemek için kullanılan propertyler
        public int ProjectId { get; set; }
        public string ProjectBlockName { get; set; }



        //Otomatik proje oluşturmak için kullanılan propertyler
        public int BlockNumber { get; set; }
        public int FloorNumber { get; set; }
    }
}
