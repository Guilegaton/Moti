using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTI_Vedkal_J.Models
{
    public class Alternative
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Result> Results { get; set; }
        public ICollection<Vector> Vectors { get; set; }
    }
}
