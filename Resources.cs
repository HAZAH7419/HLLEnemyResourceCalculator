using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyResourceCalculator
{
    public class Resources
    {
        public int Fuel { get; set; } = 500;
        public int Munitions { get; set; } = 500;
        public int Manpower { get; set; } = 500;
        public int DefaultRate { get; set; } = 30;
        public int FullRate { get; set; } = 60;
        public int EncouragedRate { get; set; } = 90;
        public double ResourceRateSeconds { get; set; } = 10;
        public bool IsFullNodes { get; set; } = false;
        public bool IsEncouraged { get; set; } = false;
    }
}
