using System;
using StoreModels;
using System.Collections.Generic;

namespace StoreBL
{
    public interface IStoreBL
    {
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer newCustomer);
        Customer GetCustomerByName(string name);

        List<Inventory> GetInventories();
        Inventory AddInventory(Inventory newInventory);

        List<Location> GetLocations();
        Location AddLocation(Location newLocation);
        Location GetLocationByName(string name);

        List<Order> GetOrder();
        Order AddOrder(Order newOrder);
        //Order GetOrderByName(string name);

        List<Product> GetProduct();
        Product AddProduct(Product newProduct);
        Product GetProductByName(string name);
    }
}
