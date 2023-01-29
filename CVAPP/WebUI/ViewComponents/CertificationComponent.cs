using AutoMapper;
using Business.Interfaces;
using Entities.Concrete;
using Entities.Concrete.DTOs.CertificationDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class CertificationComponent:ViewComponent
    {
        private readonly IGenericService<Certification> _genericCertificationService;
        private readonly IMapper _mapper;
        public CertificationComponent(IGenericService<Certification> genericCertificationService, IMapper mapper)
        {
            _genericCertificationService = genericCertificationService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<CertificationListDto>>(_genericCertificationService.GetAll()));
        }
    }
}
