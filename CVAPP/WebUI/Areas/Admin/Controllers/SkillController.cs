using AutoMapper;
using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Concrete;
using Entities.Concrete.DTOs.SkillDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        private readonly ISkillRepository _genericSkillService;
        private readonly IMapper _mapper;

        public SkillController(ISkillRepository genericSkillService, IMapper mapper)
        {
            _genericSkillService = genericSkillService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "yetenek";
            return View(_mapper.Map<List<SkillListDto>>(_genericSkillService.GetAll()));
        }

        public IActionResult Add()
        {
            TempData["active"] = "yetenek";
            return View(new SkillAddDto());
        }

        [HttpPost]
        public IActionResult Add(SkillAddDto model)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                _genericSkillService.Insert(_mapper.Map<Skill>(model));
                TempData["message"] = "Ekleme işleminiz başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "yetenek";
            return View(_mapper.Map<SkillUpdateDto>(_genericSkillService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(SkillUpdateDto model)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                var updatedSkill = _genericSkillService.GetById(model.Id);

                updatedSkill.Description = model.Description;
                _genericSkillService.Update(updatedSkill);

                TempData["message"] = "Güncelleme işleminiz başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "yetenek";
            var deletedSkill = _genericSkillService.GetById(id);
            _genericSkillService.Delete(deletedSkill);
            TempData["message"] = "Silme işleminiz başarılı";
            return RedirectToAction("Index");
        }
    }
}
