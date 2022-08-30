namespace pTesteMetodos
{
    partial class frmExercicio2
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnIguais = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAsteriscos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(26, 29);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(64, 16);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(26, 66);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(64, 16);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(119, 26);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(207, 22);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(119, 63);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(207, 22);
            this.txtPalavra2.TabIndex = 3;
            // 
            // btnIguais
            // 
            this.btnIguais.BackColor = System.Drawing.SystemColors.Control;
            this.btnIguais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIguais.Location = new System.Drawing.Point(29, 115);
            this.btnIguais.Name = "btnIguais";
            this.btnIguais.Size = new System.Drawing.Size(95, 30);
            this.btnIguais.TabIndex = 4;
            this.btnIguais.Text = "Iguais";
            this.btnIguais.UseVisualStyleBackColor = false;
            this.btnIguais.Click += new System.EventHandler(this.btnIguais_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInserir.Location = new System.Drawing.Point(130, 115);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(95, 30);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAsteriscos
            // 
            this.btnAsteriscos.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsteriscos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAsteriscos.Location = new System.Drawing.Point(231, 115);
            this.btnAsteriscos.Name = "btnAsteriscos";
            this.btnAsteriscos.Size = new System.Drawing.Size(95, 30);
            this.btnAsteriscos.TabIndex = 6;
            this.btnAsteriscos.Text = "Asteriscos";
            this.btnAsteriscos.UseVisualStyleBackColor = false;
            this.btnAsteriscos.Click += new System.EventHandler(this.btnAsteriscos_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(372, 177);
            this.Controls.Add(this.btnAsteriscos);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnIguais);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnIguais;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAsteriscos;
    }
}