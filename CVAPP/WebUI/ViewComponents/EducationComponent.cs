using AutoMapper;
using Business.Interfaces;
using Entities.Concrete;
using Entities.Concrete.DTOs.EducationDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class EducationComponent : ViewComponent
    {
        private readonly IGenericService<Education> _genericEducationService;
        private readonly IMapper _mapper;
        public EducationComponent(IGenericService<Education> genericEducationService, IMapper mapper)
        {
            _genericEducationService = genericEducationService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<EducationListDto>>(_genericEducationService.GetAll()));
        }
    }
}
