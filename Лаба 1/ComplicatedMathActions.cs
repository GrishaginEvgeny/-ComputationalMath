using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class ComplicatedMathActions
    {
        BaseMathAction mathAction = new BaseMathAction();

        public Dictionary<string, List<double>> getTable(double left_border, double right_border, double h, Form1.TableDelegate table)
        {
            Dictionary<string, List<double>> FunctionTable = new Dictionary<string, List<double>>();
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            while (left_border<=right_border)
            {
                x.Add(left_border);
                y.Add(table(left_border,h));
                left_border = left_border + h;
            }

            FunctionTable.Add("x", x);
            FunctionTable.Add("y", y);

            return FunctionTable;
        }

        public Dictionary<string, double> findOptimalParams(double eps, double old_h, List<double> x, Form1.Params @params)
        {
            bool flag = true;
            Dictionary<string, double> result = new Dictionary<string, double>();
            Dictionary<string, List<double>> ForCompute = new Dictionary<string, List<double>>();
            switch (@params)
            {
                case Form1.Params.LKRA_PKRA:
                    {
                        Form1.TableDelegate PKRA = mathAction.PKRA;
                        Form1.TableDelegate LKRA = mathAction.LKRA;
                        while (flag)
                        {
                            if (eps >= mathAction.findMaxDiff(0, x.Count - 1, old_h, x, PKRA, 1) && eps >= mathAction.findMaxDiff(1, x.Count, old_h, x, LKRA, 1)){
                                result.Add("h", old_h);
                                result.Add("MaxDiffPKRA", mathAction.findMaxDiff(0, x.Count - 1, old_h, x, PKRA, 1));
                                result.Add("MaxDiffLKRA", mathAction.findMaxDiff(0, x.Count - 1, old_h, x, LKRA, 1));
                                flag = false;
                            }
                            else old_h /= 2;
                        }
                        break;
                    }

                case Form1.Params.CKRA1:
                    {
                        Form1.TableDelegate CKRA = mathAction.CKRA;
                        while (flag)
                        {
                            if (eps >= mathAction.findMaxDiff(1, x.Count - 1, old_h, x, CKRA, 3))
                            {
                                result.Add("h", old_h);
                                result.Add("MaxDiffCKRA1", mathAction.findMaxDiff(1, x.Count - 1, old_h, x, CKRA, 3));
                                flag = false;
                            }
                            else old_h /= 2;
                        }
                        break;
                    }
                case Form1.Params.CKRA2:
                    {
                        Form1.TableDelegate CKRA2 = mathAction.CKRA2;
                        while (flag)
                        {
                            if (eps >= mathAction.findMaxDiff(1, x.Count - 1, old_h, x, CKRA2, 3))
                            {
                                result.Add("h", old_h);
                                result.Add("MaxDiffCKRA2", mathAction.findMaxDiff(1, x.Count - 1, old_h, x, CKRA2, 3));
                                flag = false;
                            }
                            else old_h /= 2;
                        }
                        break;
                    }
            }
            return result;
        }
    }
}
