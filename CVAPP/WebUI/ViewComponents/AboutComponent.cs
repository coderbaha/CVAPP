using AutoMapper;
using Business.Interfaces;
using Entities.Concrete.DTOs.AppUserDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class AboutComponent : ViewComponent
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;
        public AboutComponent(IAppUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<AppUserListDto>(_appUserService.GetById(1)));
        }
    }
}
