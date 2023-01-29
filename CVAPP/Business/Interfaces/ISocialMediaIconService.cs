using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ISocialMediaIconService : IGenericService<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
