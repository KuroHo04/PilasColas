using Arreglos;

namespace Desktop
{
    public partial class FrmArreglosColas : Form
    {
        private Colas _colas;
        public FrmArreglosColas()
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
                _colas = new Colas(valorConvertido);
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
                _colas.Agregar(txtAgregar.Text);

                txtDatos.Text = _colas.ObtenerDatos();
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
                _colas.Eliminar();
                txtDatos.Text = _colas.ObtenerDatos();
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
                txtDatos.Text = _colas.ObtenerDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
