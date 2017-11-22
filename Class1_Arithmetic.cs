using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    /*
     * Ashley Carr
     * P305379
     * 16/10/2017
     * Arithimetic Library for GUI Calculator
     * Revised Version for Assessment 1_7
     */

    public class Basic
    {
        //This is the Addition method 
        //Takes and returns a double value
        public static double Add(double a, double b)
        {
            return (a + b);
        }

        //This is the Subtraction method 
        //Takes and returns a double value
        public static double Sub(double a, double b)
        {
            return (a - b);
        }

        //This is the Divide method 
        //Takes and returns a double value
        public static double Div(double a, double b)
        {
            return ((double)a / b);
        }

        //This is the Mutliply method 
        //Takes and returns a double value
        public static double Mult(double a, double b)
        {
            return (a * b);
        }
    }
}
