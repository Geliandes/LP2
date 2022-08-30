namespace pAtividade8
{
    partial class frmExercicio6
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
            this.lbxNomes = new System.Windows.Forms.ListBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxNomes
            // 
            this.lbxNomes.FormattingEnabled = true;
            this.lbxNomes.ItemHeight = 16;
            this.lbxNomes.Location = new System.Drawing.Point(386, 100);
            this.lbxNomes.Name = "lbxNomes";
            this.lbxNomes.Size = new System.Drawing.Size(352, 212);
            this.lbxNomes.TabIndex = 3;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(63, 155);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(185, 141);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // frmExercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxNomes);
            this.Controls.Add(this.btnExecutar);
            this.Name = "frmExercicio6";
            this.Text = "frmExercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNomes;
        private System.Windows.Forms.Button btnExecutar;
    }
}