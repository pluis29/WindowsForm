using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Busca : Form
    {
        public string idSelect { get; set; }
        List<List<string>> _ListaBusca = new List<List<string>>();
        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            this.Text = "Busca";
            Tls_Principal.Items[0].ToolTipText = "Salvar a seleção.";
            Tls_Principal.Items[1].ToolTipText = "Fechar a seleção.";
            PreencherLista();
            Lst_Busca.Sorted = true;
        }
        private void PreencherLista()
        {
            Lst_Busca.Items.Clear();
            for (int i = 0; i <= _ListaBusca.Count - 1; i++)
            {
                ItemBox X = new ItemBox();
                X.id = _ListaBusca[i][0];
                X.nome = _ListaBusca[i][1];
                Lst_Busca.Items.Add(X);
            }
        }
        private void ApagatoolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (Lst_Busca.SelectedIndex == -1)
            {
                return;
            }
            DialogResult = DialogResult.OK;
            ItemBox ItemSelecionado = (ItemBox)Lst_Busca.Items[Lst_Busca.SelectedIndex];
            idSelect = ItemSelecionado.id;
            this.Close();
        }
        class ItemBox
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }
    }
}
