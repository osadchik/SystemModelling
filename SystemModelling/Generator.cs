using System;
using System.Collections.Generic;

namespace RandomGenerator
{
    internal class Generator
    {
        private readonly Random dice;

        public Generator()
        {
            dice = new Random();
        }

        public (double Seed, double Number) MethodOne(double lambda)
        {
            var randomNumber = GetRandomValue();
            return (randomNumber, - (1 / lambda * Math.Log(1 - randomNumber)));
        }

        public double MethodTwo(double mu, double sigma)
        {
            double result = 0;

            for (int i = 1; i <= 12; i++)
            {
                result += GetRandomValue();
            }

            return (result - 6) * sigma + mu;
        }

        public IList<double> MethodThree(double rootNumber, double b, double c, uint count)
        {
            List<double> result = new List<double>();
            double next = rootNumber;

            for (int i = 0; i < count; i++)
            {
                next = b * next % c / c;
                result.Add(next);
            }

            return result;
        }

        private double GetRandomValue()
        {
            double randomNumber;

            do
            {
                randomNumber = dice.NextDouble();
            } while (randomNumber == 0);

            return randomNumber;
        }
    }
}
