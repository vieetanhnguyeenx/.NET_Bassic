namespace Sanpham
{
    public partial class Product
    {
        public string? name {set; get;}
        public decimal price {set; get;}

        public string getInfo()
        {
            return $"{name} \t {price} \t {this.description}";
        }
    }
}