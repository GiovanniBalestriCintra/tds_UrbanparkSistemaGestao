using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backUrbanPark.Model
{
    internal class Vaga
    {

        // Variáveis
        private int _id;
        private int _numeroVaga;
        private TipoVaga _tipoVaga;
        private TipoStatus _tipostatus;


        public int Id { get => _id; set => _id = value; }
        public int NumeroVaga { get => _numeroVaga; set => _numeroVaga = value; }
        internal TipoVaga TipoVaga { get => _tipoVaga; set => _tipoVaga = value; }
        internal TipoStatus Tipostatus { get => _tipostatus; set => _tipostatus = value; }


        public Vaga(int numeroVaga, TipoVaga tipoVaga, TipoStatus tipostatus)
        {
            _numeroVaga = numeroVaga;
            _tipoVaga = tipoVaga;
            _tipostatus = tipostatus;
        }

        public Vaga(int id, int numeroVaga, TipoVaga tipoVaga, TipoStatus tipostatus)
        {
            _id = id;
            _numeroVaga = numeroVaga;
            _tipoVaga = tipoVaga;
            _tipostatus = tipostatus;
        }

    }
}
