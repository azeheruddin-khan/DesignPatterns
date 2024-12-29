namespace Facade.RealtimeExample
{
    public class OrderMicroService
    {
        public OrderMicroService() { }
        public IEnumerable<Order> GetOrders()
        {
            List<Order> list = new List<Order>();
            list.Add(new Order() { Id = 1, CustomerId = 1, ProductId =1,Quantity = 1,Price=10,OrderDate = System.DateTime.Now}); //OrderDate - showing some dummy date.
            list.Add(new Order() { Id = 2, CustomerId = 1, ProductId = 2, Quantity = 2, Price = 3, OrderDate = System.DateTime.Now });
            list.Add(new Order() { Id = 3, CustomerId = 1, ProductId = 3, Quantity = 3, Price = 5, OrderDate = System.DateTime.Now });
          
            list.Add(new Order() { Id = 4, CustomerId = 2, ProductId = 1, Quantity = 1, Price = 10, OrderDate = System.DateTime.Now }); //OrderDate - showing some dummy date.
            list.Add(new Order() { Id = 5, CustomerId = 2, ProductId = 2, Quantity = 2, Price = 3, OrderDate = System.DateTime.Now });
            list.Add(new Order() { Id = 6, CustomerId = 2, ProductId = 3, Quantity = 3, Price = 5, OrderDate = System.DateTime.Now });

            list.Add(new Order() { Id = 7, CustomerId = 3, ProductId = 1, Quantity = 1, Price = 10, OrderDate = System.DateTime.Now }); //OrderDate - showing some dummy date.
            list.Add(new Order() { Id = 8, CustomerId = 3, ProductId = 2, Quantity = 2, Price = 3, OrderDate = System.DateTime.Now });
            list.Add(new Order() { Id = 9, CustomerId = 3, ProductId = 3, Quantity = 3, Price = 5, OrderDate = System.DateTime.Now });

            return list;

        }
    }
}