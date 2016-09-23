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
            Console.WriteLine(float.Parse("3,3") + float.Parse("3,3"));
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
                MessageBox.Show("O numero de colunas da matriz 1 é diferente do numero de linahs da matriz 2");
            }
        }
        
      

        

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        

       

        
    }
}
