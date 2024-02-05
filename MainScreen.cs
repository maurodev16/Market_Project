using SupermarketDesktop;

namespace WinFormsApp1
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void kontoErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }
    }
}
