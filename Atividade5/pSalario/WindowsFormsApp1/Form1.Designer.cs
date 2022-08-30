namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumeroDeFilhos = new System.Windows.Forms.Label();
            this.mskbxNumeroDeFilhos = new System.Windows.Forms.MaskedTextBox();
            this.btnVerificarDesconto = new System.Windows.Forms.Button();
            this.lblAliquotaInss = new System.Windows.Forms.Label();
            this.lblAliquotaIrpf = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoIrpf = new System.Windows.Forms.Label();
            this.lblDescontoInss = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.pnlEstadoCivil = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.mskbxNomeFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliquotaInss = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliquotaIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescontoIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescontoInss = new System.Windows.Forms.MaskedTextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.pnlEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(28, 24);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(115, 16);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome funcionário ";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(28, 54);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(83, 16);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salario bruto";
            // 
            // lblNumeroDeFilhos
            // 
            this.lblNumeroDeFilhos.AutoSize = true;
            this.lblNumeroDeFilhos.Location = new System.Drawing.Point(28, 85);
            this.lblNumeroDeFilhos.Name = "lblNumeroDeFilhos";
            this.lblNumeroDeFilhos.Size = new System.Drawing.Size(108, 16);
            this.lblNumeroDeFilhos.TabIndex = 2;
            this.lblNumeroDeFilhos.Text = "Número de filhos";
            // 
            // mskbxNumeroDeFilhos
            // 
            this.mskbxNumeroDeFilhos.Location = new System.Drawing.Point(149, 79);
            this.mskbxNumeroDeFilhos.Name = "mskbxNumeroDeFilhos";
            this.mskbxNumeroDeFilhos.Size = new System.Drawing.Size(112, 22);
            this.mskbxNumeroDeFilhos.TabIndex = 3;
            this.mskbxNumeroDeFilhos.Validated += new System.EventHandler(this.mskbxNumeroDeFilhos_Validated);
            // 
            // btnVerificarDesconto
            // 
            this.btnVerificarDesconto.Location = new System.Drawing.Point(84, 122);
            this.btnVerificarDesconto.Name = "btnVerificarDesconto";
            this.btnVerificarDesconto.Size = new System.Drawing.Size(189, 33);
            this.btnVerificarDesconto.TabIndex = 7;
            this.btnVerificarDesconto.Text = "Verificar Desconto";
            this.btnVerificarDesconto.UseVisualStyleBackColor = true;
            this.btnVerificarDesconto.Click += new System.EventHandler(this.btnVerificarDesconto_Click);
            // 
            // lblAliquotaInss
            // 
            this.lblAliquotaInss.AutoSize = true;
            this.lblAliquotaInss.Location = new System.Drawing.Point(28, 292);
            this.lblAliquotaInss.Name = "lblAliquotaInss";
            this.lblAliquotaInss.Size = new System.Drawing.Size(90, 16);
            this.lblAliquotaInss.TabIndex = 11;
            this.lblAliquotaInss.Text = "Aliquota INSS";
            // 
            // lblAliquotaIrpf
            // 
            this.lblAliquotaIrpf.AutoSize = true;
            this.lblAliquotaIrpf.Location = new System.Drawing.Point(28, 324);
            this.lblAliquotaIrpf.Name = "lblAliquotaIrpf";
            this.lblAliquotaIrpf.Size = new System.Drawing.Size(89, 16);
            this.lblAliquotaIrpf.TabIndex = 13;
            this.lblAliquotaIrpf.Text = "Aliquota IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(28, 354);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioFamilia.TabIndex = 15;
            this.lblSalarioFamilia.Text = "Salario Família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(28, 383);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioLiquido.TabIndex = 17;
            this.lblSalarioLiquido.Text = "Salario Liquido";
            // 
            // lblDescontoIrpf
            // 
            this.lblDescontoIrpf.AutoSize = true;
            this.lblDescontoIrpf.Location = new System.Drawing.Point(298, 324);
            this.lblDescontoIrpf.Name = "lblDescontoIrpf";
            this.lblDescontoIrpf.Size = new System.Drawing.Size(98, 16);
            this.lblDescontoIrpf.TabIndex = 21;
            this.lblDescontoIrpf.Text = "Desconto IRPF";
            // 
            // lblDescontoInss
            // 
            this.lblDescontoInss.AutoSize = true;
            this.lblDescontoInss.Location = new System.Drawing.Point(298, 292);
            this.lblDescontoInss.Name = "lblDescontoInss";
            this.lblDescontoInss.Size = new System.Drawing.Size(99, 16);
            this.lblDescontoInss.TabIndex = 19;
            this.lblDescontoInss.Text = "Desconto INSS";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Location = new System.Drawing.Point(379, 18);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(148, 111);
            this.gbxSexo.TabIndex = 23;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(18, 38);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(39, 20);
            this.rbtnMasculino.TabIndex = 5;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(18, 70);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(36, 20);
            this.rbtnFeminino.TabIndex = 4;
            this.rbtnFeminino.Text = "F";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // pnlEstadoCivil
            // 
            this.pnlEstadoCivil.Controls.Add(this.ckbxCasado);
            this.pnlEstadoCivil.Location = new System.Drawing.Point(379, 148);
            this.pnlEstadoCivil.Name = "pnlEstadoCivil";
            this.pnlEstadoCivil.Size = new System.Drawing.Size(148, 50);
            this.pnlEstadoCivil.TabIndex = 24;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(18, 16);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(77, 20);
            this.ckbxCasado.TabIndex = 6;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // mskbxNomeFuncionario
            // 
            this.mskbxNomeFuncionario.Location = new System.Drawing.Point(149, 18);
            this.mskbxNomeFuncionario.Name = "mskbxNomeFuncionario";
            this.mskbxNomeFuncionario.Size = new System.Drawing.Size(173, 22);
            this.mskbxNomeFuncionario.TabIndex = 1;
            this.mskbxNomeFuncionario.Validated += new System.EventHandler(this.mskbxNomeFuncionario_Validated);
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(149, 48);
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(112, 22);
            this.mskbxSalarioBruto.TabIndex = 2;
            this.mskbxSalarioBruto.Validated += new System.EventHandler(this.mskbxSalarioBruto_Validated);
            // 
            // mskbxAliquotaInss
            // 
            this.mskbxAliquotaInss.Enabled = false;
            this.mskbxAliquotaInss.Location = new System.Drawing.Point(149, 289);
            this.mskbxAliquotaInss.Name = "mskbxAliquotaInss";
            this.mskbxAliquotaInss.Size = new System.Drawing.Size(124, 22);
            this.mskbxAliquotaInss.TabIndex = 27;
            // 
            // mskbxAliquotaIrpf
            // 
            this.mskbxAliquotaIrpf.Enabled = false;
            this.mskbxAliquotaIrpf.Location = new System.Drawing.Point(149, 318);
            this.mskbxAliquotaIrpf.Name = "mskbxAliquotaIrpf";
            this.mskbxAliquotaIrpf.Size = new System.Drawing.Size(124, 22);
            this.mskbxAliquotaIrpf.TabIndex = 28;
            // 
            // mskbxSalarioLiquido
            // 
            this.mskbxSalarioLiquido.Enabled = false;
            this.mskbxSalarioLiquido.Location = new System.Drawing.Point(149, 377);
            this.mskbxSalarioLiquido.Name = "mskbxSalarioLiquido";
            this.mskbxSalarioLiquido.Size = new System.Drawing.Size(124, 22);
            this.mskbxSalarioLiquido.TabIndex = 30;
            // 
            // mskbxSalarioFamilia
            // 
            this.mskbxSalarioFamilia.Enabled = false;
            this.mskbxSalarioFamilia.Location = new System.Drawing.Point(149, 348);
            this.mskbxSalarioFamilia.Name = "mskbxSalarioFamilia";
            this.mskbxSalarioFamilia.Size = new System.Drawing.Size(124, 22);
            this.mskbxSalarioFamilia.TabIndex = 29;
            // 
            // mskbxDescontoIrpf
            // 
            this.mskbxDescontoIrpf.Enabled = false;
            this.mskbxDescontoIrpf.Location = new System.Drawing.Point(403, 321);
            this.mskbxDescontoIrpf.Name = "mskbxDescontoIrpf";
            this.mskbxDescontoIrpf.Size = new System.Drawing.Size(124, 22);
            this.mskbxDescontoIrpf.TabIndex = 32;
            // 
            // mskbxDescontoInss
            // 
            this.mskbxDescontoInss.Enabled = false;
            this.mskbxDescontoInss.Location = new System.Drawing.Point(403, 289);
            this.mskbxDescontoInss.Name = "mskbxDescontoInss";
            this.mskbxDescontoInss.Size = new System.Drawing.Size(124, 22);
            this.mskbxDescontoInss.TabIndex = 31;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDados.Location = new System.Drawing.Point(28, 165);
            this.lblDados.MaximumSize = new System.Drawing.Size(220, 110);
            this.lblDados.MinimumSize = new System.Drawing.Size(220, 110);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(220, 110);
            this.lblDados.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 416);
            this.Controls.Add(this.mskbxDescontoIrpf);
            this.Controls.Add(this.mskbxDescontoInss);
            this.Controls.Add(this.mskbxSalarioLiquido);
            this.Controls.Add(this.mskbxSalarioFamilia);
            this.Controls.Add(this.mskbxAliquotaIrpf);
            this.Controls.Add(this.mskbxAliquotaInss);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.mskbxNomeFuncionario);
            this.Controls.Add(this.pnlEstadoCivil);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.lblDescontoIrpf);
            this.Controls.Add(this.lblDescontoInss);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIrpf);
            this.Controls.Add(this.lblAliquotaInss);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnVerificarDesconto);
            this.Controls.Add(this.mskbxNumeroDeFilhos);
            this.Controls.Add(this.lblNumeroDeFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Name = "Form1";
            this.Text = "Salário";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.pnlEstadoCivil.ResumeLayout(false);
            this.pnlEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumeroDeFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxNumeroDeFilhos;
        private System.Windows.Forms.Button btnVerificarDesconto;
        private System.Windows.Forms.Label lblAliquotaInss;
        private System.Windows.Forms.Label lblAliquotaIrpf;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoIrpf;
        private System.Windows.Forms.Label lblDescontoInss;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Panel pnlEstadoCivil;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.MaskedTextBox mskbxNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaInss;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaIrpf;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxDescontoIrpf;
        private System.Windows.Forms.MaskedTextBox mskbxDescontoInss;
        private System.Windows.Forms.Label lblDados;
    }
}

