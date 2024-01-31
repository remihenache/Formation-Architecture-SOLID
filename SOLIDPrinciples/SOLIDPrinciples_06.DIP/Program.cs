namespace SOLIDPrinciples_06.DIP;

public static class Program
{
    public static void Main()
    {
        var order = new Order();
        new OrderProcessingService().ProcessOrder(order);
    }
}