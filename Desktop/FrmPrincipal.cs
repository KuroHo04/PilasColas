namespace Desktop
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnArreglos_Click(object sender, EventArgs e)
        {
            FrmArreglosPilas frmArreglosPilas = new FrmArreglosPilas();
            frmArreglosPilas.ShowDialog();
        }
        private void btnArreglos_Click1(object sender, EventArgs e)
        {
            FrmArreglosColas frmArreglosColas = new FrmArreglosColas();
            frmArreglosColas.ShowDialog();
        }
    }
}
