using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTPodev01
{
    internal class Matematik
    {
        public int MaxBul(int[] girilenD)
        {
            int max = 0;
            foreach (int i in girilenD)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }
        public double KarekökBul(double n)
        {
            double x = 1;

            for (int i = 0; i < 10; i++)
            {
                x = (x + n / x) / 2;
            }
            return x;
        }
        public int MutlakBul(int n)
        {
            if (n < 0)
                n = -n;
            return n;
        }
        public double SinBul(double derece)
        {
            derece = derece % 360;
            double radyan = derece * 3.14159265358979323846 / 180.0;
            double result  = 0.0;
            double term = radyan;
            int isaret = 1;

            for (int i = 1; i <= 100; ++i)
            {
                result += isaret * term;
                term *= (radyan * radyan) / ((2 * i) * (2 * i + 1));
                isaret *= -1;
            }

            return result;

        }
        public double cosBul(double derece)
        {
            derece = derece % 360;
            double radians = derece * 3.14159265358979323846 / 180.0;
            double result = 0.0;
            double term = 1.0;
            int isaret = 1;

            for (int i = 0; i <= 10; ++i)
            {
                result += isaret * term;
                term *= (radians * radians) / ((2 * i + 1) * (2 * i + 2));
                isaret *= -1;
            }

            return result;
        }

    }
}
