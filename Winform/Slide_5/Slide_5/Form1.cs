namespace Slide_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            String s = "";
            if (chkXemPhim.Checked)
            {
                s += "Ban Thich Xem Phim\n";
            }
            if (chkShopping.Checked)
            {
                s += "Ban Thich Shopping\n";
            }
            if(chkNgheNhac.Checked)
            {
                s += "Ban Thich Nghe Nhac\n";
            }
            if (chkDuLich.Checked)
            {
                s += "Ban Thich Du Lich\n";
            }
            if (chkChoiTheThao.Checked) 
            {
                s += "Ban Thich Choi The Thao\n";
            } 
            MessageBox.Show(s);
        }
    }
}