namespace SOLIDPrinciples_05.ISP;

public class Developer : IWork
{
    public void Code()
    {
        // Implement coding logic
    }

    public void Test()
    {
        // Implement testing logic
    }

    public void DesignArchitecture()
    {
        // Not relevant for Developer
        throw new NotImplementedException();
    }

    public void ManageTeam()
    {
        // Not relevant for Developer
        throw new NotImplementedException();
    }
}