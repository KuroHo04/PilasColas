namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArreglos_Click(object sender, EventArgs e)
        {
            FrmArreglosPilas frmArreglosPilas = new FrmArreglosPilas();
            frmArreglosPilas.ShowDialog();
        }
    }
}
