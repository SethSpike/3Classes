/*Seth Spaich*/
using System;

public class Orc
{
    public void orc()
    {
        Console.WriteLine("Fear me for I am a mighty Orc!");
    }
    public void IQ()
    {
        Console.WriteLine(" - IQ is rated at a 4");
    }
   public void Strength()
    {
        Console.WriteLine(" - Strength is rated at a 8");
    }
    public void Speed()
    {
        Console.WriteLine(" - Speed is rated at a 6");
    }
}

public class Fairy
{
    public void fairy()
    {
        Console.WriteLine("Hello, I am a mystical Fairy.");
    }
    public void IQ()
    {
        Console.WriteLine(" - IQ is rated at a 10");
    }
   public void Strength()
    {
        Console.WriteLine(" - Strength is rated at a 2");
    }
    public void Speed()
    {
        Console.WriteLine(" - Speed is rated at a 8");
    }
}

public class Golem
{
    public void golem()
    {
        Console.WriteLine("Me golem.");
    }
    public void IQ()
    {
        Console.WriteLine(" - IQ is rated at a 1");
    }
   public void Strength()
    {
        Console.WriteLine(" - Strength is rated at a 10");
    }
    public void Speed()
    {
        Console.WriteLine(" - Speed is rated at a 2");
    }
}

public class Spawn
{
    static void Main(string[] args)
    {
    Orc mob1 = new Orc();
    Console.WriteLine("A angry orc appeared");
    mob1.orc();
    mob1.IQ();
    mob1.Strength();
    mob1.Speed();

    Fairy mob2 = new Fairy();
    Console.WriteLine("A friendly fairy appeared");
    mob2.fairy();
    mob2.IQ();
    mob2.Strength();
    mob2.Speed();

    Golem mob3 = new Golem();
    Console.WriteLine("A giant golem appeared");
    mob3.golem();
    mob3.IQ();
    mob3.Strength();
    mob3.Speed();
    }
}
