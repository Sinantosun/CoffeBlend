using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.MenuDtos
{
    public class UpdateMenuDto
    {
        public int MenuId { get; set; }
        public string ShortTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
    }
}
