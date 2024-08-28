using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_MouseEventos : Form
    {
        public Frm_MouseEventos()
        {
            InitializeComponent();
        }

        private void Btn_Mouse_MouseEnter(object sender, EventArgs e)
        {
            Btn_Mouse.Text = "Mouse enter";
        }

        private void Btn_Mouse_MouseLeave(object sender, EventArgs e)
        {
            Btn_Mouse.Text = "Mouse leave";
        }

        private void Btn_Mouse_MouseHover(object sender, EventArgs e)
        {
            Btn_Mouse.Text = "Mouse hover";
        }

        private void Btn_Mouse_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Mouse.Text = "Mouse down";
        }

        private void Btn_Mouse_MouseUp(object sender, MouseEventArgs e)
        {
            Btn_Mouse.Text = "Mouse up";
        }
    }
}
