namespace LiskovSubstitutionPrinciple.Models;

public class FlyingBird : Bird
{
    public override void Move()
    {
        Fly();
    }

    public void Fly()
    {
        // Fly logic
    }
}
