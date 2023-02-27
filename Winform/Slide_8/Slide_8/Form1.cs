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

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.RemoveAt(0);

        }

        private void btnSelectedIndi_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection l = lstDanhSach.SelectedIndices;
            foreach (int item in l)
            {
                MessageBox.Show(lstDanhSach.Items[item].ToString() + " " + item.ToString());
            }
        }

        private void btnGan_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items[0] = "Hello";
        }

        private void btnSelectedIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index cua item dang chon la" + lstDanhSach.SelectedIndex.ToString());
        }
    }
}