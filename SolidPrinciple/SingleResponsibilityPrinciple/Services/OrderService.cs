using SingleResponsibilityPrinciple.Models;

namespace SingleResponsibilityPrinciple.Services;

public class OrderService
{
    //OrderService Class: Handles operations related to orders, such as saving and retrieving orders.

    public List<Order> GetOrders(int userId)
    {
        // Code to get orders for the user from the database
        return new List<Order>();
    }

    public void SaveOrder(Order order)
    {
        // Code to save order to database
    }
}
