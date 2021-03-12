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
            return _context.Customers.
            Include("Phonenumber")
            .AsNoTracking()
            .FirstOrDefault(customer => customer.PhoneNumber == name);
        }

        public Inventory AddInventory(Inventory newInventory)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Location GetLocationByName(string name)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return _context.Products
            .AsNoTracking()
            .Select(product => product)
            .ToList();
        }
    }
}
