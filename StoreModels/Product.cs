namespace StoreModels
{
    public class Product
    {



        public string ProductName { get; set; }
        public int ProductID { get; set; }

        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }

       

        public int Id { get; set; }
        public override string ToString() => $"Product Details:\n\tName: {this.ProductName} \n\tProduct Description: {this.ProductDescription} \n\tProduct ID: {this.ProductID} \n\tProduct Price: {this.ProductPrice}";
    }
}