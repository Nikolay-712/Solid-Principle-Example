using InterfaceSegregationPrinciple.Models;

namespace InterfaceSegregationPrinciple.Services;

public class FoodManager
{
    public void ManageFood(IFeedable feedable)
    {
        feedable.Eat();
    }
}
