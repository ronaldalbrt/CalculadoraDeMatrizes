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
    public partial class Form1 : Form
    {
        static int line1, col1, line2, col2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show("Essa é a calculadora de matrizes!! Seja Bem Vindo!!");
        }

        private void btn_GerarMatriz1_Click(object sender, EventArgs e)
        {
            line1 = (int) line_Matriz1.Value;
            col1 = (int) col_Matriz1.Value;
            panel1.Controls.Clear();
            Matriz.GerarMatriz(line1, col1, panel1);
        }

        private void btn_GerarMatriz2_Click(object sender, EventArgs e)
        {
            line2 = (int)line_Matriz2.Value;
            col2 = (int)col_Matriz2.Value;
            panel2.Controls.Clear();
            Matriz.GerarMatriz(line2, col2, panel2);
           // Console.WriteLine(Matriz.SalvarMatriz(panel1, line1, col1));
           // Matriz.SomarMatrizes(panel1, panel2, line1, col1, line2, col2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[line1, col1];
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col2];
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            
            try
            {
                resultado = Matriz.SomarMatrizes(matriz1, matriz2);
            }
            catch {
                MessageBox.Show("O número de linhas e colunas das matrizes não são iguais");
            }
            Matriz.DesenhaMatrix(resultPanel, resultado, true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            float[,] matriz1 = new float[line1, col1];
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col2];
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);

            try
            {
                resultado = Matriz.SubtrairMatrizes(matriz1, matriz2);
                Matriz.DesenhaMatrix(resultPanel, resultado, true);
            }
            catch
            {
                MessageBox.Show("O número de linhas e colunas das matrizes não são iguais");
            }
            
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[line1, col1];
            float[,] resultado = new float[line1, col1];
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            resultado = Matriz.EscalarMatriz(matriz1, (float)NuEscalar1.Value);
            Matriz.DesenhaMatrix(panel1, resultado, true);
        }

        private void multiplicarPanel2_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col2];
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            resultado = Matriz.EscalarMatriz(matriz2, (float)NuEscalar2.Value);
            Matriz.DesenhaMatrix(panel2, resultado, true);

        }

      
    }
}
