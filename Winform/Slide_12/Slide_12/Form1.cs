namespace Slide_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuOpenForm1_Click(object sender, EventArgs e)
        {
            frm1 frm1 = new frm1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void mnuOpenForm2_Click(object sender, EventArgs e)
        {
            frm2 frm2 = new frm2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void mnuOpenForm3_Click(object sender, EventArgs e)
        {
            frm3 frm3 = new frm3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void mnuOpenForm4_Click(object sender, EventArgs e)
        {
            frm4 frm4 = new frm4();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuVer_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuHori_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuCas_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}