using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Models
{
    internal class Dinero
    {
        private int _monto_inicio;
        private int _D_ganado;
        private int _D_perdido;

        public int monto_inicio
        {
            get { return _monto_inicio; }
            set { _monto_inicio = value; }
        }

        public int D_ganado
        {
            get { return _D_ganado; }
            set { _D_ganado = value; }
        }

        public int D_perdido
        {
            get { return _D_perdido; }
            set { _D_perdido = value; }
        }

        public Dinero(int monto_inicio, int D_ganado, int D_perdido)
        {
            this._monto_inicio = monto_inicio;
            this._D_ganado = D_ganado;
            this.D_perdido = D_perdido;
        }

        public override string ToString()
        {
            return $"Monto total: {_monto_inicio}, Ganancia: {_D_ganado}, Perdida: {_D_perdido}";
        }
    }
}
