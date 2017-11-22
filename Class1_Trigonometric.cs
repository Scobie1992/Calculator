using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigonometric
{
    /*
     * Ashley Carr
     * P305379
     * 16/10/2017
     * Arithimetic Library for GUI Calculator
     * Revised Version for Assessment 1_7
     */

    public class Angle
    {
        //This is the Sine method 
        //Coverts the degrees value to radians with Math.PI function
        //Runs calculation using Math.Sin function
        //Rounds the result to 15 decimal places
        //Takes and returns a double value
        public static double Sine(double s)
        {
            double sineD = s * (Math.PI / 180.0);
            double sineR = Math.Sin(sineD);
            double result = Math.Round(sineR, 15);
            return result;
        }

        //This is the Cosine method 
        //Coverts the degrees value to radians with Math.PI function
        //Runs calculation using Math.Cos function
        //Rounds the result to 15 decimal places
        //Takes and returns a double value
        public static double Cosine(double c)
        {
            double cosineD = c * (Math.PI / 180.0);
            double cosineR = Math.Cos(cosineD);
            double result = Math.Round(cosineR, 15);
            return result;
        }

        //This is the Tangent method 
        //Coverts the degrees value to radians with Math.PI function
        //Runs calculation using Math.Tan function
        //Rounds the result to 15 decimal places
        //Takes and returns a double value
        public static double Tangent(double t)
        {
            double tangentD = t * (Math.PI / 180.0);
            double tangentR = Math.Tan(tangentD);
            double result = Math.Round(tangentR, 15);
            return result;
        }
    }
}
