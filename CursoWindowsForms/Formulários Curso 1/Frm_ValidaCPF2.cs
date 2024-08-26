using CursoWindowsFormBiblioteca;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Valida_Click(object sender, System.EventArgs e)
        {
            string vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "").Trim();
            if (vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 números", "Mensagem de validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de validação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool validaCPF = false;
                        validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
                        if (validaCPF == true)
                        {
                            MessageBox.Show("CPF VÁLIDO", "Mensagem de validação",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF INVÁLIDO", "Mensagem de validação",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
    }
}

