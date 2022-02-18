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
            return Math.Round(Math.Sin(x + x * x),8);
        }

        public Double PKRA(double x, double h)
        {
            return Math.Round((Funcion(x+h) - Funcion(x))/h,8);
        }
        public Double LKRA(double x, double h)
        {
            return Math.Round((Funcion(x) - Funcion(x - h)) / h,8);
        }

        public Double CKRA(double x, double h)
        {
            return Math.Round((Funcion(x + h) - Funcion(x - h)) / (2 * h),8);
        }

        public Double CKRA2(double x, double h)
        {
            return Math.Round((Funcion(x + h) + Funcion(x - h) - 2 * Funcion(x)) / (h * h),8);
        }
    }
}
