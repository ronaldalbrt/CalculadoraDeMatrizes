using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;

namespace CalculadoraDeMatrizes
{
    static class Matriz
    {
        public static void GerarMatriz(int lines, int col, Panel panel)
        {
            int height = 38;
            int width = 70;
            NumericUpDown[,] nu = new NumericUpDown[lines, col];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    nu[i, j] = new NumericUpDown();
                    nu[i, j].Font = new Font("Microsoft Sans Serif", 20f);
                    nu[i, j].Size = new Size(width, height);
                    nu[i, j].Location = new Point((width + 5) * j, (height + 5) * i);
                    nu[i, j].Minimum = -9999999999999;
                    nu[i, j].Maximum = 9999999999999;
                    nu[i, j].DecimalPlaces = 3;
                    panel.Controls.Add(nu[i, j]);
                }
            }
        }
        public static void SomarMatrizes(Panel panel1, Panel panel2, int lines1, int col1, int lines2, int col2)
        {
            int i1 = 0;
            int j1 = 0;
            float[,] matriz = new float[lines1, col1];
            foreach(NumericUpDown nu  in panel1.Controls)
            {
                Console.WriteLine(i1 + " " + j1);
                matriz[i1, j1] = (float) nu.Value;
                if (j1 < col1 - 1)
                {
                    i1++;
                    j1 = 0;
                }
                else
                {
                    j1++;
                }
            }
            //Console.WriteLine("Linhas: " + i1 + " Colunas:" + j1);
            /*for(int i = 0; i < lines1; i++)
            {
                for(int j = 0; j < col1; j++)
                {
                      matriz[i, j] = panel1.Controls.GetType(,);
                }
            }*/
        }
    }
}
