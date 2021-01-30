using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zwift_Challenge.Data
{
    public class WorkoutData
    {
        public DateTime Date { get; set; }
        public string Rider { get; set; }
        public TimeSpan Time { get; set; }
        public float Distance { get; set; }
        public int Elevation { get; set; }
        public int Calories { get; set; }
        public string Route { get; set; }
    }
}
