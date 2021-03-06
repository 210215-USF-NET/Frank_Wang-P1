using StoreModels;

namespace StoreMVC.Models
{
    public interface IMapper
    {
        Customer cast2Customer(CustomerCRVM customer2BCasted);
        CustomerCRVM cast2CustomerCRVM(Customer customer);
        CustomerIndexVM cast2CustomerIndexVM(Customer customer2BCasted);
        Location cast2Location(LocationCRVM location2BCasted);
        LocationCRVM cast2LocationCRVM(Location location);
        LocationIndexVM cast2LocationIndexVM(Location location2BCasted);
        Product cast2Product(ProductCRVM product2BCasted);
        ProductCRVM cast2ProductCRVM(Product product);
        ProductIndexVM cast2ProductIndexVM(Product product2BCasted);
    }
}