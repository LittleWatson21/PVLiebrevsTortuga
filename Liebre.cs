using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Liebre_y_Tortuga
{
    class Liebre: Corredor
    {
        public Liebre(int numero) : base(numero)
        {
            this._Posicion = 0;
        }

        new public int avance()
        {
            int x = base.avance();

            //En esta variable se asigna el número random
            //Con lo cual le diremos como avanzará
            if (x <= 4)
            {
                _Posicion += 0;
            }
            else if (x <= 9)
            {
                _Posicion += 12;
            }
            else if (x <= 13)
            {
                _Posicion += 5;
            }
            else if (x <= 16)
            {
                _Posicion -= 4;
            }
            else if (x <= 20)
            {
                _Posicion -= 8;
            }
            return 0;

        }
         public override string ToString()
        {
            return numeroCorredor.ToString() + "Esta en" + _Posicion.ToString();
        }

    }
}
