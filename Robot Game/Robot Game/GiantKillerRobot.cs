// See https://aka.ms/new-console-template for more information
//Enunt: 

using System.Runtime.InteropServices;

public  class GiantKillerRobot
{

    public Intensity EyeLaserIntensity { get; set; }
    public List<Target> Targets { get; set; }
    public Target CurrentTarget { get; set; }
    public bool Active { get; set; }

    public GiantKillerRobot()
    {
        Targets = new List<Target>();
    }

    public void Initialize()
    {
        
        Active = true;
    }

    public void AcquireNextTarget()
    {
        
        foreach (var target in Targets)
        {
            if (target.IsAlive)
            {
                CurrentTarget = target;
                return;
            }
        }
       
        Active = false;
    }

    public void FireLaserAt(Target target)
    {
       
        Console.WriteLine($"Robotul trage cu laserul in {target.Name} cu intensitatea {EyeLaserIntensity}.");
       
    }
}
public enum Intensity
{
    Low,
    Medium,
    High,
    Kill
}
