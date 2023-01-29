using Business.Concrete;
using Business.Interfaces;
using Business.ValidationRules;
using DataAccess.Concrete.Dapper;
using DataAccess.Interfaces;
using Entities.Concrete.DTOs.AppUserDtos;
using Entities.Concrete.DTOs.CertificationDtos;
using Entities.Concrete.DTOs.EducationDtos;
using Entities.Concrete.DTOs.ExperienceDtos;
using Entities.Concrete.DTOs.InterestDtos;
using Entities.Concrete.DTOs.SkillDtos;
using Entities.Concrete.DTOs.SocialMediaIconDtos;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Business.IOC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddCustomDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con => new OracleConnection(configuration.GetConnectionString("oracle")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped<IAppUserRepository, DpAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<ISocialMediaIconService, SocialMediaIconManager>();
            services.AddScoped<ISocialMediaIconRepository, DpSocialMediaIconRepository>();
            services.AddScoped<ICertificationService, CertificationManager>();
            services.AddScoped<ICertificationRepository, DpCertificationRepository>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IEducationRepository, DpEducationRepository>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IExperienceRepository, DpExperienceRepository>();
            services.AddScoped<IInterestService, InterestManager>();
            services.AddScoped<IInterestRepository, DpInterestRepository>();
            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<ISkillRepository, DpSkillRepository>();
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserPasswordDto>, AppUserPasswordDtoValidator>();
            services.AddTransient<IValidator<CertificationAddDto>, CertificationAddDtoValidator>();
            services.AddTransient<IValidator<CertificationUpdateDto>, CertificationUpdateDtoValidator>();
            services.AddTransient<IValidator<EducationAddDto>, EducationAddDtoValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateDtoValidator>();
            services.AddTransient<IValidator<ExperienceAddDto>, ExperienceAddDtoValidator>();
            services.AddTransient<IValidator<ExperienceUpdateDto>, ExperienceUpdateDtoValidator>();
            services.AddTransient<IValidator<InterestAddDto>, InterestAddDtoValidator>();
            services.AddTransient<IValidator<InterestUpdateDto>, InterestUpdateDtoValidator>();
            services.AddTransient<IValidator<SkillAddDto>, SkillAddDtoValidator>();
            services.AddTransient<IValidator<SkillUpdateDto>, SkillUpdateDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconAddDto>, SocialMediaIconAddDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconUpdateDto>, SocialMediaIconUpdateDtoValidator>();

        }
    }
}
