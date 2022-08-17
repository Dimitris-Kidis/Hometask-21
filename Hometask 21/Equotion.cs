using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Equation
    {
        public Equation() { }

        public int CheckSQRTPart(double a, double b, double c)
        {
            double sqrtpart = b * b - 4 * a * c;
            if (sqrtpart > 0)
            {
                return 1;
            }
            else if (sqrtpart < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private Dictionary<char, int> RomanMap = new Dictionary<char, int>()
        {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
        };

        public int RomanToInteger(string roman)
        {
            int number = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
                {
                    number -= RomanMap[roman[i]];
                }
                else
                {
                    number += RomanMap[roman[i]];
                }
            }
            return number;
        }
    }

}
