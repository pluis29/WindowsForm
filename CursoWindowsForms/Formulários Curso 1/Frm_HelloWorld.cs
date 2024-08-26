using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }
        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lbl_Titulo.Text = Txt_Input.Text;
        }
    }
}
