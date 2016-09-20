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
            Matriz.SomarMatrizes(panel1, panel2, line1, col1, line2, col2);
        }
    }
}
