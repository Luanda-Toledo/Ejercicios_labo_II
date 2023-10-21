namespace Ejercicio_25
{
    partial class FrmEjercicio25
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
            this.lblBinarioDecimal = new System.Windows.Forms.Label();
            this.lblDecimalBinario = new System.Windows.Forms.Label();
            this.textBinario = new System.Windows.Forms.TextBox();
            this.textDecimal = new System.Windows.Forms.TextBox();
            this.textResultadoDecimal = new System.Windows.Forms.TextBox();
            this.textResultadoBinario = new System.Windows.Forms.TextBox();
            this.btnBinarioADecimal = new System.Windows.Forms.Button();
            this.btnDecimalABinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinarioDecimal
            // 
            this.lblBinarioDecimal.AutoSize = true;
            this.lblBinarioDecimal.Location = new System.Drawing.Point(55, 77);
            this.lblBinarioDecimal.Name = "lblBinarioDecimal";
            this.lblBinarioDecimal.Size = new System.Drawing.Size(89, 13);
            this.lblBinarioDecimal.TabIndex = 0;
            this.lblBinarioDecimal.Text = "Binario a Decimal";
            // 
            // lblDecimalBinario
            // 
            this.lblDecimalBinario.AutoSize = true;
            this.lblDecimalBinario.Location = new System.Drawing.Point(55, 137);
            this.lblDecimalBinario.Name = "lblDecimalBinario";
            this.lblDecimalBinario.Size = new System.Drawing.Size(89, 13);
            this.lblDecimalBinario.TabIndex = 1;
            this.lblDecimalBinario.Text = "Decimal a Binario";
            // 
            // textBinario
            // 
            this.textBinario.Location = new System.Drawing.Point(196, 74);
            this.textBinario.Name = "textBinario";
            this.textBinario.Size = new System.Drawing.Size(100, 20);
            this.textBinario.TabIndex = 2;
            // 
            // textDecimal
            // 
            this.textDecimal.Location = new System.Drawing.Point(196, 134);
            this.textDecimal.Name = "textDecimal";
            this.textDecimal.Size = new System.Drawing.Size(100, 20);
            this.textDecimal.TabIndex = 3;
            // 
            // textResultadoDecimal
            // 
            this.textResultadoDecimal.Location = new System.Drawing.Point(440, 74);
            this.textResultadoDecimal.Name = "textResultadoDecimal";
            this.textResultadoDecimal.Size = new System.Drawing.Size(100, 20);
            this.textResultadoDecimal.TabIndex = 4;
            // 
            // textResultadoBinario
            // 
            this.textResultadoBinario.Location = new System.Drawing.Point(440, 134);
            this.textResultadoBinario.Name = "textResultadoBinario";
            this.textResultadoBinario.Size = new System.Drawing.Size(100, 20);
            this.textResultadoBinario.TabIndex = 5;
            // 
            // btnBinarioADecimal
            // 
            this.btnBinarioADecimal.Location = new System.Drawing.Point(334, 71);
            this.btnBinarioADecimal.Name = "btnBinarioADecimal";
            this.btnBinarioADecimal.Size = new System.Drawing.Size(75, 23);
            this.btnBinarioADecimal.TabIndex = 6;
            this.btnBinarioADecimal.Text = "->";
            this.btnBinarioADecimal.UseVisualStyleBackColor = true;
            // 
            // btnDecimalABinario
            // 
            this.btnDecimalABinario.Location = new System.Drawing.Point(334, 131);
            this.btnDecimalABinario.Name = "btnDecimalABinario";
            this.btnDecimalABinario.Size = new System.Drawing.Size(75, 23);
            this.btnDecimalABinario.TabIndex = 7;
            this.btnDecimalABinario.Text = "->";
            this.btnDecimalABinario.UseVisualStyleBackColor = true;
            // 
            // FrmEjercicio25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 299);
            this.Controls.Add(this.btnDecimalABinario);
            this.Controls.Add(this.btnBinarioADecimal);
            this.Controls.Add(this.textResultadoBinario);
            this.Controls.Add(this.textResultadoDecimal);
            this.Controls.Add(this.textDecimal);
            this.Controls.Add(this.textBinario);
            this.Controls.Add(this.lblDecimalBinario);
            this.Controls.Add(this.lblBinarioDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEjercicio25";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinarioDecimal;
        private System.Windows.Forms.Label lblDecimalBinario;
        private System.Windows.Forms.TextBox textBinario;
        private System.Windows.Forms.TextBox textDecimal;
        private System.Windows.Forms.TextBox textResultadoDecimal;
        private System.Windows.Forms.TextBox textResultadoBinario;
        private System.Windows.Forms.Button btnBinarioADecimal;
        private System.Windows.Forms.Button btnDecimalABinario;
    }
}

