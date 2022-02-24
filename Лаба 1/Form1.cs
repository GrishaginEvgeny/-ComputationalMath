using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        BaseMathAction baseMath = new BaseMathAction();
        ComplicatedMathActions complicatedMath = new ComplicatedMathActions();

        private const double M2 = 6.288;
        private const double M3 = 12.611;
        private const double M4 = 51.569;

        private readonly double E;
        public enum Params
        {
            LKRA_PKRA = 0,
            CKRA1 = 1,
            CKRA2 = 2
        }

        public delegate double TableDelegate(double x, double h);

        public Form1()
        {
            InitializeComponent();
            FunctionTable.Columns[0].Name = "x";
            FunctionTable.Columns[1].Name = "y";
            PKRATable.Columns[0].Name = "x";
            PKRATable.Columns[1].Name = "y";
            LKRATable.Columns[0].Name = "x";
            LKRATable.Columns[1].Name = "y";
            CKRATable.Columns[0].Name = "x";
            CKRATable.Columns[1].Name = "y";
            CKRA2Table.Columns[0].Name = "x";
            CKRA2Table.Columns[1].Name = "y";
            E = baseMath.findE();
        }

        public void DrawGraphic(Chart chart, DataGridView data, string legend, Color color)
        {
            chart.Series.Add(legend);
            chart.Series[legend].Legend = "Legend1";
            chart.Series[legend].Color = color;
            chart.Series[legend].ChartType = SeriesChartType.Line;
            for (int i = 0; data.RowCount > i; i++)
            {
                chart.Series[legend].Points.AddXY(Convert.ToDouble(data["x", i].Value), Convert.ToDouble(data["y", i].Value));
            }
        }


        public void FillTable(Dictionary<string, List<double>> valuePairs, DataGridView Table)
        {
            Table.Rows.Clear();
            bool flag = true;
            foreach(KeyValuePair<string,List<double>> item in valuePairs)
            {
                for(int i = 0; i < item.Value.Count; i++)
                {
                    if (flag) Table.Rows.Add();
                    Table[item.Key, i].Value = item.Value[i];
                }
                flag = false;
            }
        }

        private void SolutionButtonClick(object sender, EventArgs e)
        {
            TableDelegate functionTableDelegate = baseMath.Funcion;
            TableDelegate lkraTableDelegate = baseMath.LKRA;
            TableDelegate pkraTableDelegate = baseMath.PKRA;
            TableDelegate ckraTableDelegate = baseMath.CKRA;
            TableDelegate ckra2TableDelegate = baseMath.CKRA2;

            Dictionary<string, List<double>> FunctionPairs = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), Convert.ToDouble(StepField.Text), functionTableDelegate);
            List<double> x = FunctionPairs["x"];

            Dictionary<string, double> LKRA_PKRA_Params = complicatedMath.findOptimalParams(Convert.ToDouble(EpsilonField.Text), Convert.ToDouble(StepField.Text), x, Params.LKRA_PKRA);
            Dictionary<string, double> CKRA1Params = complicatedMath.findOptimalParams(Convert.ToDouble(EpsilonField.Text), Convert.ToDouble(StepField.Text), x, Params.CKRA1);
             Dictionary<string, double> CKRA2Params = complicatedMath.findOptimalParams(Convert.ToDouble(EpsilonField.Text), Convert.ToDouble(StepField.Text), x, Params.CKRA2);

            Approximation PKRA = new Approximation(LKRA_PKRA_Params["h"], LKRA_PKRA_Params["MaxDiffPKRA"]);
            Approximation LKRA = new Approximation(LKRA_PKRA_Params["h"], LKRA_PKRA_Params["MaxDiffLKRA"]);
            Approximation Function = new Approximation(LKRA_PKRA_Params["h"], null);
            Approximation CKRA1 = new Approximation(CKRA1Params["h"], CKRA1Params["MaxDiffCKRA1"]);
            Approximation CKRA2 = new Approximation(CKRA2Params["h"], CKRA2Params["MaxDiffCKRA2"]);

            LKRA.TableData = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), LKRA.getH(), lkraTableDelegate);
            PKRA.TableData = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), PKRA.getH(), pkraTableDelegate);
            CKRA1.TableData = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), CKRA1.getH(), ckraTableDelegate);
            CKRA2.TableData = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), CKRA2.getH(), ckra2TableDelegate);
            Function.TableData = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), Function.getH(), functionTableDelegate);


            FillTable(Function.TableData, FunctionTable);
            FillTable(LKRA.TableData, LKRATable);
            FillTable(PKRA.TableData, PKRATable);
            FillTable(CKRA1.TableData, CKRATable);
            FillTable(CKRA2.TableData, CKRA2Table);

            Chart.Series.Clear();

            DrawGraphic(Chart, FunctionTable, FunctionLabel.Text, Color.Blue);
            DrawGraphic(Chart, PKRATable, PKRALabel.Text, Color.Red);
            DrawGraphic(Chart, LKRATable, LKRALabel.Text, Color.Orange);
            DrawGraphic(Chart, CKRATable, CKRALabel.Text, Color.Green);
            DrawGraphic(Chart, CKRA2Table, CKRA2Label.Text, Color.Black);

            R1Field.Text = ((M2 * LKRA_PKRA_Params["h"])/2.0).ToString();
            R2Field.Text = ((2.0 * E) / LKRA_PKRA_Params["h"]).ToString();
            H0LRField.Text = (2.0 * Math.Sqrt(E / M2)).ToString();
            H0CField.Text = Math.Pow(((3 * E) / M3), 1.0 / 3.0).ToString();
            H0C2Field.Text = (2 * Math.Pow(((3 * E) / M4), 1.0 / 4.0)).ToString();

            RLRField.Text = LKRA_PKRA_Params["MaxDiffPKRA"].ToString();
            RCField.Text = CKRA1Params["MaxDiffCKRA1"].ToString();
            RC2Field.Text = CKRA2Params["MaxDiffCKRA2"].ToString();

        }
    }
}
