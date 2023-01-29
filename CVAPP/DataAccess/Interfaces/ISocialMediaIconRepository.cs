using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface ISocialMediaIconRepository : IGenericRepository<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
