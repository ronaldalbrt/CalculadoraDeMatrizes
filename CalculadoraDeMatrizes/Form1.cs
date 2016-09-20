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
            groupBox1.Controls.Clear();
            Matriz.GenerateMatriz((int) line_Matriz1.Value, (int) col_Matriz1.Value, groupBox1);
        }

        private void btn_GerarMatriz2_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            Matriz.GenerateMatriz((int)line_Matriz2.Value, (int)col_Matriz2.Value, groupBox2);
        }
    }
}
