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
            this.txtFaturamento = new System.Windows.Forms.TextBox();
            this.lblFaturamento = new System.Windows.Forms.Label();
            this.lbxPrincipal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFaturamento
            // 
            this.txtFaturamento.Enabled = false;
            this.txtFaturamento.Location = new System.Drawing.Point(269, 339);
            this.txtFaturamento.Name = "txtFaturamento";
            this.txtFaturamento.Size = new System.Drawing.Size(148, 22);
            this.txtFaturamento.TabIndex = 7;
            // 
            // lblFaturamento
            // 
            this.lblFaturamento.AutoSize = true;
            this.lblFaturamento.Location = new System.Drawing.Point(181, 342);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Size = new System.Drawing.Size(82, 16);
            this.lblFaturamento.TabIndex = 6;
            this.lblFaturamento.Text = "Faturamento";
            // 
            // lbxPrincipal
            // 
            this.lbxPrincipal.ColumnWidth = 100;
            this.lbxPrincipal.FormattingEnabled = true;
            this.lbxPrincipal.ItemHeight = 16;
            this.lbxPrincipal.Location = new System.Drawing.Point(140, 69);
            this.lbxPrincipal.Name = "lbxPrincipal";
            this.lbxPrincipal.Size = new System.Drawing.Size(407, 244);
            this.lbxPrincipal.TabIndex = 5;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 431);
            this.Controls.Add(this.txtFaturamento);
            this.Controls.Add(this.lblFaturamento);
            this.Controls.Add(this.lbxPrincipal);
            this.Name = "frmExercicio2";
            this.Text = "Exercicio2";
            this.Load += new System.EventHandler(this.frmExercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFaturamento;
        private System.Windows.Forms.Label lblFaturamento;
        private System.Windows.Forms.ListBox lbxPrincipal;
    }
}