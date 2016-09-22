namespace CalculadoraDeMatrizes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NuEscalar2 = new System.Windows.Forms.NumericUpDown();
            this.multiplicarPanel2 = new System.Windows.Forms.Button();
            this.NuEscalar1 = new System.Windows.Forms.NumericUpDown();
            this.multiplicarPanel1 = new System.Windows.Forms.Button();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.SubtrairButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.btnSomar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_GerarMatriz2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.col_Matriz2 = new System.Windows.Forms.NumericUpDown();
            this.line_Matriz2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GerarMatriz1 = new System.Windows.Forms.Button();
            this.col_Matriz1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.line_Matriz1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuEscalar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuEscalar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.col_Matriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_Matriz2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.col_Matriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_Matriz1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1360, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NuEscalar2);
            this.tabPage1.Controls.Add(this.multiplicarPanel2);
            this.tabPage1.Controls.Add(this.NuEscalar1);
            this.tabPage1.Controls.Add(this.multiplicarPanel1);
            this.tabPage1.Controls.Add(this.MultiplicarButton);
            this.tabPage1.Controls.Add(this.SubtrairButton);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnSomar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btn_GerarMatriz2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.col_Matriz2);
            this.tabPage1.Controls.Add(this.line_Matriz2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_GerarMatriz1);
            this.tabPage1.Controls.Add(this.col_Matriz1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.line_Matriz1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1352, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matriz 1";
            // 
            // NuEscalar2
            // 
            this.NuEscalar2.Location = new System.Drawing.Point(629, 453);
            this.NuEscalar2.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NuEscalar2.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.NuEscalar2.Name = "NuEscalar2";
            this.NuEscalar2.Size = new System.Drawing.Size(58, 20);
            this.NuEscalar2.TabIndex = 18;
            // 
            // multiplicarPanel2
            // 
            this.multiplicarPanel2.Location = new System.Drawing.Point(623, 487);
            this.multiplicarPanel2.Name = "multiplicarPanel2";
            this.multiplicarPanel2.Size = new System.Drawing.Size(75, 23);
            this.multiplicarPanel2.TabIndex = 17;
            this.multiplicarPanel2.Text = "Multiplicar";
            this.multiplicarPanel2.UseVisualStyleBackColor = true;
            this.multiplicarPanel2.Click += new System.EventHandler(this.btnMultiplicarEscalar2_Click);
            // 
            // NuEscalar1
            // 
            this.NuEscalar1.Location = new System.Drawing.Point(71, 453);
            this.NuEscalar1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NuEscalar1.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.NuEscalar1.Name = "NuEscalar1";
            this.NuEscalar1.Size = new System.Drawing.Size(58, 20);
            this.NuEscalar1.TabIndex = 16;
            // 
            // multiplicarPanel1
            // 
            this.multiplicarPanel1.Location = new System.Drawing.Point(65, 487);
            this.multiplicarPanel1.Name = "multiplicarPanel1";
            this.multiplicarPanel1.Size = new System.Drawing.Size(75, 23);
            this.multiplicarPanel1.TabIndex = 15;
            this.multiplicarPanel1.Text = "Multiplicar";
            this.multiplicarPanel1.UseVisualStyleBackColor = true;
            this.multiplicarPanel1.Click += new System.EventHandler(this.btnMultiplicarEscalar_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Location = new System.Drawing.Point(379, 195);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplicarButton.TabIndex = 14;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            this.MultiplicarButton.Click += new System.EventHandler(this.MultiplicarButton_Click);
            // 
            // SubtrairButton
            // 
            this.SubtrairButton.Location = new System.Drawing.Point(379, 156);
            this.SubtrairButton.Name = "SubtrairButton";
            this.SubtrairButton.Size = new System.Drawing.Size(75, 23);
            this.SubtrairButton.TabIndex = 13;
            this.SubtrairButton.Text = "Subtrair";
            this.SubtrairButton.UseVisualStyleBackColor = true;
            this.SubtrairButton.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultPanel);
            this.groupBox3.Location = new System.Drawing.Point(921, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 366);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // resultPanel
            // 
            this.resultPanel.AutoScroll = true;
            this.resultPanel.Location = new System.Drawing.Point(3, 16);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(356, 347);
            this.resultPanel.TabIndex = 11;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(379, 114);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 9;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(461, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 366);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz 2";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 347);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(514, 233);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 9;
            // 
            // btn_GerarMatriz2
            // 
            this.btn_GerarMatriz2.Location = new System.Drawing.Point(601, 50);
            this.btn_GerarMatriz2.Name = "btn_GerarMatriz2";
            this.btn_GerarMatriz2.Size = new System.Drawing.Size(97, 28);
            this.btn_GerarMatriz2.TabIndex = 8;
            this.btn_GerarMatriz2.Text = "Gerar Matriz 2";
            this.btn_GerarMatriz2.UseVisualStyleBackColor = true;
            this.btn_GerarMatriz2.Click += new System.EventHandler(this.btn_GerarMatriz2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // col_Matriz2
            // 
            this.col_Matriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_Matriz2.Location = new System.Drawing.Point(668, 6);
            this.col_Matriz2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.col_Matriz2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.col_Matriz2.Name = "col_Matriz2";
            this.col_Matriz2.Size = new System.Drawing.Size(59, 38);
            this.col_Matriz2.TabIndex = 6;
            this.col_Matriz2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // line_Matriz2
            // 
            this.line_Matriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line_Matriz2.Location = new System.Drawing.Point(577, 6);
            this.line_Matriz2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.line_Matriz2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.line_Matriz2.Name = "line_Matriz2";
            this.line_Matriz2.Size = new System.Drawing.Size(56, 38);
            this.line_Matriz2.TabIndex = 5;
            this.line_Matriz2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(9, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 366);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz 1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 347);
            this.panel1.TabIndex = 0;
            // 
            // btn_GerarMatriz1
            // 
            this.btn_GerarMatriz1.Location = new System.Drawing.Point(113, 50);
            this.btn_GerarMatriz1.Name = "btn_GerarMatriz1";
            this.btn_GerarMatriz1.Size = new System.Drawing.Size(97, 28);
            this.btn_GerarMatriz1.TabIndex = 3;
            this.btn_GerarMatriz1.Text = "Gerar Matriz 1";
            this.btn_GerarMatriz1.UseVisualStyleBackColor = true;
            this.btn_GerarMatriz1.Click += new System.EventHandler(this.btn_GerarMatriz1_Click);
            // 
            // col_Matriz1
            // 
            this.col_Matriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_Matriz1.Location = new System.Drawing.Point(175, 3);
            this.col_Matriz1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.col_Matriz1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.col_Matriz1.Name = "col_Matriz1";
            this.col_Matriz1.Size = new System.Drawing.Size(57, 38);
            this.col_Matriz1.TabIndex = 2;
            this.col_Matriz1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            // 
            // line_Matriz1
            // 
            this.line_Matriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line_Matriz1.Location = new System.Drawing.Point(85, 4);
            this.line_Matriz1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.line_Matriz1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.line_Matriz1.Name = "line_Matriz1";
            this.line_Matriz1.Size = new System.Drawing.Size(55, 38);
            this.line_Matriz1.TabIndex = 0;
            this.line_Matriz1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1352, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1344, 627);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de Matrizes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuEscalar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuEscalar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.col_Matriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_Matriz2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.col_Matriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_Matriz1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_GerarMatriz2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown col_Matriz2;
        private System.Windows.Forms.NumericUpDown line_Matriz2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_GerarMatriz1;
        private System.Windows.Forms.NumericUpDown col_Matriz1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown line_Matriz1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Button SubtrairButton;
        private System.Windows.Forms.Button MultiplicarButton;
        private System.Windows.Forms.NumericUpDown NuEscalar1;
        private System.Windows.Forms.Button multiplicarPanel1;
        private System.Windows.Forms.NumericUpDown NuEscalar2;
        private System.Windows.Forms.Button multiplicarPanel2;
    }
}

