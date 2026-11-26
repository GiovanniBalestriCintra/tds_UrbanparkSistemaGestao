namespace frmUrbanPark
{
    partial class FormRegistrarSaida
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
            panel1 = new Panel();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            lblCorModelo = new Label();
            lblCliente = new Label();
            dtInfoHrEntrada = new DateTimePicker();
            txtCorModelo = new TextBox();
            txtNomeCliente = new TextBox();
            lblDataSaida = new Label();
            pictureBox1 = new PictureBox();
            grpMovimentacao = new GroupBox();
            dtInfoDtEntrada = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lblDataHoraEntrada = new Label();
            lblHoraSaida = new Label();
            maskedTextBox1 = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            btnBuscarPorPlaca = new Button();
            grpDadosVeiculo = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblVaga = new Label();
            lblPlaca = new Label();
            grpBuscarVeiculo = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpMovimentacao.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpBuscarVeiculo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrarEntrada);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 12;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(223, 247, 231);
            btnRegistrarEntrada.Image = Properties.Resources.icoConfirmado;
            btnRegistrarEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEntrada.Location = new Point(526, 15);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(148, 23);
            btnRegistrarEntrada.TabIndex = 4;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(254, 224, 221);
            btnCancelar.Image = Properties.Resources.IcoCancelar;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(680, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = SystemColors.Desktop;
            lblCorModelo.Location = new Point(15, 92);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(91, 17);
            lblCorModelo.TabIndex = 0;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.Desktop;
            lblCliente.Location = new Point(15, 26);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 17);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // dtInfoHrEntrada
            // 
            dtInfoHrEntrada.CustomFormat = "HH:mm";
            dtInfoHrEntrada.Font = new Font("Microsoft Sans Serif", 8.25F);
            dtInfoHrEntrada.Format = DateTimePickerFormat.Short;
            dtInfoHrEntrada.Location = new Point(115, 57);
            dtInfoHrEntrada.Name = "dtInfoHrEntrada";
            dtInfoHrEntrada.ShowUpDown = true;
            dtInfoHrEntrada.Size = new Size(90, 20);
            dtInfoHrEntrada.TabIndex = 3;
            // 
            // txtCorModelo
            // 
            txtCorModelo.Location = new Point(112, 89);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(200, 25);
            txtCorModelo.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(112, 23);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(200, 25);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataSaida.ForeColor = SystemColors.Desktop;
            lblDataSaida.Location = new Point(15, 57);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(94, 17);
            lblDataSaida.TabIndex = 0;
            lblDataSaida.Text = "Data de Saída:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.BannerSaida;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(dateTimePicker1);
            grpMovimentacao.Controls.Add(dtInfoHrEntrada);
            grpMovimentacao.Controls.Add(lblDataHoraEntrada);
            grpMovimentacao.Controls.Add(lblHoraSaida);
            grpMovimentacao.Controls.Add(lblDataSaida);
            grpMovimentacao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = SystemColors.HotTrack;
            grpMovimentacao.Location = new Point(366, 183);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(410, 194);
            grpMovimentacao.TabIndex = 9;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CustomFormat = "dd/MM/yyyy HH:mm";
            dtInfoDtEntrada.Font = new Font("Microsoft Sans Serif", 8.25F);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Custom;
            dtInfoDtEntrada.Location = new Point(173, 28);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(169, 20);
            dtInfoDtEntrada.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(311, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(90, 20);
            dateTimePicker1.TabIndex = 3;
            // 
            // lblDataHoraEntrada
            // 
            lblDataHoraEntrada.AutoSize = true;
            lblDataHoraEntrada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataHoraEntrada.ForeColor = SystemColors.Desktop;
            lblDataHoraEntrada.Location = new Point(15, 26);
            lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            lblDataHoraEntrada.Size = new Size(152, 17);
            lblDataHoraEntrada.TabIndex = 0;
            lblDataHoraEntrada.Text = "Data / Hora de Entrada:";
            // 
            // lblHoraSaida
            // 
            lblHoraSaida.AutoSize = true;
            lblHoraSaida.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraSaida.ForeColor = SystemColors.Desktop;
            lblHoraSaida.Location = new Point(209, 57);
            lblHoraSaida.Name = "lblHoraSaida";
            lblHoraSaida.Size = new Size(96, 17);
            lblHoraSaida.TabIndex = 0;
            lblHoraSaida.Text = "Hora de Saída:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(152, 27);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(133, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = SystemColors.Desktop;
            lblPlacaVeiculo.Location = new Point(26, 32);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(108, 17);
            lblPlacaVeiculo.TabIndex = 1;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.Font = new Font("Segoe UI", 9.75F);
            btnBuscarPorPlaca.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarPorPlaca.Image = Properties.Resources.IcoPesquisaAzul;
            btnBuscarPorPlaca.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPorPlaca.Location = new Point(408, 27);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(158, 30);
            btnBuscarPorPlaca.TabIndex = 0;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(textBox2);
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(textBox1);
            grpDadosVeiculo.Controls.Add(lblVaga);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = SystemColors.HotTrack;
            grpDadosVeiculo.Location = new Point(20, 183);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(340, 194);
            grpDadosVeiculo.TabIndex = 10;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 25);
            textBox1.TabIndex = 1;
            // 
            // lblVaga
            // 
            lblVaga.AutoSize = true;
            lblVaga.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVaga.ForeColor = SystemColors.Desktop;
            lblVaga.Location = new Point(15, 123);
            lblVaga.Name = "lblVaga";
            lblVaga.Size = new Size(40, 17);
            lblVaga.TabIndex = 0;
            lblVaga.Text = "Vaga:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaca.ForeColor = SystemColors.Desktop;
            lblPlaca.Location = new Point(15, 60);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(42, 17);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Placa:";
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(maskedTextBox1);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = SystemColors.HotTrack;
            grpBuscarVeiculo.Location = new Point(20, 103);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(756, 74);
            grpBuscarVeiculo.TabIndex = 8;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // FormRegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Name = "FormRegistrarSaida";
            Text = "FormRegistrarSaida";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
        private Label lblCorModelo;
        private Label lblCliente;
        private DateTimePicker dtInfoHrEntrada;
        private TextBox txtCorModelo;
        private TextBox txtNomeCliente;
        private Label lblDataSaida;
        private PictureBox pictureBox1;
        private GroupBox grpMovimentacao;
        private MaskedTextBox maskedTextBox1;
        private Label lblPlacaVeiculo;
        private Button btnBuscarPorPlaca;
        private GroupBox grpDadosVeiculo;
        private GroupBox grpBuscarVeiculo;
        private Label lblPlaca;
        private TextBox textBox1;
        private DateTimePicker dtInfoDtEntrada;
        private Label lblDataHoraEntrada;
        private TextBox textBox2;
        private Label lblVaga;
        private DateTimePicker dateTimePicker1;
        private Label lblHoraSaida;
    }
}