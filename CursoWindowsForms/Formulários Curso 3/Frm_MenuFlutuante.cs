using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var contextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Item do menu 1", "question");
                var vToolTip002 = DesenhaItemMenu("Item do menu 2", "key");
                contextMenu.Items.Add(vToolTip001);
                contextMenu.Items.Add(vToolTip002);

                contextMenu.Show(this, e.X, e.Y);
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Opção 1");
            }
            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Opção 2");
            }

            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {

                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;
                Image myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = myImage;
                return vToolTip;
            }
        }

    }
}
