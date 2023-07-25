namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SanPham> listSanPham = new List<SanPham>();
            listSanPham.Add(new SanPham()
            {
                Id = 1,
                Name = "Dep to ong",
                Quantity = 5,
                Price = 10.3
            });
            listSanPham.Add(new SanPham()
            {
                Id = 2,
                Name = "Thuoc Lao",
                Quantity = 3,
                Price = 10.1
            });
            listSanPham.Add(new SanPham()
            {
                Id = 3,
                Name = "Cuoc doi",
                Quantity = 5,
                Price = 13
            });
            listSanPham.Add(new SanPham()
            {
                Id = 3,
                Name = "DoiBuonViChangConE",
                Quantity = 5,
                Price = 101.3
            });
            dgvCuocDoi.DataSource = listSanPham;
        }
    }
}