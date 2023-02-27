namespace Slide_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.Add("san pham new");
            chklbDanhSach.Items.Add("san pham new 2");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.Insert(1, "500");
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.AddRange(new string[] { "pt1", "pt2" });
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count " + chklbDanhSach.Items.Count);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.Remove("pt1");
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.RemoveAt(1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.Clear();
        }

        private void btnCheckedIndi_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection indexCollection = chklbDanhSach.CheckedIndices;
            string checkedStr = "";
            foreach (var i in indexCollection)
            {
                checkedStr += i + " ";
            }
            MessageBox.Show(checkedStr);
        }

        private void btnCheckedItems_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection checkedItemCollection = chklbDanhSach.CheckedItems;
            string checkedStr = "";
            foreach (var i in checkedItemCollection)
            {
                checkedStr += i + " ";
            }
            MessageBox.Show(checkedStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strChecked = "";
            for (int i = 0; i < chklbDanhSach.Items.Count; i++)
            {
                if (chklbDanhSach.GetItemChecked(i))
                {
                    strChecked += chklbDanhSach.Items[i] + " ";
                }
            }
            MessageBox.Show(strChecked);
        }

        private void btnGetIndex_Click(object sender, EventArgs e)
        {
            string strChecked = "";
            for (int i = 0; i < chklbDanhSach.Items.Count; i++)
            {
                if (chklbDanhSach.GetItemChecked(i))
                {
                    strChecked += i + " ";
                }
            }
            MessageBox.Show(strChecked);
        }
    }
}