using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Models
{
    internal class Dados
    {
        private int _num_aleatorio;
        private int _num_dado;

        public int num_aleatorio 
        {
            get { return _num_aleatorio; }
            set { _num_aleatorio = value; }
        }

        public int num_dado
        {
            get { return _num_dado; }
            set { _num_dado = value; }
        }

        public Dados(int num_aleatorio, int num_dado)
        {
            this._num_aleatorio = num_aleatorio;
            this._num_dado = num_dado;
        }

        public override String ToString()
        {
            if (num_dado == 1)
            {
                if (num_aleatorio == 1)
                {
                    return "╔═══╗" + "\n" + "║   ║" + "\n" + "║ * ║" + "\n" + "║   ║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 2)
                {
                    return "╔═══╗" + "\n" + "║*  ║" + "\n" + "║   ║" + "\n" + "║  *║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 3)
                {
                    return "╔═══╗" + "\n" + "║*  ║" + "\n" + "║ * ║" + "\n" + "║  *║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 4)
                {
                    return "╔═══╗" + "\n" + "║* *║" + "\n" + "║   ║" + "\n" + "║* *║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 5)
                {
                    return "╔═══╗" + "\n" + "║* *║" + "\n" + "║ * ║" + "\n" + "║* *║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 6)
                {
                    return "╔═══╗" + "\n" + "║* *║" + "\n" + "║* *║" + "\n" + "║* *║" + "\n" + "╚═══╝" + "\n";
                }
                else
                {
                    return "Valor invalido";
                }
            }
            else if(num_dado == 2)
            {
                if (num_aleatorio == 1)
                {
                    return "╔═══╗" + "\n" + "║   ║" + "\n" + "║ * ║" + "\n" + "║   ║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 2)
                {
                    return "╔═══╗" + "\n" + "║*  ║" + "\n" + "║   ║" + "\n" + "║  *║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 3)
                {
                    return "╔═══╗" + "\n" + "║*  ║" + "\n" + "║ * ║" + "\n" + "║  *║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 4)
                {
                    return "╔═══╗" + "\n" + "║* *║" + "\n" + "║   ║" + "\n" + "║* *║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 5)
                {
                    return "╔═══╗" + "\n" + "║* *║" + "\n" + "║ * ║" + "\n" + "║* *║" + "\n" + "╚═══╝" + "\n";
                }
                else if (num_aleatorio == 6)
                {
                    return "╔═══╗" + "\n" + "║* *║" + "\n" + "║* *║" + "\n" + "║* *║" + "\n" + "╚═══╝" + "\n";
                }
                else
                {
                    return "Valor invalido";
                }
            }
            else
            {
                return "Dado incorrecto";
            }
        }
    }
}
