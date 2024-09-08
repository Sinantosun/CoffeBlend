using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.TableDtos
{
    public class UpdateTableDto
    {
        public int TableID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
