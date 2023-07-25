namespace Slide_14_Ex
{

    public partial class Form1 : Form
    {
        int TienNguoiChoi = 100;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMoney.Text = TienNguoiChoi.ToString();
        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            if (TienNguoiChoi < 20)
            {
                MessageBox.Show("Ban khong du tien");
            }
            else
            {
                // tru tien
                TienNguoiChoi -= 20;
                txtMoney.Text = TienNguoiChoi + "";
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = rd.Next(0, 8).ToString();
            lbl2.Text = rd.Next(0, 9).ToString();
            lbl3.Text = rd.Next(0, 10).ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (lbl1.Text == "7")
            {
                TienNguoiChoi += 30;
            }
            if (lbl2.Text == "7")
            {
                TienNguoiChoi += 40;
            }
            if (lbl3.Text == "7")
            {
                TienNguoiChoi += 50;
            }
            txtMoney.Text = TienNguoiChoi + "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TienNguoiChoi = 100;
            txtMoney.Text = TienNguoiChoi + "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}