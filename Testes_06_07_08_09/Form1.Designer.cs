namespace Testes_06_07_08_09
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeAluno = new System.Windows.Forms.TextBox();
            this.nota1semestre = new System.Windows.Forms.TextBox();
            this.nota2semestre = new System.Windows.Forms.TextBox();
            this.ano = new System.Windows.Forms.TextBox();
            this.envia = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome do aluno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "nota do 1º semestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "nota do 2º semestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ano";
            // 
            // nomeAluno
            // 
            this.nomeAluno.Location = new System.Drawing.Point(127, 67);
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.Size = new System.Drawing.Size(270, 22);
            this.nomeAluno.TabIndex = 4;
            // 
            // nota1semestre
            // 
            this.nota1semestre.Location = new System.Drawing.Point(84, 137);
            this.nota1semestre.Name = "nota1semestre";
            this.nota1semestre.Size = new System.Drawing.Size(123, 22);
            this.nota1semestre.TabIndex = 5;
            this.nota1semestre.TextChanged += new System.EventHandler(this.nota1_TextChanged);
            // 
            // nota2semestre
            // 
            this.nota2semestre.Location = new System.Drawing.Point(241, 137);
            this.nota2semestre.Name = "nota2semestre";
            this.nota2semestre.Size = new System.Drawing.Size(123, 22);
            this.nota2semestre.TabIndex = 6;
            // 
            // ano
            // 
            this.ano.Location = new System.Drawing.Point(399, 137);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(68, 22);
            this.ano.TabIndex = 7;
            // 
            // envia
            // 
            this.envia.Location = new System.Drawing.Point(127, 211);
            this.envia.Name = "envia";
            this.envia.Size = new System.Drawing.Size(182, 23);
            this.envia.TabIndex = 8;
            this.envia.Text = "enviar";
            this.envia.UseVisualStyleBackColor = true;
            this.envia.Click += new System.EventHandler(this.envia_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(333, 211);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 9;
            this.cancelar.Text = "cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "consultar alunos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.envia);
            this.Controls.Add(this.ano);
            this.Controls.Add(this.nota2semestre);
            this.Controls.Add(this.nota1semestre);
            this.Controls.Add(this.nomeAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeAluno;
        private System.Windows.Forms.TextBox nota1semestre;
        private System.Windows.Forms.TextBox nota2semestre;
        private System.Windows.Forms.TextBox ano;
        private System.Windows.Forms.Button envia;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label5;
    }
}

