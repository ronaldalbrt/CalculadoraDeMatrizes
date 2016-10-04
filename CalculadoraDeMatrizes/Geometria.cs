using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace CalculadoraDeMatrizes
{
    class Geometria
    {
        public static void DrawInChart(System.Windows.Forms.DataVisualization.Charting.Chart chart, float[,] matriz, string series)
        {
            chart.Series[series].Points.Clear();
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                chart.Series[series].Points.AddXY(matriz[0, j], matriz[1, j]);
            }
            chart.Series[series].Points.AddXY(matriz[0, 0], matriz[1, 0]);
        }
    }
}
