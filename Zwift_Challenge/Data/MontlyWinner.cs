using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zwift_Challenge.Data
{
    public class MontlyWinner
    {
        public string Rider { get; set; }
        public string Month { get; set; }
        public int MonthNumber { get; set; }
        public ContestWinner Contest { get; set; }
    }
}
