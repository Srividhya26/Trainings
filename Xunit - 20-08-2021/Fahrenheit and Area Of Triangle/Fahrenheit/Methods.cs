using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit
{
    public static class Methods
    {
        public static double Convert(double fahrenheit)
        {
            double celsius;
            //if(fahrenheit > 0 )
            //{
            celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
            //}
            //else
            //{
            //    celsius = - ((fahrenheit - 32) * 5 / 9);
            //    return celsius;
            //}   
            
        }

        public static double AreaOfTriangle(int b,int h)
        {
            double area = (b * h) / 2;
            return area;
        }
    }
}
