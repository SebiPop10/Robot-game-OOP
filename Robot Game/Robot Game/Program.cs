// See https://aka.ms/new-console-template for more information
//Enunt: 

//using System.Numerics;


Planet earth = new Planet("Earth", true);


GiantKillerRobot robot = new GiantKillerRobot();
robot.Initialize();
Random rnd= new Random();

robot.EyeLaserIntensity = Intensity.Low;


robot.Targets = new List<Target>
        {
            new Target("Animals", true),
            new Target("Humans", true),
            new Target("Superheroes", true)
        };


while (robot.Active && earth.ContainsLife)
{
    if (robot.CurrentTarget != null && robot.CurrentTarget.IsAlive)
    {
        robot.FireLaserAt(robot.CurrentTarget);
        
        robot.CurrentTarget.IsAlive = false;
    }
    else
    {
        robot.AcquireNextTarget();
    }
}

Console.WriteLine("Jocul s-a incheiat.");