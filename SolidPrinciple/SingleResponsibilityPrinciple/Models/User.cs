namespace SingleResponsibilityPrinciple.Models;

public class User
{
    public int Id { get; set; }

    public int Name { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}
