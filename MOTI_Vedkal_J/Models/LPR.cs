using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTI_Vedkal_J.Models
{
    public class LPR
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Range { get; set; }

        public ICollection<Result> Results { get; set; }
    }
}
