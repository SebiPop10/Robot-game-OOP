// See https://aka.ms/new-console-template for more information
//Enunt: 

public class Target
{
    public string Name { get; set; }
    public bool IsAlive { get; set; }
    public Target(string name, bool isAlive)
    {
        Name = name;
        this.IsAlive = isAlive;
    }
}