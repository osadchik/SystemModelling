using RandomGenerator;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using ChartBuilder;

namespace SystemModelling
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var numberOfIterations = 10000;
            var lambda = 1;

            List<(double Seed, double Number)> numbers = new List<(double, double)>();

            var generator = new Generator();
            for (int i = 0; i < numberOfIterations; i++)
            {
                await Task.Run(() => numbers.Add(generator.MethodOne(lambda)));
            }

            numbers.Sort();
            Split(numbers);
        }

        public static List<List<double>> Split(List<(double Seed, double Number)> numbers)
        {
            var min = numbers.Min(n => n.Number);
            var max = numbers.Max(n => n.Number);
            var length = (max - min) / 20;
            List<List<double>> chunked = new List<List<double>>();

            for (int i = 0; i < 21; i++)
            {
                chunked.Add(new List<double>());
            }

            foreach (var number in numbers.Select(n => n.Number))
            {
                var index = (int)Math.Truncate(number / length);
                chunked[index].Add(number);
            }

            foreach (var item in chunked)
            {
                Console.WriteLine($"Count: {item.Count}");
            }

            return chunked;
        }
    }
}
