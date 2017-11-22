using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebraic
{
    /*
     * Ashley Carr
     * P305379
     * 16/10/2017
     * Arithimetic Library for GUI Calculator
     * Revised Version for Assessment 1_7
     */

    public class Power
    {
        //This is the Square Root method 
        //Uses the Math Library Math.Sqrt function
        //Takes and returns a double value
        public static double SquareRoot(double x)
        {
            double sqrt = Math.Sqrt(x);
            return sqrt;
        }

        //This is the Cubed Root method 
        //If less than 0 return a negative value in a negative method
        //Else Uses the Math Library Math.Pow function
        //Takes and returns a double value
        public static double CubeRoot(double y)
        {
            if (y < 0.0)
            {
                return -CubeRoot(-y);
            }
            else
            {
                return Math.Pow(y, 1.0 / 3.0);
            }
        }

        //This is the Inverse method 
        //Takes and returns a double value
        public static double Inverse(double i)
        {
            double inv = 1 / i;
            return inv;
        }
    }
}
