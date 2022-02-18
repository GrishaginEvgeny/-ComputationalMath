using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class ComplicatedMathActions
    {

        const double epsilon = 0.000000001;
        BaseMathAction mathAction = new BaseMathAction();

        public Dictionary<string, List<double>> getTable(double left_border, double right_border, double h, Form1.TableDelegate table)
        {
            Dictionary<string, List<double>> FunctionTable = new Dictionary<string, List<double>>();
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            while (Math.Abs(left_border - right_border + h)>epsilon)
            {
                x.Add(left_border);
                y.Add(table(left_border,h));
                left_border = left_border + h;
            }

            FunctionTable.Add("x", x);
            FunctionTable.Add("y", y);

            return FunctionTable;
        }
    }
}
