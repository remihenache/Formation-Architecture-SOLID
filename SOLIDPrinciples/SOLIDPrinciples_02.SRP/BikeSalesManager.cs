namespace SOLIDPrinciples_02.SRP;

public class BikeSalesManager
{
    public void ProcessBikeSale(string bikeModel, int quantity)
    {
        // Handle the sales process
        Console.WriteLine("Processing sale for bike: " + bikeModel);

        // Calculate the total cost
        double cost = GetBikeCost(bikeModel) * quantity;
        Console.WriteLine("Total cost: " + cost);

        // Update inventory
        UpdateInventory(bikeModel, quantity);

        // Generate invoice
        GenerateInvoice(bikeModel, quantity, cost);
    }

    private double GetBikeCost(string bikeModel)
    {
        // Return cost based on bike model
        return 1000.0; // Simplified example
    }

    private void UpdateInventory(string bikeModel, int quantity)
    {
        // Update inventory logic
        Console.WriteLine("Updating inventory for bike: " + bikeModel);
    }

    private void GenerateInvoice(string bikeModel, int quantity, double cost)
    {
        // Invoice generation logic
        Console.WriteLine("Generating invoice...");
    }
}