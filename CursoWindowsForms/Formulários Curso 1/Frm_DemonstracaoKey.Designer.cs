namespace CursoWindowsForms
{
    partial class Frm_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            this.Txt_input = new System.Windows.Forms.TextBox();
            this.Txt_Msg = new System.Windows.Forms.TextBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lgl_Minus = new System.Windows.Forms.Label();
            this.Lbl_Maiusc = new System.Windows.Forms.Label();
            this.Lbl_Upper = new System.Windows.Forms.Label();
            this.Lbl_Lower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_input
            // 
            this.Txt_input.Location = new System.Drawing.Point(8, 8);
            this.Txt_input.Name = "Txt_input";
            this.Txt_input.Size = new System.Drawing.Size(100, 20);
            this.Txt_input.TabIndex = 0;
            this.Txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_input_KeyDown);
            // 
            // Txt_Msg
            // 
            this.Txt_Msg.Location = new System.Drawing.Point(8, 40);
            this.Txt_Msg.Multiline = true;
            this.Txt_Msg.Name = "Txt_Msg";
            this.Txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Msg.Size = new System.Drawing.Size(304, 232);
            this.Txt_Msg.TabIndex = 1;
            this.Txt_Msg.TabStop = false;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(328, 8);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(75, 28);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Lgl_Minus
            // 
            this.Lgl_Minus.AutoSize = true;
            this.Lgl_Minus.Location = new System.Drawing.Point(320, 104);
            this.Lgl_Minus.Name = "Lgl_Minus";
            this.Lgl_Minus.Size = new System.Drawing.Size(38, 13);
            this.Lgl_Minus.TabIndex = 3;
            this.Lgl_Minus.Text = "Minus.";
            // 
            // Lbl_Maiusc
            // 
            this.Lbl_Maiusc.AutoSize = true;
            this.Lbl_Maiusc.Location = new System.Drawing.Point(320, 56);
            this.Lbl_Maiusc.Name = "Lbl_Maiusc";
            this.Lbl_Maiusc.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Maiusc.TabIndex = 4;
            this.Lbl_Maiusc.Text = "Minus.";
            // 
            // Lbl_Upper
            // 
            this.Lbl_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Upper.Location = new System.Drawing.Point(368, 56);
            this.Lbl_Upper.Name = "Lbl_Upper";
            this.Lbl_Upper.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Upper.TabIndex = 5;
            // 
            // Lbl_Lower
            // 
            this.Lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Lower.Location = new System.Drawing.Point(368, 104);
            this.Lbl_Lower.Name = "Lbl_Lower";
            this.Lbl_Lower.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Lower.TabIndex = 6;
            // 
            // Frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.Lbl_Lower);
            this.Controls.Add(this.Lbl_Upper);
            this.Controls.Add(this.Lbl_Maiusc);
            this.Controls.Add(this.Lgl_Minus);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Txt_Msg);
            this.Controls.Add(this.Txt_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_input;
        private System.Windows.Forms.TextBox Txt_Msg;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label Lgl_Minus;
        private System.Windows.Forms.Label Lbl_Maiusc;
        private System.Windows.Forms.Label Lbl_Upper;
        private System.Windows.Forms.Label Lbl_Lower;
    }
}