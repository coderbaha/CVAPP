using AutoMapper;
using Business.Interfaces;
using Entities.Concrete;
using Entities.Concrete.DTOs.EducationDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EducationController : Controller
    {
        private readonly IEducationService _educationGenericService;
        private readonly IMapper _mapper;

        public EducationController(IEducationService educationGenericService, IMapper mapper)
        {
            _educationGenericService = educationGenericService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            TempData["active"] = "egitim";
            return View(_mapper.Map<List<EducationListDto>>(_educationGenericService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "egitim";
            var deletedEntity = _educationGenericService.GetById(id);
            _educationGenericService.Delete(deletedEntity);

            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            TempData["active"] = "egitim";
            return View(new EducationAddDto());
        }

        [HttpPost]
        public IActionResult Add(EducationAddDto model)
        {
            TempData["active"] = "egitim";
            if (ModelState.IsValid)
            {
                _educationGenericService.Insert(_mapper.Map<Education>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "egitim";
            return View(_mapper.Map<EducationUpdateDto>(_educationGenericService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(EducationUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                var updatedEducation = _educationGenericService.GetById(model.Id);
                updatedEducation.StartDate = model.StartDate;
                updatedEducation.SubTitle = model.SubTitle;
                updatedEducation.Title = model.Title;
                updatedEducation.Description = model.Description;
                updatedEducation.EndDate = model.EndDate;

                _educationGenericService.Update(updatedEducation);
                TempData["message"] = "Güncelleme işleminiz başarı ile gerçekleşti";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
