using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StoreDL
{
    public class StoreRepoDB : IStoreRepository
    {
        private readonly StoreDBContext _context;

        public StoreRepoDB(StoreDBContext context)
        {
            _context = context;
        }
        public Customer AddCustomer(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return newCustomer;
        }
        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            _context.Customers.Remove(customer2BDeleted);
            _context.SaveChanges();
            return customer2BDeleted;
        }

        public Customer GetCustomerByName(string name)
        {
            return _context.Customers
            .AsNoTracking()
            .FirstOrDefault(customer => customer.PhoneNumber == name);
        }

        public Inventory AddInventory(Inventory newInventory)
        {
            _context.Inventories.Add(newInventory);
            _context.SaveChanges();
            return newInventory;
        }

        public Location AddLocation(Location newLocation)
        {
            _context.Locations.Add(newLocation);
            _context.SaveChanges();
            return newLocation;
        }

        public Location DeleteLocation(Location location2BDeleted)
        {
            _context.Locations.Remove(location2BDeleted);
            _context.SaveChanges();
            return location2BDeleted;
        }

        public Order AddOrder(Order newOrder)
        {
            throw new NotImplementedException();
        }

        public Product AddProduct(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;
        }



        public List<Customer> GetCustomers()
        {
            return _context.Customers.Select(customer => customer).ToList();
        }

        public List<Inventory> GetInventories()
        {
            return _context.Inventories.Select(inventory => inventory).ToList();
        }

        public Location GetLocationByName(string name)
        {
            return _context.Locations
            .AsNoTracking()
            .FirstOrDefault(location => location.LocationAddress == name);
        }

        public List<Location> GetLocations()
        {
            return _context.Locations
            .AsNoTracking()
            .Select(location => location)
            .ToList();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(string name)
        {
            return _context.Products
            .AsNoTracking()
            .FirstOrDefault(product => product.ProductName == name);
        }

        public List<Product> GetProducts()
        {
            return _context.Products
            .AsNoTracking()
            .Select(product => product)
            .ToList();


        }
        public Product DeleteProduct(Product product2BDeleted)
        {
            _context.Products.Remove(product2BDeleted);
            _context.SaveChanges();
            return product2BDeleted;
        }
    }
}
