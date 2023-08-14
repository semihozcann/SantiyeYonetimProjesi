using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectBlocks;
using SantiyeYonetim.Entities.DTOs.ProjectFloors;
using SantiyeYonetim.Entities.DTOs.ProjectProductions;
using SantiyeYonetim.Entities.DTOs.ProjectProductionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class AutoCreaterManager : IAutoCreaterService
    {

        private readonly IProjectBlockService _projectBlockService;
        private readonly IProjectFloorService _projectFloorService;
        private readonly IProjectProductionService _projectProductionService;
        private readonly IProjectProductionTypeService _projectProductionTypeService;

        public AutoCreaterManager(IProjectBlockService projectBlockService, IProjectFloorService projectFloorService, IProjectProductionService projectProductionService, IProjectProductionTypeService projectProductionTypeService)
        {
            _projectBlockService = projectBlockService;
            _projectFloorService = projectFloorService;
            _projectProductionService = projectProductionService;
            _projectProductionTypeService = projectProductionTypeService;
        }

        public IResult AddAsync(int projectId, int blockNumber, int floorNumber)
        {
            for (int i = 1; i <= blockNumber; i++)
            {
                _projectBlockService.AddAsync(new ProjectBlockAddDto
                {
                    ProjectId = projectId,
                    Name = i + "Block"
                });
                for (int j = 1; j <= floorNumber; j++)
                {
                    int lastBlockId = _projectBlockService.LastId();
                    _projectFloorService.AddAsync(new ProjectFloorAddDto
                    {
                        ProjectBlockId = lastBlockId,
                        Name = j + ". Kat"
                    });

                    #region Hafriyat Oluşturucu
                    int lastFloorId = _projectFloorService.LastId();
                    _projectProductionTypeService.AddAsync(new ProjectProductionTypeAddDto
                    {
                        ProjectFloorId = lastFloorId,
                        ProductionTypeId = 1
                    });
                    int lastProjectProductionTypeId = _projectProductionTypeService.LastId();
                    for (int k = 1; k < 3; k++)
                    {
                        _projectProductionService.AddAsync(new ProjectProductionAddDto
                        {
                            ProjectProductionTypeId = lastProjectProductionTypeId,
                            ProductionId = k
                        });
                    }
                    #endregion

                    #region Baka İşler Oluşturucu
                    _projectProductionTypeService.AddAsync(new ProjectProductionTypeAddDto
                    {
                        ProjectFloorId = lastFloorId,
                        ProductionTypeId = 2
                    });
                    int lastProjectProductionTypeId2 = _projectProductionTypeService.LastId();
                    for (int l = 3; l < 13; l++)
                    {
                        _projectProductionService.AddAsync(new ProjectProductionAddDto
                        {
                            ProjectProductionTypeId = lastProjectProductionTypeId2,
                            ProductionId = l,
                        });
                    }
                    #endregion

                    #region İnce İşler Oluşturucu
                    _projectProductionTypeService.AddAsync(new ProjectProductionTypeAddDto
                    {
                        ProjectFloorId = lastFloorId,
                        ProductionTypeId = 3
                    });
                    int lastProjectProductionTypeId3 = _projectProductionTypeService.LastId();
                    for (int m = 13; m < 53; m++)
                    {
                        _projectProductionService.AddAsync(new ProjectProductionAddDto
                        {
                            ProjectProductionTypeId = lastProjectProductionTypeId3,
                            ProductionId = m,
                        });
                    }
                    #endregion

                    #region Elektrik İşleri Oluşturucu
                    _projectProductionTypeService.AddAsync(new ProjectProductionTypeAddDto
                    {
                        ProjectFloorId = lastFloorId,
                        ProductionTypeId = 4
                    });
                    int lastProjectProductionTypeId4 = _projectProductionTypeService.LastId();
                    for (int n = 53; n < 57; n++)
                    {
                        _projectProductionService.AddAsync(new ProjectProductionAddDto
                        {
                            ProjectProductionTypeId = lastProjectProductionTypeId4,
                            ProductionId = n,
                        });
                    }
                    #endregion

                    #region Makine İşleri Oluşturucu
                    _projectProductionTypeService.AddAsync(new ProjectProductionTypeAddDto
                    {
                        ProjectFloorId = lastFloorId,
                        ProductionTypeId = 5
                    });
                    int lastProjectProductionTypeId5 = _projectProductionTypeService.LastId();
                    for (int o = 57; o < 67; o++)
                    {
                        _projectProductionService.AddAsync(new ProjectProductionAddDto
                        {
                            ProjectProductionTypeId = lastProjectProductionTypeId5,
                            ProductionId = o,
                        });
                    }
                    #endregion

                }
            }
            return new SuccessResult("Eklendi");
        }
    }
}
