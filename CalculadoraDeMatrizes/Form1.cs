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

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown27.Value = numericUpDown1.Value + numericUpDown18.Value;
            numericUpDown26.Value = numericUpDown2.Value + numericUpDown17.Value;
            numericUpDown25.Value = numericUpDown3.Value + numericUpDown16.Value;
            numericUpDown24.Value = numericUpDown4.Value + numericUpDown15.Value;
            numericUpDown23.Value = numericUpDown5.Value + numericUpDown14.Value;
            numericUpDown22.Value = numericUpDown6.Value + numericUpDown13.Value;
            numericUpDown21.Value = numericUpDown7.Value + numericUpDown12.Value;
            numericUpDown20.Value = numericUpDown8.Value + numericUpDown11.Value;
            numericUpDown19.Value = numericUpDown9.Value + numericUpDown10.Value;
        }
    }
}
