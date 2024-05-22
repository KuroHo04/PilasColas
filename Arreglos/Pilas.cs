using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Pilas
    {
        private string[] _arreglo;
        private int _actual;
        public Pilas(int tamanio)
        {
            _arreglo = new string[tamanio];
            _actual = 0;
        }

        private bool EstaVacio() 
        {
            return ( _actual == 0 );
        }
    }
}
