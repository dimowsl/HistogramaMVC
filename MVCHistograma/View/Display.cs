using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistograma.View
{
    public class Display
    {
        public int ReadInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        public void PrintHistogram(double[] percentages)
        {
            for (int i = 0; i < percentages.Length; i++)
            {
                Console.WriteLine($"p{i + 1} = {percentages[i]:0.00}%");
            }
        }
    }
}
