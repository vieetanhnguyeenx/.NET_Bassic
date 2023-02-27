namespace Slide_8_Ex
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (lstSo.Items.Count > 1)
            {
                lstSo.Items.RemoveAt(0);
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
            }
            else
            {
                errorProvider1.SetError(lstSo, "Khong thoa man");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = true;
            int x = 0;
            errorProvider1.Clear();
            if (txtNhapSo.Text.Length == 0)
            {
                errorProvider1.SetError(txtNhapSo, "Không được để trống");
                check = false;
            }
            else if (int.TryParse(txtNhapSo.Text, out x) == false)
            {
                errorProvider1.SetError(txtNhapSo, "Sai định dạng");
                check = false;
            }
            if (check)
            {
                lstSo.Items.Add(x.ToString());
                txtNhapSo.Clear();
            }

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lstSo.Items)
            {
                sum += int.Parse(item.ToString());
            }
            MessageBox.Show("Tổng của danh sách là " + sum);
        }

        private void btnXoaPhanTu_Click(object sender, EventArgs e)
        {
            while (lstSo.SelectedIndex != -1)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            }
        }

        private void btnTangLen2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int k = int.Parse(lstSo.Items[i].ToString()) + 2;
                lstSo.Items[i] = k.ToString();
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {

                int k = int.Parse(lstSo.Items[i].ToString()) * int.Parse(lstSo.Items[i].ToString());
                lstSo.Items[i] = k.ToString();

            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = int.Parse(lstSo.Items[i].ToString());
                if (x % 2 != 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
               
                    int x = int.Parse(lstSo.Items[i].ToString());
                    if (x % 2 == 0)
                    {
                        lstSo.SelectedIndex = i;
                    }
                
            }
        }

        private void lstSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}