﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.AboutDtos
{
    public class UpdateAboutDto
    {
        public int AboutId { get; set; }
        public string ShortTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
