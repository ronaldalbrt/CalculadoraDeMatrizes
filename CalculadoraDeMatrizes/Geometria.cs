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
using System.Drawing.Drawing2D;
namespace CalculadoraDeMatrizes
{
   
    class Geometria
    {
        public static float[,] SimetriaX  = new float [2,2] {{1,0},{0,-1}};
        public static float[,] SimetriaY  = new float [2,2] {{-1,0},{0,1}};

        public static void DrawInChart(System.Windows.Forms.DataVisualization.Charting.Chart chart, float[,] matriz, string series)
        {
            chart.Series[series].Points.Clear();
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                chart.Series[series].Points.AddXY(matriz[0, j], matriz[1, j]);
            }
            chart.Series[series].Points.AddXY(matriz[0, 0], matriz[1, 0]);
           
        }
       
        public static float [,] Rotaçao (float angulo )
        {
            float[,] result = new float[2, 2] { { (float)Math.Cos((double)angulo), (float)-Math.Sin((double)angulo) }, { (float)Math.Sin((double)angulo), (float)Math.Cos((double)angulo) } };
            
            return result; 
        }
        public static float [,] Escalar (float value)
        {
            float[,] result = new float[2, 2] { { value, 0 }, { 0, value } };
            return result;
        }
        public static float  Translaçao (float value)
        {
            return value;

        }

       
    }
}
