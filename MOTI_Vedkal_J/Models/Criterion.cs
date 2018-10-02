using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTI_Vedkal_J.Models
{
    public class Criterion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Range { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
        public string OptimType { get; set; }
        public string EdIzmer { get; set; }
        public string ScaleType { get; set; }

        public ICollection<Mark> Marks { get; set; }
    }
}
