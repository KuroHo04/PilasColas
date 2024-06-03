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
                MessageBox.Show(":)");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
