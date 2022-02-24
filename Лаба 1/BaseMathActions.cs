using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class BaseMathAction
    {
        public Double Funcion(double x, double h = 0)
        {
            return Math.Sin(x + x * x);
        }

        public Double PKRA(double x, double h)
        {
            return (Funcion(x+h) - Funcion(x))/h;
        }
        public Double LKRA(double x, double h)
        {
            return (Funcion(x) - Funcion(x - h)) / h;
        }

        public Double CKRA(double x, double h)
        {
            return (Funcion(x + h) - Funcion(x - h)) / (2 * h);
        }

        public Double CKRA2(double x, double h)
        {
            return (Funcion(x + h) + Funcion(x - h) - 2 * Funcion(x)) / (h * h);
        }

        public double findE()
        {
            double ep = 1;
            int n = 1;
            while((ep + 1) > 1)
            {
                ep /= 2;
                n++;
            }
            return Math.Pow(2, -1 * n);
        }

        public double findMaxDiff(int FirstIndex, int ToPointIndex, double h, List<double> x, Form1.TableDelegate MathFunction, int divider)
        {
            double result;
            List<double> Difference = new List<double>();
            for (int i = FirstIndex; i < ToPointIndex; i++)
            {
                Difference.Add(Math.Abs((MathFunction(x[i], h) - MathFunction(x[i], h / 2)) / divider));
            }
            result = Difference.Max();
            return result;
        }
    }
}
