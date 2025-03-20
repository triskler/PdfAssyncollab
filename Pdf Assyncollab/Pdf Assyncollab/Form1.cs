using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;


namespace Pdf_Assyncollab
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirPdf_Click(object sender, EventArgs e)
        {
            // Criar o objeto OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Definir o filtro para mostrar apenas arquivos PDF
            openFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";

            // Definir o título da janela de diálogo
            openFileDialog.Title = "Selecione um arquivo PDF";

            // Exibir a janela de seleção de arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Caminho do arquivo selecionado
                string pdfFilePath = openFileDialog.FileName;

                // Exibir o caminho do arquivo selecionado em uma MessageBox
                MessageBox.Show("Você escolheu o arquivo: " + pdfFilePath);

                // Agora você pode abrir o PDF com PdfSharp ou apenas abri-lo no leitor padrão
                System.Diagnostics.Process.Start(pdfFilePath);
            }
            else
            {
                // Caso o usuário tenha cancelado, podemos informar com uma mensagem
                MessageBox.Show("Nenhum arquivo foi selecionado.");
            }
        }
    }
}
