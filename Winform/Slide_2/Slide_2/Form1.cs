namespace Slide_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }

        private void btnQuotient_Click(object sender, EventArgs e)
        {
            int quotient;
            Console.WriteLine(txtIntegerA.Text);
            Console.WriteLine(txtIntegerB.Text);
            quotient = int.Parse(txtIntegerA.Text) - int.Parse(txtIntegerB.Text);
            lblResult.Text = txtIntegerA.Text + " - " + txtIntegerB.Text + " = " + quotient.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum;
            Console.WriteLine(txtIntegerA.Text);
            Console.WriteLine(txtIntegerB.Text);
            sum = int.Parse(txtIntegerA.Text) + int.Parse(txtIntegerB.Text);
            lblResult.Text = txtIntegerA.Text + " + " + txtIntegerB.Text + " = " + sum.ToString();
        }

        private void txtIntegerA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtIntegerA.Text = "";
            txtIntegerB.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset", "Reset Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Reset sucessfuly");
                lblResult.Text = "";
                txtIntegerA.Text = "";
                txtIntegerB.Text = "";
            }
            else
            {
                MessageBox.Show("Reset Cancelled");
            }

        }
    }
}