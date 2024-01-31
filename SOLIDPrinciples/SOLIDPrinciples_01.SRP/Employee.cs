namespace SOLIDPrinciples_01.SRP;

public class Employee
{
    private const int hourlyRate = 20;

    public decimal CalculatePay()
    {
        decimal regularHoursPay = RegularHours() * hourlyRate;
        // Additional pay calculation logic
        return regularHoursPay;
    }

    public int ReportHours()
    {
        int hours = RegularHours();
        // Additional reporting logic
        return hours;
    }

    public void Save()
    {
        // Save employee details to the database
    }

    private int RegularHours()
    {
        // Logic for calculating regular hours
        return 40; // Example value
    }

    // Additional properties and methods
}
