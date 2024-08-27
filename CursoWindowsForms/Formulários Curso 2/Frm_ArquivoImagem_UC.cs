using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivoImagem;
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void Btn_Cor_Click(object sender, System.EventArgs e)
        {
            ColorDialog cdb = new ColorDialog();
            if (cdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = cdb.Color;

            }
        }

        private void Btn_Fonte_Click(object sender, System.EventArgs e)
        {
            FontDialog fdb = new FontDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = fdb.Font;

            }
        }
    }
}
