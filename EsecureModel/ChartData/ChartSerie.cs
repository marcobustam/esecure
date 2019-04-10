using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.ChartData
{
    public class ChartSerie
    {
        /*
         *             var densityData2 = {
                label: 'Mes actual',
                data: [55, 90, 50, 90],
                backgroundColor: [
                    "#FF6384",
                    "#63FF84",
                    "#84FF63",
                    "#8463FF"
                ]
            };
         * */
        public int ChartSerieID { get; set; }
        public string Label { get; set; }
        public IList<int> Data { get; set; }
        public IList<string> BackgroundColor { get; set; }

        public ChartSerie()
        {
            Label = "Mes actual";
            var seed = DateTime.Now.Millisecond;
            var r = new Random(seed - DateTime.Now.Millisecond);
            Data = new List<int>();
            BackgroundColor = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                var value = r.Next(50, 100);
                Data.Add(value);
                // No cumple!!
                if (value < 95)
                {
                    BackgroundColor.Add("#ff1e17");
                }
                // Cumple
                else
                {
                    BackgroundColor.Add("#32cd32");
                }

            }

            // Data = new List<int>(){ 55, 90, 50, 90 };

        }
        public ChartSerie(int xi)
        {
            Label = "Mes actual";
            var seed = DateTime.Now.Millisecond;
            var r = new Random(xi);
            Data = new List<int>();
            BackgroundColor = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                var value = r.Next(50, 100);
                Data.Add(value);
                // No cumple!!
                if (value < 95)
                {
                    BackgroundColor.Add("#ff1e17");
                }
                // Cumple
                else
                {
                    BackgroundColor.Add("#32cd32");
                }

            }

            // Data = new List<int>(){ 55, 90, 50, 90 };

        }
    }
}
