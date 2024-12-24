using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkySoftwareConsole.Models
{
    public class Calculator
    {
        public int x { get; set; }
        public int y { get; set; }

        public int Sum()
        {
            return(int)x + (int)y;
        }

    }
}
