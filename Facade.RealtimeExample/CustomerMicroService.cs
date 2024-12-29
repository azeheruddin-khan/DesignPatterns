namespace Facade.RealtimeExample
{
    public class CustomerMicroService
    {
       public IEnumerable<Customer> GetCustomers()
        {
            List<Customer> list = new List<Customer>();
            list.Add(new Customer() { Id = 1, Name = "Albert", Address = "NY,USA" });
            list.Add(new Customer() { Id = 2, Name = "Robert", Address = "NJ,USA" });
            list.Add(new Customer() { Id = 3, Name = "David", Address = "IN,USA" });
            return list;
        }
    }
}
