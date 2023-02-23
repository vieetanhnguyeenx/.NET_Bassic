using System.Media;

namespace Slide_6_Ex
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer(@"C:\Users\Admin\Downloads\AnhThemDuocNgu.wav");
            //soundPlayer = new SoundPlayer("AnhThemDuocNgu.wav");
        }
        int count = 1;
        bool flag = false;

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Go go go");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnPush.Text = txtName.Text;
            if (picPull.Visible == false)
            {
                btnPush.Text = txtName.Text + "! Click de ha ta di";
            }
            else
            {
                btnPush.Text = txtName.Text + "! Click de nang ta di";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picPull.Visible = false;
            picPush.Visible = true;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (picPull.Visible == false)
            {
                picPull.Visible = true;
                picPush.Visible = false;
                btnPush.Text = txtName.Text + "! Click de nang ta di";
                lblCounter.Text = count.ToString();
                count++;
            }
            else
            {
                picPull.Visible = false;
                picPush.Visible = true;
                btnPush.Text = txtName.Text + "! Click de ha ta di";
                //lblCounter.Text = count.ToString();
                //count++;
            }

            if (count == 11 && flag == false)
            {
                DialogResult result = MessageBox.Show(
                    "Da dat chi tieu 10 cai, ban co muon tiep tuc?",
                    "Continue",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                flag = true;
                if (result == DialogResult.No)
                {
                    Close();
                }
            }
        }

        private void picPush_Click(object sender, EventArgs e)
        {

        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked)
            {
                soundPlayer.Play();
            }
            else
            {
                soundPlayer.Stop();
            }
        }
    }
}