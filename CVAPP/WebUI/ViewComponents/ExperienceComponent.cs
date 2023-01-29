using AutoMapper;
using Business.Interfaces;
using Entities.Concrete;
using Entities.Concrete.DTOs.ExperienceDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class ExperienceComponent : ViewComponent
    {
        private readonly IGenericService<Experience> _genericExperienceService;
        private readonly IMapper _mapper;
        public ExperienceComponent(IGenericService<Experience> genericExperienceService, IMapper mapper)
        {
            _genericExperienceService = genericExperienceService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ExperienceListDto>>(_genericExperienceService.GetAll()));
        }
    }
}
