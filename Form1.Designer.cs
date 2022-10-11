namespace Prova_RAº6322036
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
            this.txt_Quarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Frigobar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Restaurante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº quarto:";
            // 
            // txt_Quarto
            // 
            this.txt_Quarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quarto.Location = new System.Drawing.Point(249, 157);
            this.txt_Quarto.Name = "txt_Quarto";
            this.txt_Quarto.Size = new System.Drawing.Size(276, 31);
            this.txt_Quarto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONSUMO";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(62, 332);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(102, 48);
            this.btn_Salvar.TabIndex = 3;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.Location = new System.Drawing.Point(341, 332);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(116, 48);
            this.btn_Pesquisar.TabIndex = 4;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.Location = new System.Drawing.Point(249, 120);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(274, 31);
            this.txt_Cliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente:";
            // 
            // txt_Frigobar
            // 
            this.txt_Frigobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Frigobar.Location = new System.Drawing.Point(249, 194);
            this.txt_Frigobar.Name = "txt_Frigobar";
            this.txt_Frigobar.Size = new System.Drawing.Size(275, 31);
            this.txt_Frigobar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consumo Frigobar:";
            // 
            // txt_Restaurante
            // 
            this.txt_Restaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Restaurante.Location = new System.Drawing.Point(249, 231);
            this.txt_Restaurante.Name = "txt_Restaurante";
            this.txt_Restaurante.Size = new System.Drawing.Size(274, 31);
            this.txt_Restaurante.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Consumo Restaurante:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.txt_Restaurante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Frigobar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Quarto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Quarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Frigobar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Restaurante;
        private System.Windows.Forms.Label label5;
    }
}

