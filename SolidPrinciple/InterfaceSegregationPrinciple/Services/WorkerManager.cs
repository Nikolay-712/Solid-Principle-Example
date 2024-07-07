using InterfaceSegregationPrinciple.Models;

namespace InterfaceSegregationPrinciple.Services;

public class WorkerManager
{
    public void ManageWork(IWorkable workable)
    {
        workable.Work();
    }
}
