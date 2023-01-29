using AutoMapper;
using Business.Interfaces;
using Entities.Concrete;
using Entities.Concrete.DTOs.InterestDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class InterestComponent : ViewComponent
    {
        private readonly IGenericService<Interest> _genericInterestService;
        private readonly IMapper _mapper;
        public InterestComponent(IGenericService<Interest> genericInterestService, IMapper mapper)
        {
            _genericInterestService = genericInterestService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<InterestListDto>>(_genericInterestService.GetAll()));
        }
    }
}
