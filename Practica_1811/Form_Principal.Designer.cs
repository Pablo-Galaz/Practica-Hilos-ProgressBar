namespace Practica_1811
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CuadroTexto = new System.Windows.Forms.TextBox();
            this.btn_CargarForm = new System.Windows.Forms.Button();
            this.btn_EnviarTexto = new System.Windows.Forms.Button();
            this.BarraProgreso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // CuadroTexto
            // 
            this.CuadroTexto.BackColor = System.Drawing.Color.Tan;
            this.CuadroTexto.Location = new System.Drawing.Point(64, 36);
            this.CuadroTexto.Multiline = true;
            this.CuadroTexto.Name = "CuadroTexto";
            this.CuadroTexto.Size = new System.Drawing.Size(304, 29);
            this.CuadroTexto.TabIndex = 0;
            // 
            // btn_CargarForm
            // 
            this.btn_CargarForm.BackColor = System.Drawing.Color.Tan;
            this.btn_CargarForm.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarForm.Location = new System.Drawing.Point(130, 110);
            this.btn_CargarForm.Name = "btn_CargarForm";
            this.btn_CargarForm.Size = new System.Drawing.Size(168, 40);
            this.btn_CargarForm.TabIndex = 1;
            this.btn_CargarForm.Text = "Cargar Form";
            this.btn_CargarForm.UseVisualStyleBackColor = false;
            this.btn_CargarForm.Click += new System.EventHandler(this.btn_CargarForm_Click);
            // 
            // btn_EnviarTexto
            // 
            this.btn_EnviarTexto.BackColor = System.Drawing.Color.Tan;
            this.btn_EnviarTexto.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnviarTexto.Location = new System.Drawing.Point(130, 202);
            this.btn_EnviarTexto.Name = "btn_EnviarTexto";
            this.btn_EnviarTexto.Size = new System.Drawing.Size(168, 40);
            this.btn_EnviarTexto.TabIndex = 2;
            this.btn_EnviarTexto.Text = "Enviar Texto";
            this.btn_EnviarTexto.UseVisualStyleBackColor = false;
            this.btn_EnviarTexto.Click += new System.EventHandler(this.btn_EnviarTexto_Click);
            // 
            // BarraProgreso
            // 
            this.BarraProgreso.BackColor = System.Drawing.Color.Tan;
            this.BarraProgreso.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BarraProgreso.Location = new System.Drawing.Point(67, 303);
            this.BarraProgreso.MarqueeAnimationSpeed = 4000;
            this.BarraProgreso.Name = "BarraProgreso";
            this.BarraProgreso.Size = new System.Drawing.Size(289, 27);
            this.BarraProgreso.TabIndex = 3;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(423, 364);
            this.Controls.Add(this.BarraProgreso);
            this.Controls.Add(this.btn_EnviarTexto);
            this.Controls.Add(this.btn_CargarForm);
            this.Controls.Add(this.CuadroTexto);
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CargarForm;
        private System.Windows.Forms.Button btn_EnviarTexto;
        private System.Windows.Forms.ProgressBar BarraProgreso;
        public System.Windows.Forms.TextBox CuadroTexto;
    }
}

