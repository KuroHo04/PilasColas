﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Colas
    {
        private string[] _arreglo;
        private int _principio;
        private int _final;
        public Colas(int tamaño)
        {
            _arreglo = new string[tamaño];
            _principio = 0;
            _final = 0;

        }
        private bool EstaVacio()
        {
            return ((_principio < 1 &&  _final < 1)
                || _principio == _final);
        }
        private bool EstaLleno()
        {
            int max = _arreglo.Length;
            return (_actual == max);
        }
        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            foreach (string dato in _arreglo)
            {
                if (!string.IsNullOrWhiteSpace(dato))
                {
                    datos.Append(dato);
                    datos.Append(Environment.NewLine);
                }
            }
            return datos.ToString();
        }
        public void Agregar(string dato)
        {
            if (EstaLleno())
            {
                throw new Exception("No hay espacio suficiente");
            }
            _arreglo[_final] = dato;
            _final++;
        }
        public void Eliminar()
        {
            if (EstaVacio())
            {
                throw new Exception("No hay elementos que eliminar");
            }
            _arreglo[_principio] = string.Empty;
            _principio++;
        }
    }
}