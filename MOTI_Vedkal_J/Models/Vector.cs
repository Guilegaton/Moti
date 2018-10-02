using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTI_Vedkal_J.Models
{
    public class Vector
    {
        public int Id { get; set; }

        public int AlternativeId { get; set; }
        public Alternative Alternative { get; set; }

        public int MarkId { get; set; }
        public Mark Mark { get; set; }

    }
}
