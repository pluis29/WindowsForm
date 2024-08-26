using CursoWindowsFormBiblioteca;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha : Form
    {
        bool VerSenha = false;
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = string.Empty;
            Lbl_Resultado.Text = string.Empty;
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            var verifica = new Cls_Uteis.ChecaForcaSenha();
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();
            if (Lbl_Resultado.Text == "Inaceitavel" | Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if (Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if (Lbl_Resultado.Text == "Forte" | Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenha == false)
            {
                Txt_Senha.PasswordChar = '\0';
                VerSenha = true;
                Btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                VerSenha = false;
                Btn_VerSenha.Text = "Ver Senha";
            }
        }
    }
}
