using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Entities.DTOs.Projects;
using SantiyeYonetim.WebMVC.Helpers.Abstract;
using SantiyeYonetim.WebMVC.Models.Projects;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SantiyeYonetim.WebMVC.Areas.ProjectAdmins.Controllers
{
    public class ProjectsController : BaseController
    {

        private readonly IProjectService _projectService;
        private readonly ICompanyService _companyService;
        private readonly IProjectTypeService _projectTypeService;
        private readonly IProjectBlockService _projectBlockService;


        public ProjectsController(IUserAccessor userAccessor, IProjectService projectService, ICompanyService companyService, IProjectTypeService projectTypeService, IProjectBlockService projectBlockService) : base(userAccessor)
        {
            _projectService = projectService;
            _companyService = companyService;
            _projectTypeService = projectTypeService;
            _projectBlockService = projectBlockService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var model = new ProjectAddViewModel();
            var company = _companyService.GetAllCompany();
            var projectType = _projectTypeService.GetAllProjectType();

            List<SelectListItem> companies = (from x in company.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CompanyName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            model.CompaniesForDr = companies;

            List<SelectListItem> projectTypes = (from x in projectType.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();
            model.ProjectTypesForDr = projectTypes;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProjectAddViewModel projectAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var project = new ProjectAddDto()
                {
                    CompanyId = projectAddViewModel.CompanyId,
                    ProjectTypeId = projectAddViewModel.ProjectTypeId,
                    Name = projectAddViewModel.Name,
                    Description = projectAddViewModel.Description
                };

                var result = await _projectService.AddAsync(project);
                projectAddViewModel.Message = result.Message;
                if (result.Success)
                {
                    return RedirectToAction("GetAllProjects");
                }
                ViewBag.ProjectResultMessage = result.Message;
                return View(projectAddViewModel);
            }
            return View(projectAddViewModel);
        } 

        public async Task<IActionResult> GetAllProjects()
        {
            var company = await _companyService.GetAllAsync();
            var projectType = await _projectTypeService.GetAllAsync();

            var result = await _projectService.GetAllAsync();

            var project = new ProjectListViewModel
            {
                Projects = result.Data,
                Message = result.Message,
            };
            if (result.Success)
            {
                return View(project);
            }
            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            var result = await _projectService.GetByIdAsync(Id);

            var project = new ProjectUpdateViewModel
            {
                Id = result.Data.Id,
                Name = result.Data.Name,
                Description = result.Data.Description,
            };

            var company = _companyService.GetAllCompany();
            var projectType = _projectTypeService.GetAllProjectType();

            List<SelectListItem> companies = (from x in company.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.CompanyName,
                                                  Value = x.Id.ToString()
                                              }).ToList();
            project.CompaniesForDr = companies;

            List<SelectListItem> projectTypes = (from x in projectType.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.Id.ToString()
                                                 }).ToList();
            project.ProjectTypesForDr = projectTypes;

            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProjectUpdateViewModel projectUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var project = new ProjectUpdateDto
                {
                    Id = projectUpdateViewModel.Id,
                    CompanyId = projectUpdateViewModel.CompanyId,
                    ProjectTypeId = projectUpdateViewModel.ProjectTypeId,
                    Name = projectUpdateViewModel.Name,
                    Description = projectUpdateViewModel.Description,
                };

                var result = await _projectService.UpdateAsync(project);
                projectUpdateViewModel.Message = result.Message;

                if (result.Success)
                {
                    return RedirectToAction("GetAllProjects");
                }
                return View();
            }
            return View();
        }


        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _projectService.DeleteAsync(Id);
            ViewBag.ProjectResultMessage = result.Message;
            if (result.Success)
            {
                return RedirectToAction("GetAllProjects");
            }
            return View(result);
        }


        public async Task<IActionResult> ProjectDetails(int Id)
        {
            var projectBlock = await _projectBlockService.GetAllAsync();
            var result = await _projectService.GetByIdAsync(Id);
            ViewBag.ProjectResultMessage = result.Message;
            ViewBag.projectId = Id;

            var project = new ProjectDetailViewModel
            {
                Project = result.Data,
                Message = result.Message,
            };

            if (result.Success)
            {
                return View(project);
            }
            return View();
        }
    }
}
