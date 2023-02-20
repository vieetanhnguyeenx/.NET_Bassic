namespace Slide_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chang co tinh yeu nao vinh cuu", "Anh da co giau het nhung phut yeu duoi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Ban co chac chan muon thoat?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("Ta yeu lai tu dau");
            //}

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}