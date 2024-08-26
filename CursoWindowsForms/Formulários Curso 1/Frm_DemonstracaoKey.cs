using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText($"\r\nPressionei a tecla: {e.KeyCode}\r\n");
            Txt_Msg.AppendText($"\tCódigo da tecla: {e.KeyValue}\r\n");
            Txt_Msg.AppendText($"\tNome da tecla: {e.KeyData}\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void Btn_Reset_Click(object sender, System.EventArgs e)
        {
            Txt_Msg.Text = "";
            Txt_input.Text = "";
            Lbl_Lower.Text = "";
            Lbl_Upper.Text = "";
        }
    }
}
