// See https://aka.ms/new-console-template for more information
//Enunt: 

public class Planet
{
    public string Name {  get; set; }
    public bool ContainsLife {  get; set; }

    public Planet(string name, bool containsLife)
    {
        Name = name;
        this.ContainsLife = containsLife;
    }
}