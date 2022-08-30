namespace pTesteMetodos
{
    partial class frmExercicio4
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
            this.btnCaractereAlfabético = new System.Windows.Forms.Button();
            this.btnCaractereBranco = new System.Windows.Forms.Button();
            this.btnContaNumeros = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.rchtxtPalavra = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCaractereAlfabético
            // 
            this.btnCaractereAlfabético.BackColor = System.Drawing.SystemColors.Control;
            this.btnCaractereAlfabético.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCaractereAlfabético.Location = new System.Drawing.Point(272, 106);
            this.btnCaractereAlfabético.Name = "btnCaractereAlfabético";
            this.btnCaractereAlfabético.Size = new System.Drawing.Size(104, 65);
            this.btnCaractereAlfabético.TabIndex = 20;
            this.btnCaractereAlfabético.Text = "Caractere Alfabético";
            this.btnCaractereAlfabético.UseVisualStyleBackColor = false;
            this.btnCaractereAlfabético.Click += new System.EventHandler(this.btnCaractereAlfabético_Click);
            // 
            // btnCaractereBranco
            // 
            this.btnCaractereBranco.BackColor = System.Drawing.SystemColors.Control;
            this.btnCaractereBranco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCaractereBranco.Location = new System.Drawing.Point(154, 106);
            this.btnCaractereBranco.Name = "btnCaractereBranco";
            this.btnCaractereBranco.Size = new System.Drawing.Size(112, 65);
            this.btnCaractereBranco.TabIndex = 19;
            this.btnCaractereBranco.Text = "Caractere Branco";
            this.btnCaractereBranco.UseVisualStyleBackColor = false;
            this.btnCaractereBranco.Click += new System.EventHandler(this.btnCaractereBranco_Click);
            // 
            // btnContaNumeros
            // 
            this.btnContaNumeros.BackColor = System.Drawing.SystemColors.Control;
            this.btnContaNumeros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContaNumeros.Location = new System.Drawing.Point(43, 106);
            this.btnContaNumeros.Name = "btnContaNumeros";
            this.btnContaNumeros.Size = new System.Drawing.Size(105, 65);
            this.btnContaNumeros.TabIndex = 18;
            this.btnContaNumeros.Text = "Caractere Numérico";
            this.btnContaNumeros.UseVisualStyleBackColor = false;
            this.btnContaNumeros.Click += new System.EventHandler(this.btnContaNumeros_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(52, 44);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(41, 16);
            this.lblTexto.TabIndex = 14;
            this.lblTexto.Text = "Texto";
            // 
            // rchtxtPalavra
            // 
            this.rchtxtPalavra.Location = new System.Drawing.Point(145, 41);
            this.rchtxtPalavra.Name = "rchtxtPalavra";
            this.rchtxtPalavra.Size = new System.Drawing.Size(207, 37);
            this.rchtxtPalavra.TabIndex = 21;
            this.rchtxtPalavra.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchtxtPalavra);
            this.Controls.Add(this.btnCaractereAlfabético);
            this.Controls.Add(this.btnCaractereBranco);
            this.Controls.Add(this.btnContaNumeros);
            this.Controls.Add(this.lblTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaractereAlfabético;
        private System.Windows.Forms.Button btnCaractereBranco;
        private System.Windows.Forms.Button btnContaNumeros;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.RichTextBox rchtxtPalavra;
    }
}