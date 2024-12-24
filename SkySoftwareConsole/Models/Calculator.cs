using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkySoftwareConsole.Models
{
    public class Calculator
    {
        /// <summary>
        ///  x and y property
        /// </summary>
        public int x { get; set; }
        public int y { get; set; }
        /// <summary>
        ///  sum function calculate summation between x and y
        /// </summary>
        /// <returns></returns>
        public int Sum()
        {
            return(int)x + (int)y;
        }    
        /// <summary>
        ///Subtract function calculate Subtraction between x and y
        /// </summary>
        /// <returns></returns>
        public int Subtract()
        {
            return(int)x - (int)y;
        }
        /// <summary>
        ///Multipy Function  calculate multiplication between x and y
        /// </summary>
        /// <returns></returns>
        public int Multiply()
        {
            return(int)x * (int)y;
        }
        /// <summary>
        /// Divide Function calculate Division between x and y
        /// Contain DivideByZeroException to handle DivideByZero
        /// </summary>
        /// <returns></returns>
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
