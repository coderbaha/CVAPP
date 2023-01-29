﻿using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DTOs.SocialMediaIconDtos
{
    public class SocialMediaIconAddDto : IDto
    {
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
