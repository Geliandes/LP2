namespace pAtividade8
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
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.lblNumeroN = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNumeroH = new System.Windows.Forms.Label();
            this.txtNumeroH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Location = new System.Drawing.Point(219, 87);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(142, 22);
            this.txtNumeroN.TabIndex = 0;
            // 
            // lblNumeroN
            // 
            this.lblNumeroN.AutoSize = true;
            this.lblNumeroN.Location = new System.Drawing.Point(133, 90);
            this.lblNumeroN.Name = "lblNumeroN";
            this.lblNumeroN.Size = new System.Drawing.Size(68, 16);
            this.lblNumeroN.TabIndex = 1;
            this.lblNumeroN.Text = "Numero N";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(213, 190);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(148, 57);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblNumeroH
            // 
            this.lblNumeroH.AutoSize = true;
            this.lblNumeroH.Location = new System.Drawing.Point(133, 132);
            this.lblNumeroH.Name = "lblNumeroH";
            this.lblNumeroH.Size = new System.Drawing.Size(68, 16);
            this.lblNumeroH.TabIndex = 3;
            this.lblNumeroH.Text = "Numero H";
            // 
            // txtNumeroH
            // 
            this.txtNumeroH.Enabled = false;
            this.txtNumeroH.Location = new System.Drawing.Point(219, 129);
            this.txtNumeroH.Name = "txtNumeroH";
            this.txtNumeroH.ReadOnly = true;
            this.txtNumeroH.Size = new System.Drawing.Size(142, 22);
            this.txtNumeroH.TabIndex = 4;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 338);
            this.Controls.Add(this.txtNumeroH);
            this.Controls.Add(this.lblNumeroH);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNumeroN);
            this.Controls.Add(this.txtNumeroN);
            this.Name = "frmExercicio2";
            this.Text = "Exercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.Label lblNumeroN;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNumeroH;
        private System.Windows.Forms.TextBox txtNumeroH;
    }
}