namespace Slide_8_Ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Student sv = new Student();
            sv.Id = int.Parse(txtMa.Text);
            sv.Name = txtTen.Text;
            string s = sv.Id + " " + sv.Name;
            lstHienThi.Items.Add(s);
        }
    }
}