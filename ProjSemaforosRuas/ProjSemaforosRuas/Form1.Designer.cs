namespace ProjSemaforosRuas
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
            this.picSemaforoRua1 = new System.Windows.Forms.PictureBox();
            this.picSemaforoRua2 = new System.Windows.Forms.PictureBox();
            this.btnRua1vermelho = new System.Windows.Forms.Button();
            this.btnRua1amarelo = new System.Windows.Forms.Button();
            this.btnRua1verde = new System.Windows.Forms.Button();
            this.btnRua2vermelho = new System.Windows.Forms.Button();
            this.btnRua2amarelo = new System.Windows.Forms.Button();
            this.btnRua2verde = new System.Windows.Forms.Button();
            this.estado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoRua1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoRua2)).BeginInit();
            this.SuspendLayout();
            // 
            // picSemaforoRua1
            // 
            this.picSemaforoRua1.Image = global::ProjSemaforosRuas.Properties.Resources.semvermelho;
            this.picSemaforoRua1.Location = new System.Drawing.Point(130, 80);
            this.picSemaforoRua1.Name = "picSemaforoRua1";
            this.picSemaforoRua1.Size = new System.Drawing.Size(100, 175);
            this.picSemaforoRua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSemaforoRua1.TabIndex = 0;
            this.picSemaforoRua1.TabStop = false;
            // 
            // picSemaforoRua2
            // 
            this.picSemaforoRua2.Image = global::ProjSemaforosRuas.Properties.Resources.semverde;
            this.picSemaforoRua2.Location = new System.Drawing.Point(488, 80);
            this.picSemaforoRua2.Name = "picSemaforoRua2";
            this.picSemaforoRua2.Size = new System.Drawing.Size(100, 175);
            this.picSemaforoRua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSemaforoRua2.TabIndex = 1;
            this.picSemaforoRua2.TabStop = false;
            // 
            // btnRua1vermelho
            // 
            this.btnRua1vermelho.Location = new System.Drawing.Point(236, 97);
            this.btnRua1vermelho.Name = "btnRua1vermelho";
            this.btnRua1vermelho.Size = new System.Drawing.Size(75, 23);
            this.btnRua1vermelho.TabIndex = 2;
            this.btnRua1vermelho.Text = "Vermelho";
            this.btnRua1vermelho.UseVisualStyleBackColor = true;
            // 
            // btnRua1amarelo
            // 
            this.btnRua1amarelo.Location = new System.Drawing.Point(236, 150);
            this.btnRua1amarelo.Name = "btnRua1amarelo";
            this.btnRua1amarelo.Size = new System.Drawing.Size(75, 23);
            this.btnRua1amarelo.TabIndex = 3;
            this.btnRua1amarelo.Text = "Amarelo";
            this.btnRua1amarelo.UseVisualStyleBackColor = true;
            // 
            // btnRua1verde
            // 
            this.btnRua1verde.Location = new System.Drawing.Point(236, 213);
            this.btnRua1verde.Name = "btnRua1verde";
            this.btnRua1verde.Size = new System.Drawing.Size(75, 23);
            this.btnRua1verde.TabIndex = 4;
            this.btnRua1verde.Text = "Verde";
            this.btnRua1verde.UseVisualStyleBackColor = true;
            // 
            // btnRua2vermelho
            // 
            this.btnRua2vermelho.Location = new System.Drawing.Point(396, 97);
            this.btnRua2vermelho.Name = "btnRua2vermelho";
            this.btnRua2vermelho.Size = new System.Drawing.Size(75, 23);
            this.btnRua2vermelho.TabIndex = 7;
            this.btnRua2vermelho.Text = "Vermelho";
            this.btnRua2vermelho.UseVisualStyleBackColor = true;
            // 
            // btnRua2amarelo
            // 
            this.btnRua2amarelo.Location = new System.Drawing.Point(396, 150);
            this.btnRua2amarelo.Name = "btnRua2amarelo";
            this.btnRua2amarelo.Size = new System.Drawing.Size(75, 23);
            this.btnRua2amarelo.TabIndex = 6;
            this.btnRua2amarelo.Text = "Amarelo";
            this.btnRua2amarelo.UseVisualStyleBackColor = true;
            // 
            // btnRua2verde
            // 
            this.btnRua2verde.Location = new System.Drawing.Point(396, 213);
            this.btnRua2verde.Name = "btnRua2verde";
            this.btnRua2verde.Size = new System.Drawing.Size(75, 23);
            this.btnRua2verde.TabIndex = 5;
            this.btnRua2verde.Text = "Verde";
            this.btnRua2verde.UseVisualStyleBackColor = true;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(309, 294);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(100, 20);
            this.estado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.btnRua2vermelho);
            this.Controls.Add(this.btnRua2amarelo);
            this.Controls.Add(this.btnRua2verde);
            this.Controls.Add(this.btnRua1verde);
            this.Controls.Add(this.btnRua1amarelo);
            this.Controls.Add(this.btnRua1vermelho);
            this.Controls.Add(this.picSemaforoRua2);
            this.Controls.Add(this.picSemaforoRua1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoRua1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoRua2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSemaforoRua1;
        private System.Windows.Forms.PictureBox picSemaforoRua2;
        private System.Windows.Forms.Button btnRua1vermelho;
        private System.Windows.Forms.Button btnRua1amarelo;
        private System.Windows.Forms.Button btnRua1verde;
        private System.Windows.Forms.Button btnRua2vermelho;
        private System.Windows.Forms.Button btnRua2amarelo;
        private System.Windows.Forms.Button btnRua2verde;
        private System.Windows.Forms.TextBox estado;
    }
}

