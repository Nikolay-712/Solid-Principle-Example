namespace LiskovSubstitutionPrinciple.Models;

public class Penguin : Bird
{
    public override void Move()
    {
        Walk();
    }

    public void Walk()
    {
        // Walk logic
    }
}
