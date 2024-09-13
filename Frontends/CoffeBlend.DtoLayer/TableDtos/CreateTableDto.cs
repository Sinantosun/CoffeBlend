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
        public byte Status { get; set; } = 1;
        public int Capacity { get; set; }
    }
}
