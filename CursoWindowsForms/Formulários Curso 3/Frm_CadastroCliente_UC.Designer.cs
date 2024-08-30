﻿namespace CursoWindowsForms
{
    partial class Frm_CadastroCliente_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente_UC));
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Txt_CPF = new System.Windows.Forms.TextBox();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Lbl_NomePai = new System.Windows.Forms.Label();
            this.Txt_NomePai = new System.Windows.Forms.TextBox();
            this.Txt_NomeMae = new System.Windows.Forms.TextBox();
            this.Lbl_NomeMae = new System.Windows.Forms.Label();
            this.Txt_CEP = new System.Windows.Forms.TextBox();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Txt_Telefone = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Txt_Profissao = new System.Windows.Forms.TextBox();
            this.Lbl_Profissao = new System.Windows.Forms.Label();
            this.Txt_RendaFamiliar = new System.Windows.Forms.TextBox();
            this.Lbl_RendaFamiliar = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Grp_Codigo = new System.Windows.Forms.GroupBox();
            this.Grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.Grp_Genero = new System.Windows.Forms.GroupBox();
            this.Rdb_Indefinido = new System.Windows.Forms.RadioButton();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.Chk_TemPai = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Grp_Endereco = new System.Windows.Forms.GroupBox();
            this.Cmb_Estados = new System.Windows.Forms.ComboBox();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.Grp_Outros = new System.Windows.Forms.GroupBox();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ApagatoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.LimpartoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Btn_Busca = new System.Windows.Forms.Button();
            this.Grp_Codigo.SuspendLayout();
            this.Grp_DadosPessoais.SuspendLayout();
            this.Grp_Genero.SuspendLayout();
            this.Grp_Endereco.SuspendLayout();
            this.Grp_Outros.SuspendLayout();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(6, 70);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CPF.TabIndex = 0;
            this.Lbl_CPF.Text = "label1";
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CPF.Location = new System.Drawing.Point(6, 86);
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(303, 20);
            this.Txt_CPF.TabIndex = 3;
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(6, 31);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeCliente.TabIndex = 2;
            this.Lbl_NomeCliente.Text = "label1";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeCliente.Location = new System.Drawing.Point(6, 47);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(771, 20);
            this.Txt_NomeCliente.TabIndex = 2;
            // 
            // Lbl_NomePai
            // 
            this.Lbl_NomePai.AutoSize = true;
            this.Lbl_NomePai.Location = new System.Drawing.Point(6, 149);
            this.Lbl_NomePai.Name = "Lbl_NomePai";
            this.Lbl_NomePai.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomePai.TabIndex = 4;
            this.Lbl_NomePai.Text = "label1";
            // 
            // Txt_NomePai
            // 
            this.Txt_NomePai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomePai.Location = new System.Drawing.Point(6, 165);
            this.Txt_NomePai.Name = "Txt_NomePai";
            this.Txt_NomePai.Size = new System.Drawing.Size(587, 20);
            this.Txt_NomePai.TabIndex = 8;
            // 
            // Txt_NomeMae
            // 
            this.Txt_NomeMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeMae.Location = new System.Drawing.Point(6, 125);
            this.Txt_NomeMae.Name = "Txt_NomeMae";
            this.Txt_NomeMae.Size = new System.Drawing.Size(587, 20);
            this.Txt_NomeMae.TabIndex = 7;
            // 
            // Lbl_NomeMae
            // 
            this.Lbl_NomeMae.AutoSize = true;
            this.Lbl_NomeMae.Location = new System.Drawing.Point(6, 109);
            this.Lbl_NomeMae.Name = "Lbl_NomeMae";
            this.Lbl_NomeMae.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeMae.TabIndex = 6;
            this.Lbl_NomeMae.Text = "label1";
            // 
            // Txt_CEP
            // 
            this.Txt_CEP.Location = new System.Drawing.Point(3, 33);
            this.Txt_CEP.Name = "Txt_CEP";
            this.Txt_CEP.Size = new System.Drawing.Size(146, 20);
            this.Txt_CEP.TabIndex = 10;
            this.Txt_CEP.Leave += new System.EventHandler(this.Txt_CEP_Leave);
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Location = new System.Drawing.Point(2, 16);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CEP.TabIndex = 10;
            this.Lbl_CEP.Text = "label1";
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Logradouro.Location = new System.Drawing.Point(155, 33);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(622, 20);
            this.Txt_Logradouro.TabIndex = 11;
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(155, 16);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Logradouro.TabIndex = 12;
            this.Lbl_Logradouro.Text = "label1";
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Location = new System.Drawing.Point(3, 72);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(377, 20);
            this.Txt_Complemento.TabIndex = 12;
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Location = new System.Drawing.Point(3, 56);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Complemento.TabIndex = 14;
            this.Lbl_Complemento.Text = "label1";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(386, 72);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(391, 20);
            this.Txt_Bairro.TabIndex = 13;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(386, 56);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Bairro.TabIndex = 16;
            this.Lbl_Bairro.Text = "label1";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.Lbl_Estado.Location = new System.Drawing.Point(386, 98);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Estado.TabIndex = 18;
            this.Lbl_Estado.Text = "label1";
            // 
            // Txt_Telefone
            // 
            this.Txt_Telefone.Location = new System.Drawing.Point(3, 35);
            this.Txt_Telefone.Name = "Txt_Telefone";
            this.Txt_Telefone.Size = new System.Drawing.Size(328, 20);
            this.Txt_Telefone.TabIndex = 16;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Location = new System.Drawing.Point(3, 19);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Telefone.TabIndex = 20;
            this.Lbl_Telefone.Text = "label1";
            // 
            // Txt_Profissao
            // 
            this.Txt_Profissao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Profissao.Location = new System.Drawing.Point(339, 35);
            this.Txt_Profissao.Name = "Txt_Profissao";
            this.Txt_Profissao.Size = new System.Drawing.Size(438, 20);
            this.Txt_Profissao.TabIndex = 17;
            // 
            // Lbl_Profissao
            // 
            this.Lbl_Profissao.AutoSize = true;
            this.Lbl_Profissao.Location = new System.Drawing.Point(341, 19);
            this.Lbl_Profissao.Name = "Lbl_Profissao";
            this.Lbl_Profissao.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Profissao.TabIndex = 22;
            this.Lbl_Profissao.Text = "label1";
            // 
            // Txt_RendaFamiliar
            // 
            this.Txt_RendaFamiliar.Location = new System.Drawing.Point(3, 75);
            this.Txt_RendaFamiliar.Name = "Txt_RendaFamiliar";
            this.Txt_RendaFamiliar.Size = new System.Drawing.Size(328, 20);
            this.Txt_RendaFamiliar.TabIndex = 18;
            // 
            // Lbl_RendaFamiliar
            // 
            this.Lbl_RendaFamiliar.AutoSize = true;
            this.Lbl_RendaFamiliar.Location = new System.Drawing.Point(3, 59);
            this.Lbl_RendaFamiliar.Name = "Lbl_RendaFamiliar";
            this.Lbl_RendaFamiliar.Size = new System.Drawing.Size(35, 13);
            this.Lbl_RendaFamiliar.TabIndex = 24;
            this.Lbl_RendaFamiliar.Text = "label1";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(6, 19);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(236, 20);
            this.Txt_Codigo.TabIndex = 1;
            // 
            // Grp_Codigo
            // 
            this.Grp_Codigo.Controls.Add(this.Btn_Busca);
            this.Grp_Codigo.Controls.Add(this.Txt_Codigo);
            this.Grp_Codigo.Location = new System.Drawing.Point(12, 58);
            this.Grp_Codigo.Name = "Grp_Codigo";
            this.Grp_Codigo.Size = new System.Drawing.Size(330, 56);
            this.Grp_Codigo.TabIndex = 28;
            this.Grp_Codigo.TabStop = false;
            this.Grp_Codigo.Text = "groupBox1";
            // 
            // Grp_DadosPessoais
            // 
            this.Grp_DadosPessoais.Controls.Add(this.Grp_Genero);
            this.Grp_DadosPessoais.Controls.Add(this.Chk_TemPai);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_CPF);
            this.Grp_DadosPessoais.Location = new System.Drawing.Point(12, 120);
            this.Grp_DadosPessoais.Name = "Grp_DadosPessoais";
            this.Grp_DadosPessoais.Size = new System.Drawing.Size(783, 195);
            this.Grp_DadosPessoais.TabIndex = 29;
            this.Grp_DadosPessoais.TabStop = false;
            this.Grp_DadosPessoais.Text = "groupBox1";
            // 
            // Grp_Genero
            // 
            this.Grp_Genero.Controls.Add(this.Rdb_Indefinido);
            this.Grp_Genero.Controls.Add(this.Rdb_Masculino);
            this.Grp_Genero.Controls.Add(this.Rdb_Feminino);
            this.Grp_Genero.Location = new System.Drawing.Point(599, 73);
            this.Grp_Genero.Name = "Grp_Genero";
            this.Grp_Genero.Size = new System.Drawing.Size(178, 86);
            this.Grp_Genero.TabIndex = 33;
            this.Grp_Genero.TabStop = false;
            // 
            // Rdb_Indefinido
            // 
            this.Rdb_Indefinido.AutoSize = true;
            this.Rdb_Indefinido.Location = new System.Drawing.Point(6, 63);
            this.Rdb_Indefinido.Name = "Rdb_Indefinido";
            this.Rdb_Indefinido.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Indefinido.TabIndex = 6;
            this.Rdb_Indefinido.TabStop = true;
            this.Rdb_Indefinido.Text = "radioButton3";
            this.Rdb_Indefinido.UseVisualStyleBackColor = true;
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(6, 19);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Masculino.TabIndex = 4;
            this.Rdb_Masculino.TabStop = true;
            this.Rdb_Masculino.Text = "radioButton1";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // Rdb_Feminino
            // 
            this.Rdb_Feminino.AutoSize = true;
            this.Rdb_Feminino.Location = new System.Drawing.Point(6, 42);
            this.Rdb_Feminino.Name = "Rdb_Feminino";
            this.Rdb_Feminino.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Feminino.TabIndex = 5;
            this.Rdb_Feminino.TabStop = true;
            this.Rdb_Feminino.Text = "radioButton2";
            this.Rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // Chk_TemPai
            // 
            this.Chk_TemPai.AutoSize = true;
            this.Chk_TemPai.Location = new System.Drawing.Point(599, 167);
            this.Chk_TemPai.Name = "Chk_TemPai";
            this.Chk_TemPai.Size = new System.Drawing.Size(80, 17);
            this.Chk_TemPai.TabIndex = 9;
            this.Chk_TemPai.Text = "checkBox1";
            this.Chk_TemPai.UseVisualStyleBackColor = true;
            this.Chk_TemPai.CheckedChanged += new System.EventHandler(this.Chk_TemPai_CheckedChanged);
            // 
            // Grp_Endereco
            // 
            this.Grp_Endereco.Controls.Add(this.Cmb_Estados);
            this.Grp_Endereco.Controls.Add(this.Lbl_Cidade);
            this.Grp_Endereco.Controls.Add(this.Txt_Cidade);
            this.Grp_Endereco.Controls.Add(this.Lbl_CEP);
            this.Grp_Endereco.Controls.Add(this.Txt_CEP);
            this.Grp_Endereco.Controls.Add(this.Lbl_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Txt_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Complemento);
            this.Grp_Endereco.Controls.Add(this.Txt_Complemento);
            this.Grp_Endereco.Controls.Add(this.Lbl_Bairro);
            this.Grp_Endereco.Controls.Add(this.Txt_Bairro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Estado);
            this.Grp_Endereco.Location = new System.Drawing.Point(12, 321);
            this.Grp_Endereco.Name = "Grp_Endereco";
            this.Grp_Endereco.Size = new System.Drawing.Size(783, 145);
            this.Grp_Endereco.TabIndex = 30;
            this.Grp_Endereco.TabStop = false;
            this.Grp_Endereco.Text = "groupBox1";
            // 
            // Cmb_Estados
            // 
            this.Cmb_Estados.FormattingEnabled = true;
            this.Cmb_Estados.Location = new System.Drawing.Point(386, 114);
            this.Cmb_Estados.Name = "Cmb_Estados";
            this.Cmb_Estados.Size = new System.Drawing.Size(391, 21);
            this.Cmb_Estados.TabIndex = 21;
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(2, 98);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Cidade.TabIndex = 20;
            this.Lbl_Cidade.Text = "label1";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(2, 114);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(377, 20);
            this.Txt_Cidade.TabIndex = 14;
            // 
            // Grp_Outros
            // 
            this.Grp_Outros.Controls.Add(this.Txt_Profissao);
            this.Grp_Outros.Controls.Add(this.Lbl_Telefone);
            this.Grp_Outros.Controls.Add(this.Txt_Telefone);
            this.Grp_Outros.Controls.Add(this.Lbl_Profissao);
            this.Grp_Outros.Controls.Add(this.Txt_RendaFamiliar);
            this.Grp_Outros.Controls.Add(this.Lbl_RendaFamiliar);
            this.Grp_Outros.Location = new System.Drawing.Point(12, 472);
            this.Grp_Outros.Name = "Grp_Outros";
            this.Grp_Outros.Size = new System.Drawing.Size(783, 105);
            this.Grp_Outros.TabIndex = 31;
            this.Grp_Outros.TabStop = false;
            this.Grp_Outros.Text = "groupBox1";
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.ApagatoolStripButton1,
            this.LimpartoolStripButton1});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(806, 25);
            this.Tls_Principal.TabIndex = 32;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // ApagatoolStripButton1
            // 
            this.ApagatoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagatoolStripButton1.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.ApagatoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagatoolStripButton1.Name = "ApagatoolStripButton1";
            this.ApagatoolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.ApagatoolStripButton1.Text = "toolStripButton1";
            this.ApagatoolStripButton1.Click += new System.EventHandler(this.ApagatoolStripButton1_Click);
            // 
            // LimpartoolStripButton1
            // 
            this.LimpartoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LimpartoolStripButton1.Image = global::CursoWindowsForms.Properties.Resources.LimparBarra;
            this.LimpartoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LimpartoolStripButton1.Name = "LimpartoolStripButton1";
            this.LimpartoolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.LimpartoolStripButton1.Text = "toolStripButton1";
            this.LimpartoolStripButton1.Click += new System.EventHandler(this.LimpartoolStripButton1_Click);
            // 
            // Btn_Busca
            // 
            this.Btn_Busca.Location = new System.Drawing.Point(248, 18);
            this.Btn_Busca.Name = "Btn_Busca";
            this.Btn_Busca.Size = new System.Drawing.Size(75, 23);
            this.Btn_Busca.TabIndex = 2;
            this.Btn_Busca.Text = "button1";
            this.Btn_Busca.UseVisualStyleBackColor = true;
            this.Btn_Busca.Click += new System.EventHandler(this.Btn_Busca_Click);
            // 
            // Frm_CadastroCliente_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tls_Principal);
            this.Controls.Add(this.Grp_Outros);
            this.Controls.Add(this.Grp_Endereco);
            this.Controls.Add(this.Grp_DadosPessoais);
            this.Controls.Add(this.Grp_Codigo);
            this.Name = "Frm_CadastroCliente_UC";
            this.Size = new System.Drawing.Size(806, 605);
            this.Grp_Codigo.ResumeLayout(false);
            this.Grp_Codigo.PerformLayout();
            this.Grp_DadosPessoais.ResumeLayout(false);
            this.Grp_DadosPessoais.PerformLayout();
            this.Grp_Genero.ResumeLayout(false);
            this.Grp_Genero.PerformLayout();
            this.Grp_Endereco.ResumeLayout(false);
            this.Grp_Endereco.PerformLayout();
            this.Grp_Outros.ResumeLayout(false);
            this.Grp_Outros.PerformLayout();
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.TextBox Txt_CPF;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.Label Lbl_NomePai;
        private System.Windows.Forms.TextBox Txt_NomePai;
        private System.Windows.Forms.TextBox Txt_NomeMae;
        private System.Windows.Forms.Label Lbl_NomeMae;
        private System.Windows.Forms.TextBox Txt_CEP;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.TextBox Txt_Logradouro;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_Telefone;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.TextBox Txt_Profissao;
        private System.Windows.Forms.Label Lbl_Profissao;
        private System.Windows.Forms.TextBox Txt_RendaFamiliar;
        private System.Windows.Forms.Label Lbl_RendaFamiliar;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.GroupBox Grp_Codigo;
        private System.Windows.Forms.GroupBox Grp_DadosPessoais;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox Grp_Endereco;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.GroupBox Grp_Outros;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.CheckBox Chk_TemPai;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.Windows.Forms.GroupBox Grp_Genero;
        private System.Windows.Forms.RadioButton Rdb_Indefinido;
        private System.Windows.Forms.RadioButton Rdb_Feminino;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.ComboBox Cmb_Estados;
        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton ApagatoolStripButton1;
        private System.Windows.Forms.ToolStripButton LimpartoolStripButton1;
        private System.Windows.Forms.Button Btn_Busca;
    }
}
