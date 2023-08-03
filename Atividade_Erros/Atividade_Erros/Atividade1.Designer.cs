namespace Atividade_Erros
{
    partial class Atividade1
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
            this.lblAnimais = new System.Windows.Forms.Label();
            this.txtAnimais = new System.Windows.Forms.TextBox();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnimais
            // 
            this.lblAnimais.AutoSize = true;
            this.lblAnimais.Location = new System.Drawing.Point(257, 82);
            this.lblAnimais.Name = "lblAnimais";
            this.lblAnimais.Size = new System.Drawing.Size(223, 13);
            this.lblAnimais.TabIndex = 0;
            this.lblAnimais.Text = "Digite um animal, entre cavalo, gato e coelho:";
            // 
            // txtAnimais
            // 
            this.txtAnimais.Location = new System.Drawing.Point(319, 140);
            this.txtAnimais.Name = "txtAnimais";
            this.txtAnimais.Size = new System.Drawing.Size(100, 20);
            this.txtAnimais.TabIndex = 1;
            // 
            // btnAnimais
            // 
            this.btnAnimais.Location = new System.Drawing.Point(331, 202);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(75, 23);
            this.btnAnimais.TabIndex = 2;
            this.btnAnimais.Text = "Calcular";
            this.btnAnimais.UseVisualStyleBackColor = true;
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // Atividade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnimais);
            this.Controls.Add(this.txtAnimais);
            this.Controls.Add(this.lblAnimais);
            this.Name = "Atividade1";
            this.Text = "Atividade1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimais;
        private System.Windows.Forms.TextBox txtAnimais;
        private System.Windows.Forms.Button btnAnimais;
    }
}