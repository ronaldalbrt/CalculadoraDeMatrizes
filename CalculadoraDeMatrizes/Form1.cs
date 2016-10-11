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
        static int line1, col1, line2, col2, line3, col3, geometryCol, geometryLine;
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

        private void GerarMatriz3(float[,] result)
        {
            line3 = result.GetLength(0);
            col3 = result.GetLength(1);
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[line1, col1];
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col2];
            GerarMatriz3(resultado);
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                try
                {
                    resultado = Matriz.SomarMatrizes(matriz1, matriz2);
                    Matriz.DesenhaMatrixText(resultPanel, resultado);
                }
                catch
                {
                    MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[line1, col1];
            float[,] matriz2 = new float[line2, col2];
            float[,] resultado = new float[line2, col2];
            GerarMatriz3(resultado);
            matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1)) { 
            try
            {
                resultado = Matriz.SubtrairMatrizes(matriz1, matriz2);
                Matriz.DesenhaMatrixText(resultPanel, resultado);
                Matriz.DesenhaMatrixText(resultPanel, resultado);
            }
            catch
            {
                MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            else MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void multiplicarPanel3_Click(object sender, EventArgs e)
        {
            float[,] matriz3 = new float[line3, col3];
            float[,] resultado = new float[line3, col3];
            matriz3 = Matriz.SalvarMatriz(resultPanel, line3, col3);
            resultado = Matriz.EscalarMatriz(matriz3, (float)NuEscalar3.Value);
            Matriz.DesenhaMatrixText(resultPanel, resultado);
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
                GerarMatriz3(resultado);
                Matriz.DesenhaMatrixText(resultPanel, resultado);
            }
            catch (MultiplyException ex)
            {
                MessageBox.Show("O numero de colunas da matriz 1 é diferente do numero de linhas da matriz 2", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnGerarOposta3_Click(object sender, EventArgs e)
        {
            float[,] matriz3 = new float[line3, col3];
            float[,] resultado = new float[line3, col3];
            matriz3 = Matriz.SalvarMatriz(resultPanel, line3, col3);
            resultado = Matriz.MatrizOposta(matriz3);
            Matriz.DesenhaMatrixText(resultPanel, resultado);
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
        private void btnGerarTransposta3_Click(object sender, EventArgs e)
        {
            float[,] matriz3 = new float[line3, col3];
            float[,] resultado = new float[col3, line3];
            matriz3 = Matriz.SalvarMatriz(resultPanel, line3, col3);
            resultado = Matriz.MatrizTransposta(matriz3);
            Matriz.DesenhaMatrixText(resultPanel, resultado);
            line3 = resultado.GetLength(0);
            col3 = resultado.GetLength(1);
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
                MessageBox.Show("Para gerar uma matriz identidade é necessário que ela tenha o mesmo número de linhas e colunas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Para gerar uma matriz identidade é necessário que ela tenha o mesmo número de linhas e colunas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGerarIdentidade3_Click(object sender, EventArgs e)
        {
            try
            {
                float[,] matrizIdentidade = Matriz.MatrizIdentidade(line3, col3);
                Matriz.DesenhaMatrixText(resultPanel, matrizIdentidade);
            }
            catch (QuadradaException ex)
            {
                MessageBox.Show("Para gerar uma matriz identidade é necessário que ela tenha o mesmo número de linhas e colunas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("A matriz precisa ser quadrada para gerar sua inversa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(determinanteException ex)
            {
                MessageBox.Show("O determinante dessa matriz é 0 sendo assim não há matriz inversa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarInversa2_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            try
            {
                float[,] resultado = Matriz.MatrizInversa(matriz2);
                Matriz.DesenhaMatrixText(panel2, resultado);
            }
            catch (QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para gerar sua inversa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (determinanteException ex)
            {
                MessageBox.Show("O determinante dessa matriz é 0 sendo assim não há matriz inversa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElevarPanel_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            try
            {
                float[,] resultado = Matriz.ElevarMatriz(matriz1, (int) NuEscalar1.Value);
                Matriz.DesenhaMatrixText(panel1, resultado);
            }
            catch(QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para ser elevada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeterminante_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = Matriz.SalvarMatriz(panel1, line1, col1);
            try
            {
               float resultado = Matriz.LaPlace(matriz1);
               MessageBox.Show("A determinante é "+resultado,"Determinante",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para gerar o determinante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeterminante2_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            try
            {
                float resultado = Matriz.LaPlace(matriz2);
                MessageBox.Show("A determinante é " + resultado, "Determinante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para gerar o determinante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElevarPanel2_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = Matriz.SalvarMatriz(panel2, line2, col2);
            try
            {
                float[,] resultado = Matriz.ElevarMatriz(matriz2, (int)NuEscalar2.Value);
                Matriz.DesenhaMatrixText(panel2, resultado);
            }
            catch (QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para ser elevada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarInversa3_Click(object sender, EventArgs e)
        {
            float[,] matriz3 = Matriz.SalvarMatriz(resultPanel, line3, col3);
            try
            {
                float[,] resultado = Matriz.MatrizInversa(matriz3);
                Matriz.DesenhaMatrixText(resultPanel, resultado);
            }
            catch (QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para gerar sua inversa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             catch(determinanteException ex)
            {
                MessageBox.Show("O determinante dessa matriz é 0 sendo assim não há matriz inversa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElevarPanel3_Click(object sender, EventArgs e)
        {
            float[,] matriz3 = Matriz.SalvarMatriz(resultPanel, line3, col3);
            try
            {
                float[,] resultado = Matriz.ElevarMatriz(matriz3, (int)NuEscalar3.Value);
                Matriz.DesenhaMatrixText(resultPanel, resultado);
            }
            catch (QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para ser elevada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFormulaGerarMatriz1_Click(object sender, EventArgs e)
        {
            line1 = (int)line_Matriz1.Value;
            col1 = (int)col_Matriz1.Value;
            try
            {
                float[,] matrix =  Matriz.LeiDeFormacao(formulaGerarMatriz1.Text, line1, col1);
                Matriz.DesenhaMatrixText(panel1, matrix);
            }
            catch
            {
                MessageBox.Show("Entre uma lei de formação valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geometrypanel.Controls.Clear();
            Matriz.GerarMatrizTextBox((int)LinesGeo.Value, (int)CollGeo.Value, Geometrypanel);
            geometryCol = (int) CollGeo.Value;
            geometryLine = (int)LinesGeo.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
            Geometria.DrawInChart(grafico, matriz, "Matriz");
           
        }
        public void leideformaçaotextbox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != ',' && e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != 'i' && e.KeyChar != 'j' && e.KeyChar != '^' && e.KeyChar != ' '))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        public  void NumericTextbox(object sender, KeyPressEventArgs e)
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

        private void simetriax_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
            matriz = Matriz.MultiplicarMatrizes(Geometria.SimetriaX, matriz);
            Geometria.DrawInChart(grafico, matriz, "Matriz");
            Matriz.DesenhaMatrixText(Geometrypanel, matriz);

        }

        private void simetriay_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
            matriz = Matriz.MultiplicarMatrizes(Geometria.SimetriaY, matriz);
            Geometria.DrawInChart(grafico, matriz, "Matriz");
            Matriz.DesenhaMatrixText(Geometrypanel, matriz);
        }

        private void rotatebt_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
            matriz = Matriz.MultiplicarMatrizes(Geometria.Rotaçao(float.Parse(rotacionarbox.Text)), matriz);
            Geometria.DrawInChart(grafico, matriz, "Matriz");
            Matriz.DesenhaMatrixText(Geometrypanel, matriz);
        }

        private void translacaox_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
            matriz = Matriz.SomarMatriz(matriz, float.Parse(transalaçaoxbox.Text), 0);
            Geometria.DrawInChart(grafico, matriz, "Matriz");
            Matriz.DesenhaMatrixText(Geometrypanel, matriz);
        }

        private void translacaoy_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
            matriz = Matriz.SomarMatriz(matriz, 0, float.Parse(translaçaoybox.Text));
            Geometria.DrawInChart(grafico, matriz, "Matriz");
            Matriz.DesenhaMatrixText(Geometrypanel, matriz);
        }

        private void escalar_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
            matriz = Matriz.MultiplicarMatrizes(Geometria.Escalar(float.Parse(escalarbox.Text)),matriz);
            Geometria.DrawInChart(grafico, matriz, "Matriz");
            Matriz.DesenhaMatrixText(Geometrypanel,matriz);
        }

        private void btnChecarSimetria1_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(panel1, line1, col1);
            if(Matriz.ChecarSimetria(matriz))
            {
                MessageBox.Show("Essa matriz é simetrica", "Simetria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Essa matriz não é simetrica", "Simetria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChecarSimetria2_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(panel2, line2, col2);
            if (Matriz.ChecarSimetria(matriz))
            {
                MessageBox.Show("Essa matriz é simetrica", "Simetria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Essa matriz não é simetrica", "Simetria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        private void btnDeterminante3_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(resultPanel, line3, col3);
            try
            {
                float resultado = Matriz.LaPlace(matriz);
                MessageBox.Show("A determinante é " + resultado, "Determinante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para gerar o determinante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChecarSimetria3_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(resultPanel, line3, col3);
            if (Matriz.ChecarSimetria(matriz))
            {
                MessageBox.Show("Essa matriz é simetrica", "Simetria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Essa matriz não é simetrica", "Simetria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
    }
}
