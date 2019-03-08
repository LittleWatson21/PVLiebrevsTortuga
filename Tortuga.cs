using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Liebre_y_Tortuga
{
    class Tortuga: Corredor
    {
        public Tortuga(int numero) : base(numero)
        {
            this._Posicion = 0;
        }

        new public int avance()
        {
            int x = base.avance();

            //En esta variable se asigna el número random
            //Con lo cual le diremos como avanzará
            if (x <= 8)
            {
                _Posicion += 3;
            }
            else if (x <= 12)
            {
                _Posicion += 6;
            }
            else if (x <= 16)
            {
                _Posicion -= 5;
            }
            else if (x <= 20)
            {
                _Posicion -= 9;
            }
            return 0;
        }
        /*
          public override string ToString()
        {
            return numeroCorredor.ToString() + "Esta en" + _Posicion.ToString();
        }
        Si te fijas, tienes el mismo codigo aqui que en liebre y las dos son clases que heredan de la misma, entonces
        la que debería tener escrito este método es la clase padre y en automatico se hereda a las otras dos
        */

    }
}
