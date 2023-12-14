using MVCHistograma.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistograma.Model
{
    public class HistogramData
    {
        private int[] counts = new int[5];
        public double[] Percentages { get; private set; } = new double[5];

        public void ReadData(int n, Display display)
        {
            for (int i = 0; i < n; i++)
            {
                int number = display.ReadInt($"Enter number {i + 1}: ");
                int index = GetRangeIndex(number);
                counts[index]++;
            }
        }

        private int GetRangeIndex(int number)
        {
            if (number < 200) return 0;
            if (number < 400) return 1;
            if (number < 600) return 2;
            if (number < 800) return 3;
            return 4;
        }

        public void CalculatePercentages()
        {
            int total = 0;
            foreach (int count in counts)
            {
                total += count;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Percentages[i] = (double)counts[i] / total * 100;
            }
        }
    }
}
