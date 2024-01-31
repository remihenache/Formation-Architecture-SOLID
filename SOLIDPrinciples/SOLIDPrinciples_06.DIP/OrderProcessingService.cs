namespace SOLIDPrinciples_06.DIP;

public class OrderProcessingService
{
    public void ProcessOrder(Order order)
    {
        if (new InventoryService().CheckInventory(order) && new PaymentService().ProcessPayment(order))
        {
            new ShippingService().ScheduleShipping(order);
            Console.WriteLine("Order processed successfully.");
        }
        else
        {
            Console.WriteLine("Order processing failed.");
        }
    }
}