namespace Slide_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = lvSanPham.SelectedItems[0];
                string ma = listViewItem.SubItems[0].Text;
                string ten = listViewItem.SubItems[1].Text;
                string gia = listViewItem.SubItems[2].Text;
                txtMa.Text = ma;
                txtTen.Text = ten;
                txtGia.Text = gia;
            }
        }

        private void lvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != -1)
            {
                ColumnHeader cot = lvSanPham.Columns[e.Column];
                MessageBox.Show("ban chon:" + cot.Text);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem(txtMa.Text);
            lv.SubItems.Add(txtTen.Text);
            lv.SubItems.Add(txtGia.Text);

            lvSanPham.Items.Add(lv);
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = lvSanPham.SelectedItems[0];
                lvSanPham.Items.RemoveAt(listViewItem.Index);
            }

        }


    }
}