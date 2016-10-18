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
        float[,] matrizinitial = new float[2,2];
        float [,] matrizfinal = new float[2,2];
        static bool startanimation;
        static float lerp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Você esta prestes a experienciar a melhor experiência que você pode ter em toda a sua vida, NÃO DESPERDICE ESSA CHANCE, essa calculadora pode gerar dependencia química, física e mental, além de causar deficiencias aos não dignos de usa-la, aproveite com moderação", "CALCULADORA DE MATRIZES SUPER MEGA ULTRA MASTER BLASTER CALCULATOR INCRÍVEL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                Geometria.DrawInChart(grafico, matriz, "Matriz");
            }
            catch(NoMatrixException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
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
            try{
            float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
            float[,] initialmatriz = matriz;
            matriz = Matriz.MultiplicarMatrizes(Geometria.SimetriaX, matriz);
            matrizinitial = initialmatriz;
            matrizfinal = matriz;
            startanimation = true;
            //Geometria.DrawInChart(grafico, matriz, "Matriz");
            Matriz.DesenhaMatrixText(Geometrypanel, matriz);
            }
            catch (NoMatrixException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MultiplyException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void simetriay_Click(object sender, EventArgs e)
        {
            try
            {
                float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
                float[,] initialmatriz = matriz;
                matriz = Matriz.MultiplicarMatrizes(Geometria.SimetriaY, matriz);
                matrizinitial = initialmatriz;
                matrizfinal = matriz;
                startanimation = true;
                // Geometria.DrawInChart(grafico, matriz, "Matriz");
                Matriz.DesenhaMatrixText(Geometrypanel, matriz);
            }
            catch (NoMatrixException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MultiplyException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rotatebt_Click(object sender, EventArgs e)
        {
            try
            {
                float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
                float[,] initialmatriz = matriz;
                matriz = Matriz.MultiplicarMatrizes(Geometria.Rotaçao(float.Parse(rotacionarbox.Text)), matriz);
              
                matrizinitial = initialmatriz;
                matrizfinal = matriz;
                startanimation = true;
                // Geometria.DrawInChart(grafico, matriz, "Matriz");
                Matriz.DesenhaMatrixText(Geometrypanel, matriz);
            }
            catch (NoMatrixException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MultiplyException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void translacaox2_Click(object sender, EventArgs e)
        {
            try
            {
                float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
                float[,] initialmatriz = matriz;
                if (matriz.GetLength(0)*matriz.GetLength(1)<6)
                {
                    throw new NoMatrixException();
                }
                matriz = Matriz.SomarMatriz(matriz, float.Parse(transalaçaoxbox.Text), 0);
                matrizinitial = initialmatriz;
                matrizfinal = matriz;
                startanimation = true;
                Matriz.DesenhaMatrixText(Geometrypanel, matriz);
            }
            catch (NoMatrixException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MultiplyException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
          private void translacaoy2_Click(object sender, EventArgs e)
        {
            try
            {
                float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
                float[,] initialmatriz = matriz;
                matriz = Matriz.SomarMatriz(matriz, 0, float.Parse(translaçaoybox.Text));
                if (matriz.GetLength(0) * matriz.GetLength(1) < 6)
                {
                    throw new NoMatrixException();
                }
                //Geometria.DrawInChart(grafico, matriz, "Matriz");
                matrizinitial = initialmatriz;
                matrizfinal = matriz;
                startanimation = true;
                Matriz.DesenhaMatrixText(Geometrypanel, matriz);
            }
            catch (NoMatrixException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MultiplyException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void escalar_Click(object sender, EventArgs e)
        {
            try
            {
                float[,] matriz = Matriz.SalvarMatriz(Geometrypanel, geometryLine, geometryCol);
                float[,] initialmatriz = matriz;
                matriz = Matriz.MultiplicarMatrizes(Geometria.Escalar(float.Parse(escalarbox.Text)), matriz);
                //Geometria.DrawInChart(grafico, matriz, "Matriz");
                matrizinitial = initialmatriz;
                matrizfinal = matriz;
                startanimation = true;
                Matriz.DesenhaMatrixText(Geometrypanel, matriz);
            }
            catch (NoMatrixException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MultiplyException ex)
            {
                MessageBox.Show("Entre uma matriz para gerar a forma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
         private bool animation (float[,] matrizinitial,float [,]matrizfinal, float lerp)
        {
             
                if (lerp>1.05f)
                {                   
                    return false;                    
                }
                else{
                  Geometria.DrawInChart(grafico, Geometria.AnimarMatrizes(matrizinitial, matrizfinal, lerp), "Matriz");
                return true; 
                }
         }

        
        private void Timer_Tick(object sender, EventArgs e)
        {
           if (startanimation)
           {
               if (!animation(matrizinitial, matrizfinal, lerp))
               {
                   startanimation = false;
                   lerp = 0;
               }
               else
               { lerp+= 0.05f;
                  
               }
           }
              
        }       

       

        private void btnFormulaGerarMatriz2_Click(object sender, EventArgs e)
        {
            line2 = (int)line_Matriz2.Value;
            col2 = (int)col_Matriz2.Value;
            try
            {
                float[,] matrix = Matriz.LeiDeFormacao(formulaGerarMatriz2.Text, line2, col2);
                Matriz.DesenhaMatrixText(panel2, matrix);
            }
            catch
            {
                MessageBox.Show("Entre uma lei de formação valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(panel1, line1, col1);
            if (matriz.GetLength(0) == 2)
            {
                try
                {
                    GraficoMatriz chart = new GraficoMatriz(matriz," 1");
                    chart.Visible = true;
                }
                catch( NoMatrixException ex)
                {
                    MessageBox.Show("É necessario no mínimo tres pontos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("É necessario duas colunas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
         }

        private void button2_Click_1(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(panel2, line2, col2);
            if (matriz.GetLength(0) == 2)
            {
                try
                {
                    GraficoMatriz chart = new GraficoMatriz(matriz," 2");
                    chart.Visible = true;
                }
                catch (NoMatrixException ex)
                {
                    MessageBox.Show("É necessario no mínimo tres pontos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("É necessario duas colunas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float[,] matriz = Matriz.SalvarMatriz(resultPanel, line3, col3);
            if (matriz.GetLength(0) == 2)
            {
                try
                {
                    GraficoMatriz chart = new GraficoMatriz(matriz," Resultante");
                    chart.Visible = true;
                }
                catch (NoMatrixException ex)
                {
                    MessageBox.Show("É necessario no mínimo tres pontos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("É necessario duas colunas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

                
        } 
    }

