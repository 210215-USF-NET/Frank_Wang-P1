using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model = StoreModels;
using StoreModels;

namespace StoreDL
{
    public interface IStoreRepository
    {
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer newCustomer);
        Customer GetCustomerByName(string name);

        List<Inventory> GetInventories();

        Inventory AddInventory(Inventory newInventory);

        List<Location> GetLocations();
        Location AddLocation(Location newLocation);
        Location GetLocationByName(string name);

        List<Order> GetOrders();
        Order AddOrder(Order newOrder);
        // Order GetOrderByName(string name);

        List<Product> GetProducts();
        Product AddProduct(Product newProduct);
        Product GetProductByName(string name);
        Product DeleteProduct(Product product2BDeleted);
    }
}
