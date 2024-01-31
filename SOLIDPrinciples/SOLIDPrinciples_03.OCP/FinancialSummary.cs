namespace SOLIDPrinciples_03.OCP;

public class FinancialSummary
{
    public string Display()
    {
        FinancialData data = GetData();
        // Logic to format and display data on the web
        // Negative numbers in red, scrollable content, etc.
        return $"Web Display Value: {data.Value}";
    }
    
    private FinancialData GetData()
    {
        // Logic to get data from the database
        return new FinancialData()
        {
            Value = "Database Value"
        };
    }

    // Other methods and properties
}