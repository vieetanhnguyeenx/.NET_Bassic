namespace Slide_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.Add("Obama");
            cboDanhSach.Items.Add("Trump");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.Insert(0, "Putin");
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phan tu dang duoc chon la " + cboDanhSach.SelectedIndex);
        }

        private void btnSelectedItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Item " + cboDanhSach.SelectedItem);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count " + cboDanhSach.Items.Count);
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.AddRange(new string[] { "pt1", "pt2", "pt3" });
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.Remove("pt1");
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            if (cboDanhSach.SelectedIndex != -1)
            {
                cboDanhSach.Items.RemoveAt(cboDanhSach.SelectedIndex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.Clear();
        }
    }
}