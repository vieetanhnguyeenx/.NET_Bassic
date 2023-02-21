namespace Slide_5_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grbColor_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblResult.ForeColor = radRed.ForeColor;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Ok why not");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = txtInput.Text;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblResult.ForeColor = radGreen.ForeColor;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblResult.ForeColor = radBlue.ForeColor;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblResult.ForeColor = radBlack.ForeColor;
            }
        }

        private void chkBolt_CheckedChanged(object sender, EventArgs e)
        {

            lblResult.Font = new Font(
            txtInput.Font.Name,
            txtInput.Font.Size,
            lblResult.Font.Style | FontStyle.Bold);



        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {

            lblResult.Font = new Font(
                txtInput.Font.Name,
                txtInput.Font.Size,
                lblResult.Font.Style | FontStyle.Italic);

        }

        private void grbFont_Enter(object sender, EventArgs e)
        {
            lblResult.Font.Style.


        }
    }
}