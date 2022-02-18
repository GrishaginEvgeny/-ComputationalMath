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
        private Dictionary<string,List<double>> TableFunctionList;
        private Dictionary<string, List<double>> TableLKRAList;
        private Dictionary<string, List<double>> TablePKRAList;
        private Dictionary<string, List<double>> TableCKRAList;
        private Dictionary<string, List<double>> TableCKRA2List;

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
            TableFunctionList = new Dictionary<string, List<double>>();
            TableLKRAList = new Dictionary<string, List<double>>();
            TablePKRAList = new Dictionary<string, List<double>>();
            TableCKRAList = new Dictionary<string, List<double>>();
            TableCKRA2List = new Dictionary<string, List<double>>();
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

            TableFunctionList = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), Convert.ToDouble(StepField.Text), functionTableDelegate);
            TableLKRAList = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), Convert.ToDouble(StepField.Text), lkraTableDelegate);
            TablePKRAList = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), Convert.ToDouble(StepField.Text), pkraTableDelegate);
            TableCKRAList = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), Convert.ToDouble(StepField.Text), ckraTableDelegate);
            TableCKRA2List = complicatedMath.getTable(Convert.ToDouble(LeftBorderField.Text), Convert.ToDouble(RightBorderField.Text), Convert.ToDouble(StepField.Text), ckra2TableDelegate);


            FillTable(TableFunctionList, FunctionTable);
            FillTable(TableLKRAList, LKRATable);
            FillTable(TablePKRAList, PKRATable);
            FillTable(TableCKRAList, CKRATable);
            FillTable(TableCKRA2List, CKRA2Table);

            Chart.Series.Clear();

            DrawGraphic(Chart, FunctionTable, FunctionLabel.Text, Color.Blue);
            DrawGraphic(Chart, PKRATable, PKRALabel.Text, Color.Red);
            DrawGraphic(Chart, LKRATable, LKRALabel.Text, Color.Orange);
            DrawGraphic(Chart, CKRATable, CKRALabel.Text, Color.Green);
            DrawGraphic(Chart, CKRA2Table, CKRA2Label.Text, Color.Black);
        }
    }
}
