namespace Pdf_Assyncollab
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
            this.btnAbrirPdf = new System.Windows.Forms.Button();
            this.txtConteudoPdf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAbrirPdf
            // 
            this.btnAbrirPdf.Location = new System.Drawing.Point(642, 481);
            this.btnAbrirPdf.Name = "btnAbrirPdf";
            this.btnAbrirPdf.Size = new System.Drawing.Size(209, 72);
            this.btnAbrirPdf.TabIndex = 0;
            this.btnAbrirPdf.Text = "Abrir PDF";
            this.btnAbrirPdf.UseVisualStyleBackColor = true;
            this.btnAbrirPdf.Click += new System.EventHandler(this.btnAbrirPdf_Click);
            // 
            // txtConteudoPdf
            // 
            this.txtConteudoPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtConteudoPdf.Font = new System.Drawing.Font("Calibri", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudoPdf.Location = new System.Drawing.Point(0, 0);
            this.txtConteudoPdf.Multiline = true;
            this.txtConteudoPdf.Name = "txtConteudoPdf";
            this.txtConteudoPdf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConteudoPdf.Size = new System.Drawing.Size(1555, 459);
            this.txtConteudoPdf.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 565);
            this.Controls.Add(this.txtConteudoPdf);
            this.Controls.Add(this.btnAbrirPdf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirPdf;
        private System.Windows.Forms.TextBox txtConteudoPdf;
    }
}

