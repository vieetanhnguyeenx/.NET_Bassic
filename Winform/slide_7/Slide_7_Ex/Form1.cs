namespace Slide_7_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            bool check = true;
            errorProvider1.Clear();
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Ban chua nhap sdt");
                check = false;
            }
            int age;
            if (int.TryParse(txtAge.Text, out age) == false)
            {
                errorProvider1.SetError(txtAge, "Sai Dinh Dang");
                check = false;
            }
            else
            {
                if (age < 17)
                {
                    errorProvider1.SetError(txtAge, "Tuoi phai lon hon 17");
                    check = false;
                }
            }
            if (dtpDate.Value.DayOfWeek == DayOfWeek.Monday)
            {
                errorProvider1.SetError(dtpDate, "Phim ko chieu vao thu 2");
                check = false;
            }
            if (check)
            {
                MessageBox.Show("Ban dang ki thanh cong");
            }

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}