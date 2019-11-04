using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMiningHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rangeSize = 0;
        int sampleSize = 0;
        Double varianceSum = 0;
        Random rnd = new Random();
        List<int> sampleList = new List<int>();
        int nbrSamplesGenerated = 0;
        Double cumulativeMean = 0;
        Double cumulativeVarianceSum = 0;
        Double cumulativeSD = 0;

        private void btnGenerateSample_Click(object sender, EventArgs e)
        {
            rangeSize = Convert.ToInt32(txtRange.Text);
            sampleSize = Convert.ToInt32(txtSampleSize.Text);
                for (int i = 0; i < sampleSize; i++)
                {
                    sampleList.Add(rnd.Next(0, rangeSize));
                    txtBoxPopulation.Text += sampleList[i].ToString() + " \n";
                }
                txtMean.Text = getMean(sampleList).ToString();
                txtVariance.Text = calcSampleVarianceSum(sampleList).ToString();
                txtSD.Text = calcStandardDeviation(sampleList).ToString();
            txtMeanCumulative.Text += cumulativeMean.ToString() + " \n";
            txtVarianceCumulative.Text += cumulativeVarianceSum.ToString() + " \n";
            txtDeviationCumulative.Text += cumulativeSD.ToString() + " \n";
        }

        public Double getMean(List<int> list)
        {
            Double avg = 0;
            for (int i = 0; i < list.Count; i++)
            {
                avg += list[i];
            }
            avg = avg / list.Count;
            cumulativeMean = cumulativeMean + avg;
            return avg;
        }

        public Double calcSampleVarianceSum(List<int> list)
        {
            Double sampleMean = getMean(list);
            for (int i = 0; i < list.Count; i++)
            {
                varianceSum = varianceSum + Math.Pow((list[i] - sampleMean), 2);
            }
            varianceSum = varianceSum / (list.Count - 1);
            cumulativeVarianceSum = cumulativeVarianceSum + varianceSum;
            return varianceSum;
        }
        
        public Double calcStandardDeviation(List<int> list)
        {
            Double sd = 0;
            sd = Math.Pow(calcSampleVarianceSum(list),0.5);
            cumulativeSD = cumulativeSD + sd;
            return sd;
        }
        
    }
}
