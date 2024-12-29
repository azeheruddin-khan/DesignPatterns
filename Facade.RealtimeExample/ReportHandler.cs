namespace Facade.RealtimeExample
{
    public class ReportHandler
    {
        private CustomerMicroService customerMicroService = new ();
        private OrderMicroService orderMicroService = new ();

        public void  OrderReport()
        {
            var customers = customerMicroService.GetCustomers();
            var orders = orderMicroService.GetOrders();

            var report = (from c in customers
                          join o in orders on c.Id equals o.CustomerId
                          select new
                          {
                              CustomerName = c.Name,
                              CustomerAddress = c.Address,
                              OrderId = o.Id,
                              o.ProductId,
                              o.Quantity,
                              o.Price,
                              o.OrderDate
                          }).ToList();

            foreach (var r in report)
            {
                Console.WriteLine(r);
            }
        }


    }
}
