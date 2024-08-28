using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_MouseCaptura : Form
    {
        public Frm_MouseCaptura()
        {
            InitializeComponent();
        }

        private void Btn_Test_MouseDown(object sender, MouseEventArgs e)
        {
            string str1 = e.Button.ToString();
            Btn_Test.Text = str1;
        }
    }
}
