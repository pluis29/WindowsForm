﻿namespace CursoWindowsForms
{
    partial class Frm_Busca
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ApagatoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Lst_Busca = new System.Windows.Forms.ListBox();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.ApagatoolStripButton1});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(345, 25);
            this.Tls_Principal.TabIndex = 33;
            this.Tls_Principal.Text = "toolStrip1";
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
            // Lst_Busca
            // 
            this.Lst_Busca.FormattingEnabled = true;
            this.Lst_Busca.Location = new System.Drawing.Point(12, 44);
            this.Lst_Busca.Name = "Lst_Busca";
            this.Lst_Busca.Size = new System.Drawing.Size(321, 264);
            this.Lst_Busca.TabIndex = 34;
            // 
            // Frm_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 320);
            this.Controls.Add(this.Lst_Busca);
            this.Controls.Add(this.Tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Busca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Busca";
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton ApagatoolStripButton1;
        private System.Windows.Forms.ListBox Lst_Busca;
    }
}