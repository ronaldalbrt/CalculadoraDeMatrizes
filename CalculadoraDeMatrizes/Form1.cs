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
            GenerateMatriz((int) line_Matriz1.Value, (int) col_Matriz1.Value);
        }
        void GenerateMatriz(int lines, int col)
        {
            NumericUpDown[,] nu = new NumericUpDown[col,lines];
            for(int i = 0; i < lines; i++)
            {
                for(int j = 0; i < col; i++)
                {
                    nu[i, j] = new NumericUpDown();
                    nu[i, j].Font = new Font("Microsoft Sans Serif", 20f);
                    nu[i, j].Size = new Size(40, 38);
                    nu[i, j].Location = new Point(20 * (i + 1), 20 * (j + 1));
                    groupBox1.Controls.Add(nu[i, j]);
                }
            }
        }

    }
}
