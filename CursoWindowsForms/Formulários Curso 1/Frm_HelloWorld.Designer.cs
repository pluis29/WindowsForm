namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(12, 38);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(46, 19);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = ".NET";
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(667, 409);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(121, 29);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Fechar a aplicacao";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modifica Texto do Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Input
            // 
            this.Txt_Input.Location = new System.Drawing.Point(16, 107);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(351, 20);
            this.Txt_Input.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_Input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HelloWorld";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_Input;
    }
}

