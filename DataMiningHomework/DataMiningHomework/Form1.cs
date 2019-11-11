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

        int a=0;
        int range = 0;
        int sampleSize = 0;
        Double varianceSum = 0;
        int nbrSamplesGenerated = 0;
        Double cumulativeMean = 0;
        Double cumulativeVarianceSum = 0;
        Double cumulativeSD = 0;
        List<Double> populationList = new List<Double>();
        List<Double> sampleList = new List<Double>();
        

        private void btnGenerateSample_Click(object sender, EventArgs e)
        {
            range = Convert.ToInt32(txtRange.Text);
            sampleSize = Convert.ToInt32(txtSampleSize.Text);
            if (nbrSamplesGenerated == 0)
            {
                nbrSamplesGenerated++;
                generatePopulation();
                cumulativeMean = getMean(populationList);
                txtMean.Text = getMean(populationList).ToString() + " \n";
                txtVariance.Text = calcSampleVarianceSum(populationList).ToString() + " \n";
                txtSD.Text = calcStandardDeviation(populationList).ToString() + " \n";
            }
            else
            {
                generateSample();
                txtSampleMean.Text = getCumulativeMean(getMean(sampleList)).ToString();
                txtVarianceM3.Text = getCumulativeVarianceSum(sampleList, -3).ToString();
                txtVarianceM2.Text= getCumulativeVarianceSum(sampleList, -2).ToString();
                txtVarianceM1.Text = getCumulativeVarianceSum(sampleList, -1).ToString();
                txtVariance0.Text = getCumulativeVarianceSum(sampleList, 0).ToString();
                txtVariance1.Text = getCumulativeVarianceSum(sampleList, 1).ToString();
                txtSDM3.Text = getCumulativeSD(sampleList, -3).ToString();
                txtSDM2.Text = getCumulativeSD(sampleList, -2).ToString();
                txtSDM1.Text = getCumulativeSD(sampleList, -1).ToString();
                txtSD0.Text = getCumulativeSD(sampleList, 0).ToString();
                txtSD1.Text = getCumulativeSD(sampleList, 1).ToString();
                //txtVarianceCumulative.Text += getCumulativeVarianceSum(calcSampleVarianceSum(sampleList)).ToString() + " \n";
                //txtDeviationCumulative.Text += getCumulativeSD(calcStandardDeviation(sampleList)).ToString() + " \n";
                sampleList.Clear();
            }

        }

        public void generatePopulation()
        {
            Random rnd = new Random();
            for (int i = 0; i < range; i++)
            {
                populationList.Add(rnd.Next(0, range));
                txtBoxPopulation.Text += populationList[i].ToString() + " \n";
            }
        }

        public void generateSample()
        {
            Random rnd = new Random();
            for (int i = 0; i < sampleSize; i++)
            {
                sampleList.Add(rnd.Next(0, range));
                txtBoxPopulation.Text += sampleList[i].ToString() + " \n";
            }
        }

        public Double getMean(List<Double> list)
        {
            Double avg = 0;
            for (int i = 0; i < list.Count; i++)
            {
                avg += list[i];
            }
            avg = avg / list.Count;
            return avg;
        }
        public Double getCumulativeMean(Double mean)
        {
            cumulativeMean = (cumulativeMean + mean)/2;
            return cumulativeMean;
        }

        public Double calcSampleVarianceSum(List<Double> list)
        {
            Double sampleMean = getMean(list);
            for (int i = 0; i < list.Count; i++)
            {
                varianceSum = varianceSum + Math.Pow((list[i] - sampleMean), 2);
            }
            varianceSum = varianceSum / (list.Count);
            return varianceSum;
        }

        public Double getCumulativeVarianceSum(List<Double> list, int a)
        {
            Double sampleMean = getCumulativeMean(getMean(list));
            for (int i = 0; i < list.Count; i++)
            {
                cumulativeVarianceSum = cumulativeVarianceSum + Math.Pow((list[i] - sampleMean), 2);
            }
            cumulativeVarianceSum = cumulativeVarianceSum / (list.Count + a);
            return cumulativeVarianceSum;
        }
        
        public Double calcStandardDeviation(List<Double> list)
        {
            Double sd = 0;
            sd = Math.Pow(calcSampleVarianceSum(list),0.5);
            return sd;
        }

        public Double getCumulativeSD(List<Double> list, int a)
        {
            Double sd = 0;
            sd = Math.Pow(getCumulativeVarianceSum(list, a), 0.5);
            return sd;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sampleList.Clear();
            range = 0;
            sampleSize = 0;
            txtBoxPopulation.Text = "";
            txtVarianceM3.Text = "";
            txtMean.Text = "";
            txtVarianceM2.Text = "";
            txtRange.Text = "";
            txtSampleSize.Text = "";
            txtSD.Text = "";
            txtVariance.Text = "";
            txtVarianceM1.Text = "";
            txtVariance1.Text = "";
            txtVariance0.Text = "";
            txtSDM3.Text = "";
            txtSDM2.Text = "";
            txtSDM1.Text = "";
            txtSD.Text = "";
        }

    }
}
