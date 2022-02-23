using System;
using System.Collections.Generic;

namespace ChartBuilder
{
    internal static class FunctionsCalculator
    {
        public static List<double> GetValuesFromExponentialFunction(List<double> randomNumbers, double lambda)
        {
            var values = new List<double>();

            foreach (var item in randomNumbers)
            {
                values.Add(1 - Math.Pow(Math.E, - lambda * item));
            }

            return values;
        }

        public static List<double> GetValuesFromBynominalFunction(List<double> randomNumbers, double sigma, double mu)
        {
            var values = new List<double>();

            foreach (var item in randomNumbers)
            {
                values.Add(1 / (sigma * Math.Sqrt(2 * Math.PI)) * Math.Exp(- Math.Pow(item - mu, 2) / (2 * Math.Pow(sigma, 2))));
            }

            return values;
        }

        public static List<double> GetValuesFromUniformFunction(List<double> randomNumbers)
        {
            var values = new List<double>();

            for (double i = 0; i < randomNumbers.Count; i++)
            {
                values.Add(1 / (i + 1));
            }

            return values;
        }
    }
}
