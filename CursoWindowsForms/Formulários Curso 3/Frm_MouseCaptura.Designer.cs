namespace CursoWindowsForms
{
    partial class Frm_MouseCaptura
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
            this.Btn_Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Test
            // 
            this.Btn_Test.Location = new System.Drawing.Point(44, 32);
            this.Btn_Test.Name = "Btn_Test";
            this.Btn_Test.Size = new System.Drawing.Size(251, 136);
            this.Btn_Test.TabIndex = 0;
            this.Btn_Test.Text = "button1";
            this.Btn_Test.UseVisualStyleBackColor = true;
            this.Btn_Test.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Test_MouseDown);
            // 
            // Frm_MouseCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 214);
            this.Controls.Add(this.Btn_Test);
            this.Name = "Frm_MouseCaptura";
            this.Text = "Frm_MouseCaptura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Test;
    }
}