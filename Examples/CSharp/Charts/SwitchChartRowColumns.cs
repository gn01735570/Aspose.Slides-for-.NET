﻿using Aspose.Slides.Charts;
using Aspose.Slides.Export;
using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Slides.Examples.CSharp.Charts
{
    public class SwitchChartRowColumns
    {
        public static void Run()
        {
            //ExStart:SwitchChartRowColumns
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Charts();

            // Creating empty presentation
            using (Presentation pres = new Presentation())
            {
                IChart chart = pres.Slides[0].Shapes.AddChart(ChartType.ClusteredColumn, 100, 100, 400, 300);

                //Add data
                IChartSeries[] series = new IChartSeries[chart.ChartData.Series.Count];
                chart.ChartData.Series.CopyTo(series, 0);

                IChartDataCell[] categoriesCells = new IChartDataCell[chart.ChartData.Categories.Count];

                for (int i = 0; i < chart.ChartData.Categories.Count; i++)
                {
                    categoriesCells[i] = chart.ChartData.Categories[i].AsCell;
                }

                IChartDataCell[] seriesCells = new IChartDataCell[chart.ChartData.Series.Count];
                for (int i = 0; i < chart.ChartData.Series.Count; i++)
                {
                    seriesCells[i] = chart.ChartData.Series[i].Name.AsCells[0];
                }

                //Switching rows and columns
                chart.ChartData.SwitchRowColumn();
           
                // Saving presentation
                pres.Save(RunExamples.OutPath + "SwitchChartRowColumns_out.pptx", SaveFormat.Pptx);
                //ExEnd:SwitchChartRowColumns
            }
        }
    }
}
