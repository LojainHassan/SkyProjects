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
        public int Subtract()
        {
            return(int)x - (int)y;
        }
         public int Multiply()
        {
            return(int)x * (int)y;
        } 
        public int Divide()
        {
            try
            {
                var newVal = x / y;
                return newVal;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;

            }
        }

    }
}
