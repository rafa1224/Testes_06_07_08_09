namespace Testes_06_07_08_09
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mostra = new System.Windows.Forms.Button();
            this.volta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mostra
            // 
            this.mostra.Location = new System.Drawing.Point(12, 203);
            this.mostra.Name = "mostra";
            this.mostra.Size = new System.Drawing.Size(75, 23);
            this.mostra.TabIndex = 1;
            this.mostra.Text = "mostrar";
            this.mostra.UseVisualStyleBackColor = true;
            this.mostra.Click += new System.EventHandler(this.mostra_Click);
            // 
            // volta
            // 
            this.volta.Location = new System.Drawing.Point(93, 203);
            this.volta.Name = "volta";
            this.volta.Size = new System.Drawing.Size(75, 23);
            this.volta.TabIndex = 2;
            this.volta.Text = "voltar";
            this.volta.UseVisualStyleBackColor = true;
            this.volta.Click += new System.EventHandler(this.volta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 497);
            this.Controls.Add(this.volta);
            this.Controls.Add(this.mostra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button mostra;
        private System.Windows.Forms.Button volta;
    }
}