namespace pAtividade8
{
    partial class frmExercicio1
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
            this.rchtxtFrase1 = new System.Windows.Forms.RichTextBox();
            this.btnEspacos = new System.Windows.Forms.Button();
            this.btnContaR = new System.Windows.Forms.Button();
            this.btnOcorrencias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase1
            // 
            this.rchtxtFrase1.Location = new System.Drawing.Point(138, 54);
            this.rchtxtFrase1.MaxLength = 100;
            this.rchtxtFrase1.Name = "rchtxtFrase1";
            this.rchtxtFrase1.Size = new System.Drawing.Size(499, 137);
            this.rchtxtFrase1.TabIndex = 0;
            this.rchtxtFrase1.Text = "";
            // 
            // btnEspacos
            // 
            this.btnEspacos.Location = new System.Drawing.Point(83, 278);
            this.btnEspacos.Name = "btnEspacos";
            this.btnEspacos.Size = new System.Drawing.Size(179, 96);
            this.btnEspacos.TabIndex = 1;
            this.btnEspacos.Text = "Espaços em branco";
            this.btnEspacos.UseVisualStyleBackColor = true;
            this.btnEspacos.Click += new System.EventHandler(this.btnEspacos_Click);
            // 
            // btnContaR
            // 
            this.btnContaR.Location = new System.Drawing.Point(307, 278);
            this.btnContaR.Name = "btnContaR";
            this.btnContaR.Size = new System.Drawing.Size(179, 96);
            this.btnContaR.TabIndex = 2;
            this.btnContaR.Text = "Conta letras R";
            this.btnContaR.UseVisualStyleBackColor = true;
            this.btnContaR.Click += new System.EventHandler(this.btnContaR_Click);
            // 
            // btnOcorrencias
            // 
            this.btnOcorrencias.Location = new System.Drawing.Point(538, 278);
            this.btnOcorrencias.Name = "btnOcorrencias";
            this.btnOcorrencias.Size = new System.Drawing.Size(179, 96);
            this.btnOcorrencias.TabIndex = 3;
            this.btnOcorrencias.Text = "Letra repetida (ocorrências)";
            this.btnOcorrencias.UseVisualStyleBackColor = true;
            this.btnOcorrencias.Click += new System.EventHandler(this.btnOcorrencias_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOcorrencias);
            this.Controls.Add(this.btnContaR);
            this.Controls.Add(this.btnEspacos);
            this.Controls.Add(this.rchtxtFrase1);
            this.Name = "frmExercicio1";
            this.Text = "Exercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase1;
        private System.Windows.Forms.Button btnEspacos;
        private System.Windows.Forms.Button btnContaR;
        private System.Windows.Forms.Button btnOcorrencias;
    }
}