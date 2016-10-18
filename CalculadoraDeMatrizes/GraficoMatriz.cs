using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeMatrizes
{
    public partial class GraficoMatriz : Form
    {
        public GraficoMatriz(float[,] matriz,string title)
        {
            InitializeComponent();
            Geometria.DrawInChart(grafico, matriz, "Matriz");
            grafico.Titles[0].Text += title;
        }
    }
}
