using CursoWindowsFormBiblioteca;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, System.EventArgs e)
        {
            Lbl_Resultado.Text = string.Empty;
            Msk_CPF.Text = string.Empty;
        }

        private void Btn_Valida_Click(object sender, System.EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
            if (validaCPF == true)
            {
                Lbl_Resultado.Text = "CPF VÁLIDO";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Resultado.Text = "CPF INVÁLIDO";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }
    }
}
