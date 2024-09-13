using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.TableDtos
{
    public class ResultTableByIdDto
    {
        public int TableID { get; set; }
        public string Name { get; set; }
        public byte Status { get; set; }
        public int Capacity { get; set; }
    }
}
