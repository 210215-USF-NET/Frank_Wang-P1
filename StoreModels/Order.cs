namespace StoreModels
{
    public class Order
    {

        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public Product Product{ get; set; }
        public double OrderTotal { get; set; }
        public int OrderID { get; set; }
        public int OrderQuantity{ get; set;}
        public int Id { get; set; }

        public override string ToString() => $"Customer Details:\n\tCustomer Name: {this.Customer} \n\t-------------\n\t{this.Product} \n\tOrder Quantity: {this.OrderQuantity} \n\tOrder Total: {(double)this.OrderTotal}";
    }
}