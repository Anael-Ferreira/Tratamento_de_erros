namespace Atividade_Erros
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
            this.btnAtvUm = new System.Windows.Forms.Button();
            this.btnAtvDois = new System.Windows.Forms.Button();
            this.btnAtvTres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtvUm
            // 
            this.btnAtvUm.Location = new System.Drawing.Point(273, 117);
            this.btnAtvUm.Name = "btnAtvUm";
            this.btnAtvUm.Size = new System.Drawing.Size(195, 23);
            this.btnAtvUm.TabIndex = 0;
            this.btnAtvUm.Text = "Atividade 1";
            this.btnAtvUm.UseVisualStyleBackColor = true;
            this.btnAtvUm.Click += new System.EventHandler(this.btnAtvUm_Click);
            // 
            // btnAtvDois
            // 
            this.btnAtvDois.Location = new System.Drawing.Point(273, 182);
            this.btnAtvDois.Name = "btnAtvDois";
            this.btnAtvDois.Size = new System.Drawing.Size(195, 23);
            this.btnAtvDois.TabIndex = 1;
            this.btnAtvDois.Text = "Atividade 2";
            this.btnAtvDois.UseVisualStyleBackColor = true;
            this.btnAtvDois.Click += new System.EventHandler(this.btnAtvDois_Click);
            // 
            // btnAtvTres
            // 
            this.btnAtvTres.Location = new System.Drawing.Point(273, 249);
            this.btnAtvTres.Name = "btnAtvTres";
            this.btnAtvTres.Size = new System.Drawing.Size(195, 23);
            this.btnAtvTres.TabIndex = 2;
            this.btnAtvTres.Text = "Atividade 3";
            this.btnAtvTres.UseVisualStyleBackColor = true;
            this.btnAtvTres.Click += new System.EventHandler(this.btnAtvTres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtvTres);
            this.Controls.Add(this.btnAtvDois);
            this.Controls.Add(this.btnAtvUm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtvUm;
        private System.Windows.Forms.Button btnAtvDois;
        private System.Windows.Forms.Button btnAtvTres;
    }
}

