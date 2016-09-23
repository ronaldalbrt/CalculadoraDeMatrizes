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
            MessageBox.Show("Essa é a calculadora de matrizes!! Seja Bem Vindo!!");
        }

        private void btn_GerarMatriz1_Click(object sender, EventArgs e)
        {
            line1 = (int) line_Matriz1.Value;
            col1 = (int) col_Matriz1.Value;
            panel1.Controls.Clear();
            //Matriz.GerarMatriz(line1, col1, panel1);
            Matriz.GerarMatrizTextBox(line1, col1, panel1);
        }

        private void btn_GerarMatriz2_Click(object sender, EventArgs e)
        {
            line2 = (int)line_Matriz2.Value;
            col2 = (int)col_Matriz2.Value;
            panel2.Controls.Clear();
           Matriz.GerarMatrizTextBox(line2, col2, panel2);
            
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {

            float[,] matriz1 = new float[line1, col1];
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col2];
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);

            try
            {
                resultado = Matriz.SomarMatrizes(matriz1, matriz2);
                Matriz.DesenhaMatrixText(resultPanel, resultado);
            }
            catch
            {
                MessageBox.Show("O número de linhas e colunas das matrizes não são iguais");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[line1, col1];
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col2];
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            try
            {
                resultado = Matriz.SubtrairMatrizes(matriz1, matriz2);
                Matriz.DesenhaMatrixText(resultPanel, resultado);
                Matriz.DesenhaMatrixText(resultPanel, resultado);
            }
            catch
            {
                MessageBox.Show("O número de linhas e colunas das matrizes não são iguais");
            }
        }

        private void btnMultiplicarEscalar_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[line1, col1];
            float[,] resultado = new float[line1, col1];
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            resultado = Matriz.EscalarMatriz(matriz1, (float)NuEscalar1.Value);
            Matriz.DesenhaMatrixText(panel1, resultado);
        }

        private void btnMultiplicarEscalar2_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col2];
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            resultado = Matriz.EscalarMatriz(matriz2, (float)NuEscalar2.Value);
            Matriz.DesenhaMatrixText(panel2, resultado);
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[line1, col1];
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col1];
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            try
            {
                resultado = Matriz.MultiplicarMatrizes(matriz1, matriz2);           
                Matriz.DesenhaMatrixText(resultPanel, resultado);
            }
            catch (MultiplyException ex)
            {
                MessageBox.Show("O numero de colunas da matriz 1 é diferente do numero de linhas da matriz 2");
            }
        }

        private void btnGerarOposta_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[line1, col1];
            float[,] resultado = new float[line1, col1];
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            resultado = Matriz.MatrizOposta(matriz1);
            Matriz.DesenhaMatrixText(panel1, resultado);
        }
        private void btnGerarOposta2_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col2];
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            resultado = Matriz.MatrizOposta(matriz2);
            Matriz.DesenhaMatrixText(panel2, resultado);
        }
        private void btnGerarTransposta_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[line1, col1];
            float[,] resultado = new float[col1, line1];
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            resultado = Matriz.MatrizTransposta(matriz1);
            Matriz.DesenhaMatrixText(panel1, resultado);
            line1 = resultado.GetLength(0);
            col1 = resultado.GetLength(1);
        }
        private void btnGerarTransposta2_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[col2, line2];
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            resultado = Matriz.MatrizTransposta(matriz2);
            Matriz.DesenhaMatrixText(panel2, resultado);
            line2 = resultado.GetLength(0);
            col2 = resultado.GetLength(1);
        }
        private void btnIdentidade_Click(object sender, EventArgs e)
        {
            line1 = (int)line_Matriz1.Value;
            col1 = (int)col_Matriz1.Value;
            try
            {
                float[,] matrizIdentidade = Matriz.MatrizIdentidade(line1, col1);
                Matriz.DesenhaMatrixText(panel1, matrizIdentidade);
            }
            catch(QuadradaException ex)
            {
                MessageBox.Show("Para gerar uma matriz identidade é necessário que ela tenha o mesmo número de linhas e colunas");
            }
        }
        private void btnGerarIdentidade2_Click(object sender, EventArgs e)
        {
            line2 = (int)line_Matriz2.Value;
            col2 = (int)col_Matriz2.Value;
            try
            {
                float[,] matrizIdentidade = Matriz.MatrizIdentidade(line2, col2);
                Matriz.DesenhaMatrixText(panel2, matrizIdentidade);
            }
            catch(QuadradaException ex)
            {
                MessageBox.Show("Para gerar uma matriz identidade é necessário que ela tenha o mesmo número de linhas e colunas");
            }
        }

        private void btnGerarInversa_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            try
            {
                float[,] resultado = Matriz.MatrizInversa(matriz1);
                Matriz.DesenhaMatrixText(panel1, resultado);
            }
            catch(QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para gerar sua inversa");
            }
        }
    }
}
