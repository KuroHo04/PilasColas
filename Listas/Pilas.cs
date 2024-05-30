
using System.Text;

namespace Listas
{
    public class Pilas
    {
        private List<string> _list;
        public Pilas()
        {
            _list = new List<string>();
        }
        public void Agregar(string dato)
        {
            _list.Add(dato);
        }
        private bool ValidaVacio()
        {
            return _list.Count == 0;
        }
        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Lista vacio");
            }
            _list.RemoveAt(_list.Count - 1);
        }
        public string Imprimir()
        {
            string dato = string.Empty;

            if (ValidaVacio())
            {
                return "Lista vacia";
            }
            {
                int Lstcount = _list.Count;
                for (int i = 0; i < Lstcount; i++)
                {
                    if (i > 0)
                    {
                        dato += "\n";
                    }
                    dato += $"[{i}] - {_list[i]}";
                }
                return dato;
            }
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            foreach (string dato in _list)
            {
                if (!string.IsNullOrWhiteSpace(dato))
                {
                    datos.Append(dato);
                    datos.Append(Environment.NewLine);
                }
            }
            return datos.ToString();
        }
    }
}
