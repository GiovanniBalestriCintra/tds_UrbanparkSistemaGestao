namespace frmUrbanPark.Parts
{
    partial class ctrStatusVagas
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            picStatusVaga = new PictureBox();
            lblNumeroVaga = new Label();
            ((System.ComponentModel.ISupportInitialize)picStatusVaga).BeginInit();
            SuspendLayout();
            // 
            // picStatusVaga
            // 
            picStatusVaga.Image = Properties.Resources.carIconVerde;
            picStatusVaga.Location = new Point(47, 76);
            picStatusVaga.Margin = new Padding(3, 4, 3, 4);
            picStatusVaga.Name = "picStatusVaga";
            picStatusVaga.Size = new Size(52, 55);
            picStatusVaga.TabIndex = 0;
            picStatusVaga.TabStop = false;
            // 
            // lblNumeroVaga
            // 
            lblNumeroVaga.Dock = DockStyle.Top;
            lblNumeroVaga.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroVaga.Location = new Point(0, 0);
            lblNumeroVaga.Name = "lblNumeroVaga";
            lblNumeroVaga.Size = new Size(149, 72);
            lblNumeroVaga.TabIndex = 1;
            lblNumeroVaga.Text = "01";
            lblNumeroVaga.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrStatusVagas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 247, 231);
            Controls.Add(lblNumeroVaga);
            Controls.Add(picStatusVaga);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ctrStatusVagas";
            Size = new Size(149, 173);
            Load += ctrStatusVagas_Load;
            ((System.ComponentModel.ISupportInitialize)picStatusVaga).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picStatusVaga;
        private Label lblNumeroVaga;
    }
}
