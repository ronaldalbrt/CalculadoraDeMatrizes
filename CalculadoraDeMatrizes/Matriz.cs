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
    static class Matriz
    {
        /// <summary>
        /// Gera a Matriz com as dimensoes escolhidas pelo usuario.
        /// </summary>
        /// <param name="Número de linhas ">Numero de linhas da matriz</param>
        /// <param name="Número de colunas">Numero de colunas da matriz</param>
        /// <param name="Qual painel será desenhado">Painel em que a matriz sera desenhada</param>
        public static void GerarMatrizTextBox(int lines, int col, Panel panel)
        {
            int height = 38;
            int width = 70;
            TextBox[,] nu = new TextBox[lines, col];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    nu[i, j] = new TextBox();
                    nu[i, j].Font = new Font("Microsoft Sans Serif", 20f);
                    nu[i, j].Size = new Size(width, height);
                    nu[i, j].Location = new Point((width + 5) * j, (height + 5) * i);
                    nu[i,j].KeyPress += new System.Windows.Forms.KeyPressEventHandler(NumericTextbox);
                    nu[i, j].Text = "0";
                    panel.Controls.Add(nu[i, j]);
                }
            }
        }           
        /// <summary>
        /// Salva a Matriz contida em um painel num array float[,]
        /// </summary>
        /// <param name="Qual painel está a matriz">Painel em que a matriz preenchida se encontra</param>
        /// <param name="Número de linhas">Numero de linhas da matriz</param>
        /// <param name="Número de colunas">Numero de colunas da matriz</param>
        /// <returns>Retorna um float[,] com os numeros preenchidos nos numericUpDowns da matriz</returns>
        public static float[,] SalvarMatriz(Panel panel, int lines, int col)
        {
            float[,] matrix = new float[lines, col];
            int i = 0;
            int j = 0; 
            foreach (TextBox nu in panel.Controls)
            {
                matrix[i, j] = float.Parse(nu.Text);
                
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
        /// <param name="Primeira matriz">Primeira matriz a ser somada</param>
        /// <param name="Segunda matriz">Segunda matriz a ser somada</param>
        /// <returns>Retorna um float[,] da soma de duas matrizes</returns>
       public static float[,] SomarMatrizes(float[,] matrix1,float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            int lin = matrix1.GetLength(0);
            int col = matrix1.GetLength(1);
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j<col; j++)
                {
                    matrixfinal[i, j] = matrix1[i, j] + matrix2[i, j];    
                }
            }
            return matrixfinal;
        }
        /// <summary>
        /// Subtrai as matrizes de 2 arrays float[,]
        /// </summary>
        /// <param name="Primeira matriz">Primeira matriz a ser subtraida</param>
        /// <param name="Segunda matriz">Segunda matriz a ser subtraida</param>
        /// <returns>Retorna um float[,] da subtração de duas matrizes</returns>
        public static float[,] SubtrairMatrizes(float[,] matrix1, float[,] matrix2)
       {
           float[,] matrixfinal = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
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
        /// <summary>
        /// Multiplica as matrizes de 2 arrays float[,]
        /// </summary>
        /// <param name="Primeira Matriz">Primeira matriz a ser multiplicada</param>
        /// <param name="Segunda Matriz">Segunda matriz a ser multiplicada</param>
        /// <returns>Retorna um float[,] da multiplicação de duas matrizes</returns>
        public static float[,] MultiplicarMatrizes(float[,] matrix1, float[,] matrix2)
       {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix2.GetLength(1)];
            if(matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                throw new MultiplyException();
            }
            for(int i = 0; i < matrix1.GetLength(0); i++)
            {
                for(int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int c = 0; c < matrix1.GetLength(1); c++)
                    {
                        matrixfinal[i, j] += matrix1[i, c] * matrix2[c, j];
                    }
                    if (Math.Round(matrixfinal[i, j]) == 1)
                        matrixfinal[i, j] = 1;
                    else if (Math.Round(matrixfinal[i, j]) == 0)
                    {
                        matrixfinal[i, j] = 0;
                    }
                    else matrixfinal[i, j] = matrixfinal[i, j];
                }
            }
            return matrixfinal;
       }
        /// <summary>
        /// Multiplica a matriz por um numero escalar
        /// </summary>
        /// <param name="matriz">Matriz a ser multiplicada pelo numero</param>
        /// <param name="valor">Numero para multiplicar a matriz</param>
        /// <returns>A matriz multiplicada pelo numero escalar</returns>
       public static float[,] EscalarMatriz(float[,] matriz, float valor)
       {
           float[,] matrixfinal = new float[matriz.GetLength(0), matriz.GetLength(1)];
           int lin = matriz.GetLength(0);
           int col = matriz.GetLength(1);
           for (int i = 0; i < lin; i++)
           {
               for (int j = 0; j < col; j++)
               {
                   matrixfinal[i, j] = matriz[i, j] * valor;
               }
           }
           return matrixfinal;
       }
        /// <summary>
        /// Elevar Matrizes a determinada potencia
        /// </summary>
        /// <param name="matriz">matriz a ser elevada</param>
        /// <param name="exp">potencia que elevará a matriz</param>
        /// <returns>Retorna a matriz elevada</returns>
       public static float[,] ElevarMatriz(float[,] matriz, int exp)
       {
           if(matriz.GetLength(0) != matriz.GetLength(1))
           {
               throw new QuadradaException();
           }
           float[,] result = matriz;
           for(int i = 1; i < exp; i++)
           {
               result = MultiplicarMatrizes(result, matriz);
           }
           return result;
       }
       /// <summary>
       /// Função para gerar a matriz oposta.
       /// A matriz oposta de alguma matriz é ela multiplicada por -1.
       /// </summary>
       /// <param name="matrix1">Matriz que se deseja descobrir a matriz oposta</param>
       /// <returns>Retorna a matriz oposta</returns>
       public static float[,] MatrizOposta(float[,] matrix1)
       {
           float[,] matrixfinal = EscalarMatriz(matrix1, -1);
           return matrixfinal;
       }
       /// <summary>
       /// Função para gerar a matriz transposta.
       /// A matriz transposta é trocar as linhas pelas colunas de determinada matriz.
       /// </summary>
       /// <param name="matrix1">Matriz que se deseja descobrir a matriz transposta</param>
       /// <returns>Retorna a matriz transposta</returns>
       public static float[,] MatrizTransposta(float[,] matrix1)
       {
           float[,] matrixfinal = new float[matrix1.GetLength(1), matrix1.GetLength(0)];
           for (int i = 0; i < matrix1.GetLength(0); i++)
           {
               for(int j = 0; j < matrix1.GetLength(1); j++)
               {
                   matrixfinal[j, i] = matrix1[i, j];
               }
           }
           return matrixfinal;
       }
       /// <summary>
       /// Função para gerar a matriz identidade.
       /// Uma matriz identidade é matriz que possui 1 em todos os elementos de sua diagonal principal e 0 em todos os outros elementos.
       /// </summary>
       /// <param name="line">Número de linhas da matriz identidade</param>
       /// <param name="col">Numero de colunas da matriz identidade</param>
       /// <returns>Retorna a matriz identidade</returns>
       public static float[,] MatrizIdentidade(int line, int col)
       {
           if (line != col)
           {
               throw new QuadradaException();
           }
           float[,] matrixidentidade = new float[line, col];
           for (int i = 0; i < line; i++)
           {
               for (int j = 0; j < col; j++)
               {
                   if (i == j)
                   {
                       matrixidentidade[i, j] = 1;
                   }
                   else
                   {
                       matrixidentidade[i, j] = 0;
                   }
               }
           }
           return matrixidentidade;
       } 
       /// <summary>
       /// Função para descobrir a matriz inversa de determinada matriz.
       /// A matriz inversa é a matriz que multiplicada por determinada matriz resulta na matriz identidade 
       /// </summary>
       /// <param name="matrix1">Matriz que se deseja descobrir a matriz inversa</param>
       /// <returns>Retorna a matriz inversa</returns>
       public static float[,] MatrizInversa(float[,] matrix1)
       {
           if (matrix1.GetLength(0) != matrix1.GetLength(1))
           {
               throw new QuadradaException();
           }
           if (LaPlace(matrix1)==0)
           {
               throw new determinanteException();
           }

           float[,] originalMatrix = matrix1;
           float[,] cofator = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
           float[,] adjunta = new float[matrix1.GetLength(1), matrix1.GetLength(0)];
           float[,] resultado = new float[matrix1.GetLength(1), matrix1.GetLength(0)];

           for(int i = 0; i <= matrix1.GetLength(0); i++)
           {
               for(int j = 0; j <= matrix1.GetLength(1); j++)
               {
                    matrix1 = TrimArray(i, j, originalMatrix);
                    cofator[i, j] =(float)Math.Round( (decimal)Cofator(matrix1, i, j),2);
               }
           }
           adjunta = MatrizTransposta(cofator);
           resultado = EscalarMatriz(adjunta, 1 / LaPlace(originalMatrix));
           return resultado;
       }
       
       /// <summary>
       /// Método por recursividade indireta para se descobrir a determinante de uma matriz
       /// </summary>
       /// <param name="matriz">Matriz para se descobrir a determinante</param>
       /// <returns>Determinante da matriz</returns>
       public static float LaPlace(float[,] matriz)
       {
           float[,] originalMatriz = matriz;
           float result = 0;
           if (matriz.GetLength(0) == 1)
           {
               return matriz[0, 0];
           }
           for (int j = 0; j < originalMatriz.GetLength(1); j++)
           {
               matriz = TrimArray(0, j, originalMatriz);
            
               result += originalMatriz[0, j] * Cofator(matriz, 0, j);
           }
           return result;
       }
       /// <summary>
       /// Método para descobrir o cofator de um elemento da matriz
       /// </summary>
       /// <param name="matriz">Matriz que possui o elemento</param>
       /// <param name="i">Linha do elemento na matriz</param>
       /// <param name="j">Coluna do elemento na matriz</param>
       /// <returns>Retorna o cofator do elemento</returns>
       public static float Cofator(float[,] matriz, int i, int j)
       {
           return (float)Math.Pow(-1, i + j) * LaPlace(matriz);
       } 
        /// <summary>
        /// Desenha a matriz em um painel
        /// </summary>
        /// <param name="Painel a ser desenhado">Painel aonde a matriz será desenhada</param>
        /// <param name="matrix">Matriz a ser desenhada no painel</param>
       public static void DesenhaMatrixText(Panel panel, float[,] matrix)
       {
           panel.Controls.Clear();
           int height = 38;
           int width = 70;
            TextBox[,] nu = new TextBox[matrix.GetLength(0), matrix.GetLength(1)];
           for (int i = 0; i < matrix.GetLength(0); i++)
           {
               for (int j = 0; j < matrix.GetLength(1); j++)
               {
                   nu[i, j] = new TextBox();
                   nu[i, j].Font = new Font("Microsoft Sans Serif", 20f);
                   nu[i, j].Size = new Size(width, height);
                   nu[i, j].Location = new Point((width + 5) * j, (height + 5) * i);
                   nu[i, j].Text = Math.Round((float)matrix[i, j], 2).ToString();                   
                   panel.Controls.Add(nu[i, j]);
               }
           }
       }
       public static float[,] LeiDeFormacao(string lei, int lines, int col)
       {
           char[] expression = lei.ToCharArray();
           float[,] matriz = new float[lines, col];
           char conta = ' ';
           int result = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    foreach (char s in expression)
                    {
                        switch (s)
                        {
                            case ' ':
                                continue;
                            case '+':
                                conta = s;
                                break;
                            case '-':
                                conta = s;
                                break;
                            case '*':
                                conta = s;
                                break;
                            case '/':
                                conta = s;
                                break;
                            case 'i':
                                if (result == 0)
                                {
                                    result = i + 1;
                                }
                                else
                                {
                                    switch(conta)
                                    {
                                        case '+':
                                            result += i + 1;
                                            break;
                                        case '-':
                                            result -= i + 1;
                                            break;
                                        case '*':
                                            result *= i + 1;
                                            break;
                                        case '/':
                                            result /= i + 1;
                                            break;
                                    }
                                }
                                break;
                            case 'j':
                                if (result == 0)
                                {
                                    result = j + 1;
                                }
                                else
                                {
                                    switch (conta)
                                    {
                                        case '+':
                                            result += j + 1;
                                            break;
                                        case '-':
                                            result -= j + 1;
                                            break;
                                        case '*':
                                            result *= j + 1;
                                            break;
                                        case '/':
                                            result /= j + 1;
                                            break;
                                    }
                                }
                                break;
                            default:
                                if (result == 0)
                                {
                                    result = int.Parse(s.ToString());
                                }
                                else
                                {
                                    switch (conta)
                                    {
                                        case '+':
                                            result += int.Parse(s.ToString());
                                            break;
                                        case '-':
                                            result -= int.Parse(s.ToString());
                                            break;
                                        case '*':
                                            result *= int.Parse(s.ToString());
                                            break;
                                        case '/':
                                            result /= int.Parse(s.ToString());
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                    matriz[i, j] = result;
                    result = 0;
                }
            }
            return matriz;
       }
        /// <summary>
        /// Funcão para a TextBox não mostrar letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void NumericTextbox(object sender, KeyPressEventArgs e)
       {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ',' && e.KeyChar != '-'))
           {
               e.Handled = true;
           }

           // only allow one decimal point
           if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
           {
               e.Handled = true;
           }
       }
       public static void LeiDeFormacao(string lei )
        {
           
        }
        public static float[,] TrimArray(int rowToRemove, int columnToRemove, float[,] originalArray)
        {
            float[,] result = new float[originalArray.GetLength(0) - 1, originalArray.GetLength(1) - 1];

            for (int i = 0, j = 0; i < originalArray.GetLength(0); i++)
            {
                if (i == rowToRemove)
                    continue;

                for (int k = 0, u = 0; k < originalArray.GetLength(1); k++)
                {
                    if (k == columnToRemove)
                        continue;

                    result[j, u] = originalArray[i, k];
                    u++;
                }
                j++;
            }

            return result;
        }
      

    }

    
    
   
}
    
