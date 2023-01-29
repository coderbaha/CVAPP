using AutoMapper;
using Entities.Concrete;
using Entities.Concrete.DTOs.AppUserDtos;
using Entities.Concrete.DTOs.CertificationDtos;
using Entities.Concrete.DTOs.EducationDtos;
using Entities.Concrete.DTOs.ExperienceDtos;
using Entities.Concrete.DTOs.InterestDtos;
using Entities.Concrete.DTOs.SkillDtos;
using Entities.Concrete.DTOs.SocialMediaIconDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, AppUserListDto>().ReverseMap();
            CreateMap<Certification, CertificationListDto>().ReverseMap();
            CreateMap<CertificationAddDto, Certification>().ReverseMap();
            CreateMap<CertificationUpdateDto, Certification>().ReverseMap();

            CreateMap<Education, EducationListDto>().ReverseMap();
            CreateMap<EducationAddDto, Education>().ReverseMap();
            CreateMap<Education, EducationUpdateDto>().ReverseMap();

            CreateMap<Experience, ExperienceListDto>().ReverseMap();
            CreateMap<Experience, ExperienceAddDto>().ReverseMap();
            CreateMap<Experience, ExperienceUpdateDto>().ReverseMap();

            CreateMap<Interest, InterestListDto>().ReverseMap();
            CreateMap<Interest, InterestAddDto>().ReverseMap();
            CreateMap<Interest, InterestUpdateDto>().ReverseMap();

            CreateMap<Skill, SkillListDto>().ReverseMap();
            CreateMap<Skill, SkillAddDto>().ReverseMap();
            CreateMap<Skill, SkillUpdateDto>().ReverseMap();

            CreateMap<SocialMediaIcon, SocialMediaIconListDto>().ReverseMap();
            CreateMap<SocialMediaIcon, SocialMediaIconAddDto>().ReverseMap();
            CreateMap<SocialMediaIcon, SocialMediaIconUpdateDto>().ReverseMap();
        }
    }
}
