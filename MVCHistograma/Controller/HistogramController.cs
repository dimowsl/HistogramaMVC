using MVCHistograma.View;
using MVCHistograma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistograma.Controller
{
    public class HistogramController
    {
        HistogramData histogramdata;
        Display display;

        public HistogramController()
        {
            this.histogramdata = new HistogramData();
            this.display = new Display();
        }

        public void Run()
        {
            int n = display.ReadInt("Enter the number of elements: ");
            histogramdata.ReadData(n, display);
            histogramdata.CalculatePercentages();
            display.PrintHistogram(histogramdata.Percentages);
        }
    }
}
