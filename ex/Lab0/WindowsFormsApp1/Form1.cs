using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void btnConnect_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Hi");

        }
    }
}
