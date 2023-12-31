﻿using Microsoft.AspNetCore.Mvc;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Entities.DTOs.ProjectBlocks;
using SantiyeYonetim.WebMVC.Helpers.Abstract;
using SantiyeYonetim.WebMVC.Models.ProjectBlocks;
using SantiyeYonetim.WebMVC.Models.Projects;
using System.Threading.Tasks;

namespace SantiyeYonetim.WebMVC.Areas.ProjectAdmins.Controllers
{
    public class ProjectBlocksController : BaseController
    {
        private readonly IProjectBlockService _projectBlockService;
        private readonly IProjectService _projectService;
        private readonly IProjectFloorService _projectFloorService;

        public ProjectBlocksController(IUserAccessor userAccessor, IProjectBlockService projectBlockService, IProjectService projectService, IProjectFloorService projectFloorService) : base(userAccessor)
        {
            _projectBlockService = projectBlockService;
            _projectService = projectService;
            _projectFloorService = projectFloorService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProjectDetailViewModel projectDetailViewModel)
        {
            if (ModelState.IsValid)
            {
                var projectBlock = new ProjectBlockAddDto
                {
                    ProjectId = projectDetailViewModel.ProjectId,
                    Name = projectDetailViewModel.ProjectBlockName,
                };

                var result = await _projectBlockService.AddAsync(projectBlock);
                projectDetailViewModel.Message = result.Message;
                if (result.Success)
                {
                    return RedirectToAction("GetAllProjectBlocks");
                }
                ViewBag.ProjectResultMessage = result.Message;
                return View(projectDetailViewModel);
            }
            return View(projectDetailViewModel);
        }


        public async Task<IActionResult> GetAllProjectBlocks()
        {
            var project = await _projectService.GetAllAsync();

            var result = await _projectBlockService.GetAllAsync();

            var projectBlocks = new ProjectBlockListViewModel
            {
                ProjectBlocks = result.Data,
                Message = result.Message
            };
            if (result.Success)
            {
                return View(projectBlocks);
            }
            return View();
        }

        public async Task<IActionResult> ProjectBlockDetails(int Id)
        {
            var projectFloor = await _projectFloorService.GetAllAsync();
            var result = await _projectBlockService.GetByIdAsync(Id);
            ViewBag.ProjectResultMessage = result.Message;
            ViewBag.projectId = Id;

            var projectBlock = new ProjectBlockDetailViewModel
            {
                ProjectBlock = result.Data,
                Message = result.Message,
            };

            if (result.Success)
            {
                return View(projectBlock);
            }
            return View();
        }
    }
}
