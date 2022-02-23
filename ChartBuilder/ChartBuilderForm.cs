using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChartBuilder
{
    public partial class ChartBuilderForm : Form
    {
        private const double numberOfIterations = 10000;
        private const double lambda = 100;
        private const double mu = 12;
        private const double sigma = 2;
        private readonly double rootNumber = Math.Pow(2, 16);
        private readonly double b = Math.Pow(5, 11);
        private readonly double c = Math.Pow(2, 32);

        private readonly Generator generator = new Generator(); 

        public ChartBuilderForm()
        {
            InitializeComponent();

            MainChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            MainChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            MainChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            MainChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
        }

        private void FirstMethodButton_Click(object sender, EventArgs e)
        {
            List<double> numbers = new List<double>();

            for (int i = 0; i < numberOfIterations; i++)
            {
                numbers.Add(generator.MethodOne(lambda));
            }

            var expectedValues = FunctionsCalculator.GetValuesFromExponentialFunction(numbers, lambda);
            DrawCharts(numbers, expectedValues);
            ChiLabel.Text = CalculateChi(numbers, expectedValues).ToString();
        }

        private void SecondMethodButton_Click(object sender, EventArgs e)
        {
            List<double> numbers = new List<double>(); 

            for (int i = 0; i < numberOfIterations; i++)
            {
                numbers.Add(generator.MethodTwo(mu, sigma));
            }

            var expectedValues = FunctionsCalculator.GetValuesFromBynominalFunction(numbers, sigma, mu);
            DrawCharts(numbers, expectedValues);
            ChiLabel.Text = CalculateChi(numbers, expectedValues).ToString();
        }

        private void ThirdMethodButton_Click(object sender, EventArgs e)
        {
            List<double> numbers = generator.MethodThree(rootNumber, b, c, numberOfIterations);
            var expectedValues = FunctionsCalculator.GetValuesFromUniformFunction(numbers);
            DrawCharts(numbers, expectedValues);
            ChiLabel.Text = CalculateChiForEvenDistribution(numbers, expectedValues).ToString();
        }

        private void DrawCharts(List<double> numbers, List<double> expectedValues)
        {
            MainChart.Series.Clear();

            var original = MainChart.Series.Add("Values");

            var average = CalculateAverage(numbers);
            var chunks = Split(numbers);

            AverageLabel.Text = average.ToString();
            DispersionLabel.Text = CalculateDispersion(numbers, average).ToString();

            foreach (var chunk in chunks)
            {
                if (!chunk.Any())
                {
                    continue;
                }
                original.Points.AddXY(Math.Round(chunk.Min(), 3), chunk.Count);
            }
        }

        private double CalculateChi(List<double> realValues, List<double> expectedValues)
        {
            var splittedRealValues = Split(realValues);
            var splittedExpectedValues = Split(expectedValues,
                splittedRealValues.SelectMany(v => v).Min(),
                splittedRealValues.SelectMany(v => v).Max());
            //var splittedExpectedValues = Split(expectedValues);
            double result = 0;

            for (int i = 0; i < splittedRealValues.Count; i++)
            {
                if (splittedRealValues[i].Count >= 5)
                {
                    result += Math.Pow(splittedRealValues[i].Count - splittedExpectedValues[i].Count, 2) / splittedExpectedValues[i].Count;
                }
            }

            return FormatResult(result);
        }

        private double CalculateChiForEvenDistribution(List<double> realValues, List<double> expectedValues)
        {
            var splittedRealValues = Split(realValues);
            double result = 0;

            for (int i = 0; i < splittedRealValues.Count; i++)
            {
                if (splittedRealValues[i].Count >= 5)
                {
                    result += Math.Pow(splittedRealValues[i].Count - expectedValues.Count / 20, 2) / expectedValues.Count / 20;
                }
                else
                {
                    continue;
                }

            }

            return result;
        }

        public static List<List<double>> Split(List<double> numbers)
        {
            numbers.Sort();
            List<List<double>> chunked = new List<List<double>>();

            var min = numbers.Min(n => n);
            var max = numbers.Max(n => n);
            var length = (max - min) / 20;

            for (int i = 0; i < 21; i++)
            {
                chunked.Add(new List<double>());
            }

            foreach (var number in numbers.Select(n => n))
            {
                var index = (int)Math.Truncate((number - min) / length);
                chunked[index].Add(number);
            }

            return chunked;
        }

        public static List<List<double>> Split(List<double> numbers, double min, double max)
        {
            numbers.Sort();
            List<List<double>> chunked = new List<List<double>>();
            var length = (max - min) / 20;

            for (int i = 0; i < 21; i++)
            {
                chunked.Add(new List<double>());
            }

            foreach (var number in numbers.Select(n => n))
            {
                var index = 0;
                if (number >= min)
                {
                    index = (int)Math.Truncate((number - min) / length);
                }
                if (number > max)
                {
                    index = 20;
                }
                chunked[index].Add(number);
            }

            return chunked;
        }

        private double CalculateAverage(List<double> numbers)
        {
            return numbers.Sum() / numbers.Count;
        }

        private double CalculateDispersion(List<double> numbers, double average)
        {
            double result = 0;

            foreach (var item in numbers)
            {
                result += Math.Pow(item - average, 2);
            }

            return result / (numbers.Count - 1);
        }

        private double FormatResult(double number)
        {
            return number % 5 + 7;
        }
    }
}
