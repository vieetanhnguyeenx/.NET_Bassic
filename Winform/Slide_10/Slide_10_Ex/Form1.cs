namespace Slide_10_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection checkedIndexCollection = chklbLeft.CheckedIndices;

            foreach (int i in checkedIndexCollection)
            {
                chklbRight.Items.Add(chklbLeft.Items[i]);
            }

            foreach (string s in chklbRight.Items)
            {
                chklbLeft.Items.Remove(s);
            }

        }

        private void btnAllToRight_Click(object sender, EventArgs e)
        {
            chklbRight.Items.AddRange(chklbLeft.Items);
            chklbLeft.Items.Clear();
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection checkedIndexCollection = chklbRight.CheckedIndices;

            foreach (int i in checkedIndexCollection)
            {
                chklbLeft.Items.Add(chklbRight.Items[i]);
            }

            foreach (string s in chklbLeft.Items)
            {
                chklbRight.Items.Remove(s);
            }
        }

        private void btnAllToLeft_Click(object sender, EventArgs e)
        {
            chklbLeft.Items.AddRange(chklbRight.Items);
            chklbRight.Items.Clear();
        }
    }
}