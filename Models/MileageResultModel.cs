using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab____.Models
{
    public class MileageResultModel
    {
        public double MPG { get; set; }
        public double Gallons { get; set; }
        public double Total => MPG * Gallons;
    }
}
