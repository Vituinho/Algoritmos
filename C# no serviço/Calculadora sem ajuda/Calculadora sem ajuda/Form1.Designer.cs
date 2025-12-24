namespace Calculadora_sem_ajuda
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCalculos = new TextBox();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnAdicao = new Button();
            btnLimpa = new Button();
            SuspendLayout();
            // 
            // txtCalculos
            // 
            txtCalculos.Location = new Point(78, 35);
            txtCalculos.Name = "txtCalculos";
            txtCalculos.Size = new Size(278, 23);
            txtCalculos.TabIndex = 0;
            txtCalculos.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.Location = new Point(78, 118);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 58);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(78, 182);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 58);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(78, 246);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 58);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(149, 118);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 58);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(149, 182);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 58);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(149, 246);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 58);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(220, 118);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 58);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(220, 182);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 58);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(220, 246);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 58);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(149, 310);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 58);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(78, 310);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(65, 58);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(220, 310);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(65, 58);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(291, 118);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(65, 58);
            btnDivisao.TabIndex = 13;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(291, 182);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(65, 58);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(291, 246);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(65, 58);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(291, 310);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(65, 58);
            btnAdicao.TabIndex = 16;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnLimpa
            // 
            btnLimpa.Location = new Point(291, 75);
            btnLimpa.Name = "btnLimpa";
            btnLimpa.Size = new Size(65, 37);
            btnLimpa.TabIndex = 17;
            btnLimpa.Text = "C";
            btnLimpa.UseVisualStyleBackColor = true;
            btnLimpa.Click += btnLimpa_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 453);
            Controls.Add(btnLimpa);
            Controls.Add(btnAdicao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(txtCalculos);
            Name = "Calculadora";
            RightToLeft = RightToLeft.Yes;
            Text = "Calculadora do Vituinho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalculos;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn8;
        private Button btn5;
        private Button btn2;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btn0;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnAdicao;
        private Button btnLimpa;
    }
}
