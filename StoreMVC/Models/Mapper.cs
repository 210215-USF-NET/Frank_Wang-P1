using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreMVC.Models
{
    public class Mapper : IMapper
    {
        public CustomerIndexVM cast2CustomerIndexVM(Customer customer2BCasted)
        {
            return new CustomerIndexVM
            {
                FirstName = customer2BCasted.FirstName,
                LastName = customer2BCasted.LastName,
                PhoneNumber = customer2BCasted.PhoneNumber
            };
        }

        public Customer cast2Customer(CustomerCRVM customer2BCasted)
        {
            return new Customer
            {
                FirstName = customer2BCasted.FirstName,
                LastName = customer2BCasted.LastName,
                PhoneNumber = customer2BCasted.PhoneNumber

            };
        }

        public CustomerCRVM cast2CustomerCRVM(Customer customer)
        {
            return new CustomerCRVM
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber
            };
        }

        public LocationIndexVM cast2LocationIndexVM(Location location2BCasted)
        {
            return new LocationIndexVM
            {
                LocationAddress = location2BCasted.LocationAddress,
                LocationID = location2BCasted.LocationID
            };
        }
        public Location cast2Location(LocationCRVM location2BCasted)
        {
            return new Location
            {
                LocationAddress = location2BCasted.LocationAddress,
                LocationID = location2BCasted.LocationID
            };
        }
        public LocationCRVM cast2LocationCRVM(Location location)
        {
            return new LocationCRVM
            {
                LocationAddress = location.LocationAddress,
                LocationID = location.LocationID
            };
        }

        public ProductIndexVM cast2ProductIndexVM(Product product2BCasted)
        {
            return new ProductIndexVM
            {
                ProductName = product2BCasted.ProductName,
                ProductID = product2BCasted.ProductID,
                ProductDescription = product2BCasted.ProductDescription,
                ProductPrice = product2BCasted.ProductPrice
            };
        }
        public Product cast2Product(ProductCRVM product2BCasted)
        {
            return new Product
            {
                ProductName = product2BCasted.ProductName,
                ProductID = product2BCasted.ProductID,
                ProductDescription = product2BCasted.ProductDescription,
                ProductPrice = product2BCasted.ProductPrice
            };
        }
        public ProductCRVM cast2ProductCRVM(Product product)
        {
            return new ProductCRVM
            {
                ProductName = product.ProductName,
                ProductID = product.ProductID,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice
            };
        }

        //TODO Implementation//
        public InventoryIndexVM cast2InventoryIndexVM(Inventory inventory2BCasted)
        {
            return new InventoryIndexVM
            {
                LocationId = inventory2BCasted.LocationId,
                ProductId = inventory2BCasted.ProductId,
                InventoryName = inventory2BCasted.InventoryName,
                InventoryPrice = inventory2BCasted.InventoryPrice,
                InventoryQuantity = inventory2BCasted.InventoryQuantity
            };
        }
    }
}
