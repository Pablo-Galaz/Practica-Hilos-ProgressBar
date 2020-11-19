namespace Practica_1811
{
    partial class Form_Secundario
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
            this.Texto_Recibido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texto_Recibido
            // 
            this.Texto_Recibido.AutoSize = true;
            this.Texto_Recibido.Font = new System.Drawing.Font("Georgia", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Recibido.Location = new System.Drawing.Point(159, 68);
            this.Texto_Recibido.Name = "Texto_Recibido";
            this.Texto_Recibido.Size = new System.Drawing.Size(73, 20);
            this.Texto_Recibido.TabIndex = 0;
            this.Texto_Recibido.Text = "TEXTO";
            this.Texto_Recibido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Secundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(389, 275);
            this.Controls.Add(this.Texto_Recibido);
            this.Name = "Form_Secundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Secundario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto_Recibido;
    }
}