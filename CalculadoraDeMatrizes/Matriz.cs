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
        public static void GenerateMatriz(int lines, int col, GroupBox groupBox)
        {
            NumericUpDown[,] nu = new NumericUpDown[lines, col];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    nu[i, j] = new NumericUpDown();
                    nu[i, j].Font = new Font("Microsoft Sans Serif", 20f);
                    nu[i, j].Size = new Size(40, 38);
                    nu[i, j].Location = new Point(50 * i, 50 * j);
                    groupBox.Controls.Add(nu[i, j]);
                }
            }
        }
    }
}
