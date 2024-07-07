namespace SingleResponsibilityPrinciple.Models;

public class Order
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal Amount { get; set; }

    public int UserId { get; set; }
}
