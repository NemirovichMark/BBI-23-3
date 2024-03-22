namespase task2
{

}



abstract class Embrasure
{
    public string Name { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Thickness { get; set; }

    public abstract double Cost();
}

class Window : Embrasure
{
    public int Sloi { get; set; }

    public override double Cost()
    {
      
        return Width * Height * Thickness * Sloi;
    }
}

class Door : Embrasure
{
    public bool Usor { get; set; }
    public bool Glass { get; set; }

    public override double Cost()
    {
        
        return Width * Height * Thickness;
    }
}

class Program
{
    static void Main()
    {
        Window[] windows = new Window[5];
        Door[] doors = new Door[5];

        
       
    }
}
