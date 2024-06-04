using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FrmArreglosPilas : Form
    {
        public FrmArreglosPilas()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                bool sePudoConvertir = false;
                int valorConvertido = 0;
                string elementos = txtElementos.Text;
                sePudoConvertir = int.TryParse(elementos, out valorConvertido);
                if (!sePudoConvertir) 
                {
                    throw new Exception("no se pudo convertir");
                }
                _pila = new Pilas(valorConvertido);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                txtDatos.Text = string.Empty;
                _pila.Agregar(txtAgregar.Text);

                txtDatos.Text = _pila.ObtenerDatos();
                txtAgregar.Text = string.Empty;
                txtAgregar.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                txtDatos.Text = string.Empty;
                _pila.Eliminar();
                txtDatos.Text = _pila.ObtenerDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            try
            {
                txtDatos.Text = string.Empty;
                txtDatos.Text = _pila.ObtenerDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
