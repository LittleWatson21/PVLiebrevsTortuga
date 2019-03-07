using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Liebre_y_Tortuga
{
    class Corredor
    {
       
            private int _numeroCorredor;
            protected int _Posicion;
            private static Random gen = new Random();

            public Corredor(int numCorredor)
            {
                ///Asignamos el número del corredor
                ///1 Para liebre 
                ///2 Para Tortuga
                _numeroCorredor = numCorredor;
                _Posicion = 0;
            }
            public int numeroCorredor
            {
                get { return _numeroCorredor; }
            }

            public int Posicion
            {
                get { return _Posicion; }
            }

            public override string ToString()
            {
                return base.ToString();
            }

            public int avance()
            {
                return gen.Next(1, 21);
                //if(_numeroCorredor == 1)
                // {
                //     //En esta variable se asigna el número random
                //     //Con lo cual le diremos como avanzará
                //     int x = gen.Next(1, 20);
                //     if( x <5)
                //     {
                //         _Posicion += 0;
                //     }
                //     else if (x < 10)
                //     {
                //         _Posicion + = 12;
                //     }
                //     else if (x < 14)
                //     {
                //         _Posicion + = 5;
                //     }
                //     else if (x < 17)
                //     {
                //         _Posicion -= 4;
                //     }
                //     else if (x < 21)
                //     {
                //         _Posicion - = 8;
                //     }

                // }
            
            }

    }
}
