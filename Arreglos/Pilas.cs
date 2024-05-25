using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Pilas
    {
        private string[] _elementos;
        private int _actual;
        public Pilas(int tamaño)
        {
            _elementos = new string[tamanio];
            _actual = 0;
        }

        private bool EstaVacio() 
        {
            return ( _actual == 0 );
        }
        private bool EstaLleno() 
        {
            int max = _elementos.Length;
            return ( _actual > max );
        }
        private string ObtenerDatos() 
        {
            StringBuilder datos = new StringBuilder();
            foreach ( string dato in _elementos ) 
            {
                if (!string.IsNullOrWhiteSpace(dato))
                {
                datos.Append( dato );
                datos.Append(Environment.NewLine);
                }
            }
            return  datos.ToString();
        }
        public void Agregar(string dato) 
        {
            if ( EstaLleno()) 
            {
                throw new Exception("No hay espacio suficiente");
            }
            _elementos[_actual] = dato;
            _actual++;
        }
        public void Eliminar() 
        {
            if (EstaVacio())
            {
                throw new Exception("No hay elementos");
                _actual--;
                _elementos[_actual]= string.Empty;

            }
        }

    }
}
