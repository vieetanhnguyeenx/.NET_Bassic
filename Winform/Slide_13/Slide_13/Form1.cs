namespace Slide_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lbl2.ImageIndex = 1;
            lbl2.ImageAlign = ContentAlignment.MiddleCenter;
        }
    }
}