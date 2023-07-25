using System.Diagnostics;

namespace Linq
{
    public partial class Form1 : Form
    {
        List<Food> foodList;
        public Form1()
        {
            InitializeComponent();
            LoadFood();
        }

        void LoadFood()
        {
            foodList = new List<Food>();
            foodList.Add(new Food("Dui de nuong", "55555"));
            foodList.Add(new Food("Muc mot nang", "33333"));
            foodList.Add(new Food("Dui de luoc", "22222"));
            foodList.Add(new Food("Coca", "15000"));
            foodList.Add(new Food("Oc nuong", "55115"));

            cbbData.DataSource = foodList;
            cbbData.DisplayMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Food
        {
            private string price;
            private string name;

            public Food()
            {
            }

            public Food(string name, string price)
            {
                Price = price;
                Name = name;
            }

            public string Price { get => price; set => price = value; }
            public string Name { get => name; set => name = value; }
        }

        private void btnFiltter_Click(object sender, EventArgs e)
        {
            List<Food> reslut = new List<Food>();

            //foreach (var item in foodList)
            //{
            //    if (item.Name == txtFillter.Text)
            //    {
            //        reslut.Add(item);
            //    }
            //}

            reslut = foodList.Where(p => p.Name == txtFillter.Text).ToList();

            cbbResult.DataSource = reslut;
            cbbResult.DisplayMember = "Name";
        }
    }
}