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
        /// constructor to intialize x and y
        /// </summary>
        /// <param name="x">this.x</param>
        /// <param name="y">this.y</param>
        public Calculator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        ///  x and y property
        /// </summary>
        private  int x { get; set; }
        private  int y { get; set; }
        /// <summary>
        ///  sum function calculate summation between x and y
        /// </summary>
        /// <returns></returns>
        public int Sum()
        {
            var sum = x + y;
            return sum;
        }
        /// <summary>
        ///Subtract function calculate Difference  between x and y
        /// </summary>
        /// <returns></returns>
        public int Subtract()
        {
            return(int)x - (int)y;
        }
        /// <summary>
        ///Multipy Function  calculate product between x and y
        /// </summary>
        /// <returns></returns>
        public int Multiply()
        {
            return(int)x * (int)y;
        }
        /// <summary>
        /// Divide Function calculate Quotient  between x and y
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
