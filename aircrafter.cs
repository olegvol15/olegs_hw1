using System;

abstract class Machine
{
    public virtual string Name { get; set; }

    public Machine(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Machine: {Name}");
    }
}

class Aircraft : Machine
{
    public Aircraft(string name) : base(name) { }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Aircraft: {Name} is ready to fly.");
    }
}

class Helicopter : Aircraft
{
    public override string Name
    {
        get { return base.Name; }
        set { base.Name = "Helicopter - " + value; }
    }

    public Helicopter(string name) : base(name) { }

    public void Hover()
    {
        Console.WriteLine($"{Name} is hovering.");
    }
}

class Airliner : Aircraft
{
    public Airliner(string name) : base(name) { }

    public void ServeMeals()
    {
        Console.WriteLine($"{Name} is serving meals.");
    }
}

class Freighter : Aircraft
{
    public Freighter(string name) : base(name) { }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"{Name} is carrying cargo.");
    }
}

class Program
{
    static void Main()
    {
        var helicopter = new Helicopter("Black Hawk");
        var airliner = new Airliner("Boeing 747");
        var freighter = new Freighter("C-130 Hercules");

        helicopter.DisplayInfo();
        helicopter.Hover();

        airliner.DisplayInfo();
        airliner.ServeMeals();

        freighter.DisplayInfo();
    }
}


