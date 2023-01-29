using AutoMapper;
using Business.Interfaces;
using Entities.Concrete;
using Entities.Concrete.DTOs.SkillDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class SkillComponent : ViewComponent
    {
        private readonly IGenericService<Skill> _genericSkillService;
        private readonly IMapper _mapper;

        public SkillComponent(IGenericService<Skill> genericSkillService, IMapper mapper)
        {
            _genericSkillService = genericSkillService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDto>>(_genericSkillService.GetAll()));
        }
    }
}
