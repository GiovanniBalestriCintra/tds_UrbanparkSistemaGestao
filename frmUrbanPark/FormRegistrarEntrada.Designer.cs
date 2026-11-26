namespace frmUrbanPark
{
    partial class FrmRegistrarEntrada
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
            grpBuscarVeiculo = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            btnBuscarPorPlaca = new Button();
            grpMovimentacao = new GroupBox();
            dtInfoDtEntrada = new DateTimePicker();
            dtInfoHrEntrada = new DateTimePicker();
            lblDataEntrada = new Label();
            lblVagaSelecionada = new Label();
            lblHoraEntrada = new Label();
            txtVagaSelecionada = new TextBox();
            grpDadosVeiculo = new GroupBox();
            txtCorModelo = new TextBox();
            txtNomeCliente = new TextBox();
            lblCorModelo = new Label();
            lblCliente = new Label();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            BannerEntrada = new PictureBox();
            panel1 = new Panel();
            grpBuscarVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BannerEntrada).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(maskedTextBox1);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = SystemColors.HotTrack;
            grpBuscarVeiculo.Location = new Point(23, 137);
            grpBuscarVeiculo.Margin = new Padding(3, 4, 3, 4);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Padding = new Padding(3, 4, 3, 4);
            grpBuscarVeiculo.Size = new Size(864, 133);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(179, 51);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(151, 32);
            maskedTextBox1.TabIndex = 2;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = SystemColors.Desktop;
            lblPlacaVeiculo.Location = new Point(30, 55);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(139, 23);
            lblPlacaVeiculo.TabIndex = 1;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.Font = new Font("Segoe UI", 9.75F);
            btnBuscarPorPlaca.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarPorPlaca.Image = Properties.Resources.IcoPesquisaAzul;
            btnBuscarPorPlaca.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPorPlaca.Location = new Point(417, 51);
            btnBuscarPorPlaca.Margin = new Padding(3, 4, 3, 4);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(181, 40);
            btnBuscarPorPlaca.TabIndex = 0;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(dtInfoHrEntrada);
            grpMovimentacao.Controls.Add(lblDataEntrada);
            grpMovimentacao.Controls.Add(lblVagaSelecionada);
            grpMovimentacao.Controls.Add(lblHoraEntrada);
            grpMovimentacao.Controls.Add(txtVagaSelecionada);
            grpMovimentacao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = SystemColors.HotTrack;
            grpMovimentacao.Location = new Point(489, 300);
            grpMovimentacao.Margin = new Padding(3, 4, 3, 4);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Padding = new Padding(3, 4, 3, 4);
            grpMovimentacao.Size = new Size(398, 203);
            grpMovimentacao.TabIndex = 2;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.Font = new Font("Microsoft Sans Serif", 8.25F);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.Location = new Point(171, 93);
            dtInfoDtEntrada.Margin = new Padding(3, 4, 3, 4);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(190, 23);
            dtInfoDtEntrada.TabIndex = 4;
            // 
            // dtInfoHrEntrada
            // 
            dtInfoHrEntrada.CustomFormat = "HH:mm";
            dtInfoHrEntrada.Font = new Font("Microsoft Sans Serif", 8.25F);
            dtInfoHrEntrada.Format = DateTimePickerFormat.Custom;
            dtInfoHrEntrada.Location = new Point(171, 137);
            dtInfoHrEntrada.Margin = new Padding(3, 4, 3, 4);
            dtInfoHrEntrada.Name = "dtInfoHrEntrada";
            dtInfoHrEntrada.ShowUpDown = true;
            dtInfoHrEntrada.Size = new Size(130, 23);
            dtInfoHrEntrada.TabIndex = 3;
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = SystemColors.Desktop;
            lblDataEntrada.Location = new Point(17, 96);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(138, 23);
            lblDataEntrada.TabIndex = 0;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVagaSelecionada.ForeColor = SystemColors.Desktop;
            lblVagaSelecionada.Location = new Point(17, 51);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(148, 23);
            lblVagaSelecionada.TabIndex = 0;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraEntrada.ForeColor = SystemColors.Desktop;
            lblHoraEntrada.Location = new Point(17, 139);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(140, 23);
            lblHoraEntrada.TabIndex = 0;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.BackColor = SystemColors.ScrollBar;
            txtVagaSelecionada.Location = new Point(171, 47);
            txtVagaSelecionada.Margin = new Padding(3, 4, 3, 4);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(190, 29);
            txtVagaSelecionada.TabIndex = 1;
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = SystemColors.HotTrack;
            grpDadosVeiculo.Location = new Point(23, 300);
            grpDadosVeiculo.Margin = new Padding(3, 4, 3, 4);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Padding = new Padding(3, 4, 3, 4);
            grpDadosVeiculo.Size = new Size(429, 203);
            grpDadosVeiculo.TabIndex = 3;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // txtCorModelo
            // 
            txtCorModelo.BackColor = SystemColors.ScrollBar;
            txtCorModelo.Location = new Point(152, 104);
            txtCorModelo.Margin = new Padding(3, 4, 3, 4);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(228, 29);
            txtCorModelo.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = SystemColors.ScrollBar;
            txtNomeCliente.Location = new Point(152, 47);
            txtNomeCliente.Margin = new Padding(3, 4, 3, 4);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(228, 29);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = SystemColors.Desktop;
            lblCorModelo.Location = new Point(17, 104);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(117, 23);
            lblCorModelo.TabIndex = 0;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.Desktop;
            lblCliente.Location = new Point(17, 51);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(67, 23);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(223, 247, 231);
            btnRegistrarEntrada.Image = Properties.Resources.icoConfirmado;
            btnRegistrarEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEntrada.Location = new Point(601, 20);
            btnRegistrarEntrada.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(169, 31);
            btnRegistrarEntrada.TabIndex = 4;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(254, 224, 221);
            btnCancelar.Image = Properties.Resources.IcoCancelar;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(777, 20);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 31);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // BannerEntrada
            // 
            BannerEntrada.Dock = DockStyle.Top;
            BannerEntrada.Image = Properties.Resources.BannerEntrada;
            BannerEntrada.Location = new Point(0, 0);
            BannerEntrada.Margin = new Padding(3, 4, 3, 4);
            BannerEntrada.Name = "BannerEntrada";
            BannerEntrada.Size = new Size(914, 124);
            BannerEntrada.SizeMode = PictureBoxSizeMode.Zoom;
            BannerEntrada.TabIndex = 6;
            BannerEntrada.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrarEntrada);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 533);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 67);
            panel1.TabIndex = 7;
            // 
            // FrmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(BannerEntrada);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpBuscarVeiculo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRegistrarEntrada";
            Text = "Registrar Entrada";
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BannerEntrada).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpBuscarVeiculo;
        private GroupBox grpMovimentacao;
        private GroupBox grpDadosVeiculo;
        private Button btnBuscarPorPlaca;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
        private Label lblPlacaVeiculo;
        private MaskedTextBox maskedTextBox1;
        private Label lblCliente;
        private TextBox txtNomeCliente;
        private TextBox txtCorModelo;
        private Label lblCorModelo;
        private Label lblDataEntrada;
        private Label lblVagaSelecionada;
        private TextBox txtVagaSelecionada;
        private DateTimePicker dtInfoDtEntrada;
        private DateTimePicker dtInfoHrEntrada;
        private Label lblHoraEntrada;
        private PictureBox BannerEntrada;
        private Panel panel1;
    }
}