using LiskovSubstitutionPrinciple.Models;

namespace LiskovSubstitutionPrinciple.Services;

public class BirdWatcher
{
    public void WatchBird(Bird bird)
    {
        bird.Move();
    }
}
