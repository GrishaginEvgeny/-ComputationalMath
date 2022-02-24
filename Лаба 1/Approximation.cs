using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Approximation
    {
        private double h;

        private double? Difference;

        private Dictionary<string, List<double>> Data;
        public Dictionary<string, List<double>> TableData
        {
            get { return this.Data; }
            set { this.Data = value; }
        }

        public double getH()
        {
            return this.h;
        }

        public double? getDifference()
        {
            return this.Difference;
        }

        public Approximation(double h, double? Difference)
        {
            this.h = h;
            this.Difference = Difference;
        }
    }
}
