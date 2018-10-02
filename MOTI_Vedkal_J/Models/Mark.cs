using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTI_Vedkal_J.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Range { get; set; }
        public int NumMark { get; set; }
        public int NormMark { get; set; }

        public int CriterionId { get; set; }
        public Criterion Criterion { get; set; }

        public ICollection<Vector> Vectors { get; set; }
    }
}
