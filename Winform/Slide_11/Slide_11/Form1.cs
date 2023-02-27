namespace Slide_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Red;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = rd.Next(500) + "";
                flowLayoutPanel1.Controls.Add(btn);
                // Gan contextmenu
                btn.ContextMenuStrip = contextMenuStrip1;
            }
        }
    }
}