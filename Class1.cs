using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAX
{
    internal class GPAXCalculator
    {
        private double gpa;
        private double sum_gpa;
        private double max = double.MinValue; 
        private double min = double.MaxValue; 
        private int n;

        public void setGPA(double gpa)
        {
            this.sum_gpa += gpa;

            this.n++;

            if (gpa > max)
            {
                max = gpa;
            }

            if (gpa <= min) 
            {
                min = gpa;
            }
        }

        public double getGPAX()
        {
            return Math.Round(this.sum_gpa / this.n, 2);
        }

        public double getMax()
        {
            return Math.Round(this.max, 2);
        }

        public double getMin()
        {
            return Math.Round(this.min, 2);
        }
    }
}
