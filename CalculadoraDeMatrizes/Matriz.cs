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
        /// <summary>
        /// Gera a Matriz com as dimensões escolhidas pelo usuario.
        /// </summary>
        /// <param name="Número de linhas "></param>
        /// <param name="Número de colunas"></param>
        /// <param name="Qual painel será desenhado"></param>
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
                    nu[i, j].Value = 0;
                    nu[i, j].DecimalPlaces = 3;
                    panel.Controls.Add(nu[i, j]);
                }
            }
        }

        /// <summary>
        /// Salva a Matriz contida em um painel num array float[,]
        /// </summary>
        /// <param name="Qual painel está a matriz"></param>
        /// <param name="Número de linhas"></param>
        /// <param name="Número de colunas"></param>
        /// <returns></returns>
        public static float[,] SalvarMatriz(Panel panel,int lines, int col)
        {
            float[,] matrix = new float[lines, col];
            int i = 0;
            int j = 0; 
            foreach (NumericUpDown nu in panel.Controls)
            {               
                matrix[i, j] = (float) nu.Value;
                
                if (j == col-1)
                {
                    j = 0;
                    i++;
                }
                else j++;
            }          
            return matrix;
        }
        /// <summary>
        /// Soma as matrizes de 2 arrays float[,]
        /// </summary>
        /// <param name="Primeira matriz"></param>
        /// <param name="Primeira matriz"></param>
        /// <returns></returns>
       public static float[,] SomarMatrizes(float[,] matrix1,float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
          //  if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
            {
                int lin = matrix1.GetLength(0) ;
                int col = matrix1.GetLength(1) ;
                for (int i = 0; i < lin; i++)
                {
                    for (int j = 0; j<col; j++)
                    {
                       matrixfinal[i, j] = matrix1[i, j] + matrix2[i, j];
                       
                    }
                }
                return matrixfinal;
                
            }           
           
        }
       /// <summary>
       /// Subtrai as matrizes de 2 arrays float[,]
       /// </summary>
       /// <param name="Primeira matriz"></param>
       /// <param name="Primeira matriz"></param>
       /// <returns></returns>
       public static float[,] SubtrairMatrizes(float[,] matrix1, float[,] matrix2)
       {
           float[,] matrixfinal = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
           //  if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
           {
               int lin = matrix1.GetLength(0);
               int col = matrix1.GetLength(1);
               for (int i = 0; i < lin; i++)
               {
                   for (int j = 0; j < col; j++)
                   {
                       matrixfinal[i, j] = matrix1[i, j] - matrix2[i, j];

                   }
               }
               return matrixfinal;

           }

       }
        
        /// <summary>
        /// Desenha a matriz em um painel
        /// </summary>
        /// <param name="Painel a ser desenhado">"Painel "</param>
        /// <param name="matrix"></param>
        /// <param name="Essa matriz poderá sofrer mudança do usuario?"></param>
       public static void DesenhaMatrix(Panel panel, float[,] matrix, bool interactable)
       {
           panel.Controls.Clear();
           int height = 38;
           int width = 70;
           NumericUpDown[,] nu = new NumericUpDown[matrix.GetLength(0), matrix.GetLength(1)];
           for (int i = 0; i < matrix.GetLength(0); i++)
           {
               for (int j = 0; j < matrix.GetLength(1); j++)
               {
                   nu[i, j] = new NumericUpDown();
                   nu[i, j].Font = new Font("Microsoft Sans Serif", 20f);
                   nu[i, j].Size = new Size(width, height);
                   nu[i, j].Location = new Point((width + 5) * j, (height + 5) * i);
                   nu[i, j].Minimum = -9999999999999;
                   nu[i, j].Maximum = 9999999999999;
                   nu[i, j].Value = (decimal)matrix[i,j];
                   nu[i, j].DecimalPlaces = 3;
                   nu[i, j].Enabled = interactable;
                   panel.Controls.Add(nu[i, j]);
               }
           }
       }
          
       
    }
}
    
