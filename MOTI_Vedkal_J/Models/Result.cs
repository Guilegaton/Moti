using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTI_Vedkal_J.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int LPRId { get; set; }
        public LPR LPR { get; set; }
        public int AlternativeId { get; set; }
        public Alternative Alternative { get; set; }
        public int Range { get; set; }
        public int Weight { get; set; }
    }
}
