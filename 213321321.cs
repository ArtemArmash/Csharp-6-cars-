try
{
    Apperance apperance = new Apperance("Red", 13123, "BMW", 2, "High", "200 km/h", "120 km/h");
    apperance.Display();

    Salon salon = new Salon("Green", 41456, "Audi", 1, "Medium", "185 km/h", "100 km/h");
    salon.Display();

    Tech tech = new Tech("Blue", 53789, "Mercedes", 7, "Low", "120 km/h", "130 km/h");
    tech.Display();
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}


abstract class Auto
{
    protected string Color;
    protected int Number;
    protected string Marka;

    protected int seats;
    protected string quality;

    protected string Maxspeed;
    protected string Avgspeed;

    public Auto(string color, int number, string marka, int seats, string quality, string maxspeed, string avgspeed)
    {
        Color = color;
        Number = number;
        Marka = marka;
        this.seats = seats;
        this.quality = quality;
        Maxspeed = maxspeed;
        Avgspeed = avgspeed;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Number: {Number}");
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Seats: {seats}");
        Console.WriteLine($"Quality: {quality}");
        Console.WriteLine($"Maxspeed: {Maxspeed}");
        Console.WriteLine($"Avgspeed: {Avgspeed}");
        Console.WriteLine();
    }
}

class Apperance : Auto
{
    public Apperance(string color, int number, string marka, int seats, string quality, string maxspeed, string avgspeed)
        : base(color, number, marka, seats, quality, maxspeed, avgspeed) { }
    public override void Display()
    {
        Console.WriteLine("Apperance Details:");
        base.Display();
    }
}

class Salon : Auto
{
    public Salon(string color, int number, string marka, int seats, string quality, string maxspeed, string avgspeed)
        : base(color, number, marka, seats, quality, maxspeed, avgspeed) { }
    public override void Display()
    {
        Console.WriteLine("Salon Details:");
        base.Display();
    }
}

class Tech : Auto
{
    public Tech(string color, int number, string marka, int seats, string quality, string maxspeed, string avgspeed)
        : base(color, number, marka, seats, quality, maxspeed, avgspeed) { }
    public override void Display()
    {
        Console.WriteLine("Tech Details:");
        base.Display();
    }
}