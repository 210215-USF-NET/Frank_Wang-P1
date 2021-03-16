using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreDL;

namespace StoreBL
{
    public class storeBL : IStoreBL
    {
        private IStoreRepository _repo;
        public storeBL(IStoreRepository repo)
        {
            _repo = repo;
        }

        public Customer AddCustomer(Customer newCustomer)
        {
            return _repo.AddCustomer(newCustomer);
        }

        public Customer GetCustomerByName(string name)
        {
            //Check if customer exists
            return _repo.GetCustomerByName(name);
        }

        public List<Customer> GetCustomers()
        {
            return _repo.GetCustomers();
        }

        public Inventory AddInventory(Inventory newInventory)
        {
            return _repo.AddInventory(newInventory);
        }

        public List<Inventory> GetInventories()
        {
            return _repo.GetInventories();
        }

        public Location AddLocation(Location newLocation)
        {
           return _repo.AddLocation(newLocation);
        }
        public Location GetLocationByName(string name)
        {
            return _repo.GetLocationByName(name);
        }

        public List<Location> GetLocations()
        {
            return _repo.GetLocations();
        }

        public Order AddOrder(Order newOrder)
        {
           return _repo.AddOrder(newOrder);
        }

        //public Order GetOrderByName(int name)
        //{
        //return _repo.GetOrderByName(name);
        //}
        public List<Order> GetOrder()
        {
            return _repo.GetOrders();
        }

        public Product AddProduct(Product newProduct)
        {
            return _repo.AddProduct(newProduct);
        }
        public Product GetProductByName(string name)
        {
            return _repo.GetProductByName(name);
        }
        public List<Product> GetProduct()
        {
            return _repo.GetProducts();
        } 
        public Product DeleteProduct(Product product2BDeleted)
        {
            return _repo.DeleteProduct(product2BDeleted);
        }

    }
}
