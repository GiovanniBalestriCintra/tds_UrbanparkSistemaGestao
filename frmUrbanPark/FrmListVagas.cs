using backUrbanPark.Model;
using backUrbanPark.Repository;
using frmUrbanPark.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUrbanPark
{
    public partial class FrmListVagas : Form
    {
        public FrmListVagas()
        {
            InitializeComponent();
        }

        private void FrmListVagas_Load(object sender, EventArgs e)
        {

            CarregarDadosEMontarVisualizacao();

        }


        private void CarregarDadosEMontarVisualizacao()
        {

            List<Vaga> listaDeVagas = VagaRepository.ListarTodos();

            flwCardVagas.Controls.Clear();

            foreach (Vaga vaga in listaDeVagas)
            {
                string strNumeroVaga = vaga.NumeroVaga.ToString();
                StatusVaga statusVaga = Enum.Parse<StatusVaga>(vaga.TipoStatus.ToString());
                int idVaga = vaga.Id;

                ctrStatusVagas cardVaga = new ctrStatusVagas();

                cardVaga.IdVaga = idVaga;
                cardVaga.StatusVaga = statusVaga;
                cardVaga.NumeroVaga = strNumeroVaga;

                cardVaga.cardClicado += cardVaga_click;

                flwCardVagas.Controls.Add(cardVaga);


            }

        }


        private void cardVaga_click(object sender, EventArgs e)
        {

            ctrStatusVagas cardSelecionado = (ctrStatusVagas)sender;

            if (cardSelecionado.StatusVaga == StatusVaga.Livre)
            {
                // Inicializa o formulário de entrada e passa as informações da vaga.
                FrmRegistrarEntrada frmEntrada = new FrmRegistrarEntrada(cardSelecionado.NumeroVaga, cardSelecionado.IdVaga);

                frmEntrada.ShowDialog();
            }
            else
            {
                FrmRegistrarSaida frmSaida = new FrmRegistrarSaida();
                frmSaida.ShowDialog();
            }

        }



    } // Classe

} // Namespace
