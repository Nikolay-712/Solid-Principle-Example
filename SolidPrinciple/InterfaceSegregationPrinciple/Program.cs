using InterfaceSegregationPrinciple.Models;
using InterfaceSegregationPrinciple.Services;

internal class Program
{
    //The Interface Segregation Principle states that a client should not be forced to implement interfaces it doesn’t use.
    //This promotes smaller, specific interfaces rather than large, monolithic ones.

    private static void Main(string[] args)
    {
        IWorkable robot = new Robot();
        IWorkable humanWorker = new Human();
        IFeedable humanEater = new Human();

        WorkerManager workerManager = new WorkerManager();
        FoodManager foodManager = new FoodManager();

        workerManager.ManageWork(robot); // Robot is working.
        workerManager.ManageWork(humanWorker); // Human is working.
        foodManager.ManageFood(humanEater); // Human is eating.
    }
}