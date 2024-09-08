using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.TableDtos
{
    public class CreateTableDto
    {

        public string Name { get; set; }
        public bool Status { get; set; } = true;
        public int Capacity { get; set; }
    }
}
