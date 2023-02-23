namespace Slide_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add("Nguyen Van C");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So phan tu " + lstDanhSach.Items.Count);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstDanhSach.Items[0].ToString());
        }
    }
}