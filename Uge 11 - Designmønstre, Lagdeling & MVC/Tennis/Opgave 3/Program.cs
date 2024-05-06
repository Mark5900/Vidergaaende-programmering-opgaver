// Definerer en interface for en tennisketsjer, som har attributterne Stivhed og Vægt
public interface ITennisRacket
{
    int Stivhed { get; set; }
    int Vægt { get; set; }
}

// Definerer en abstract factory, der opsætter fabrikker af forskellige typer tennisketsjere
public abstract class TennisRacketFactory
{
    public abstract ITennisRacket ProduktionAfKetsjer();
}

// Implementerer en fabrik til begynder-ketsjere
public class BegynderRacketFactory : TennisRacketFactory
{
    public override ITennisRacket ProduktionAfKetsjer()
    {
        return new BegynderRacket();
    }
}

// Implementerer en fabrik til professionel-ketsjere
public class ProfessionelRacketFactory : TennisRacketFactory
{
    public override ITennisRacket ProduktionAfKetsjer()
    {
        return new ProfessionelRacket();
    }
}

// Implementerer klassen til begynder-ketsjere
public class BegynderRacket : ITennisRacket
{
    public int Stivhed { get; set; }
    public int Vægt { get; set; }

    public BegynderRacket()
    {
        Stivhed = 50;
        Vægt = 250;
    }
}

// Implementerer klassen til professionel-ketsjere
public class ProfessionelRacket : ITennisRacket
{
    public int Stivhed { get; set; }
    public int Vægt { get; set; }

    public ProfessionelRacket()
    {
        Stivhed = 100;
        Vægt = 300;
    }
}

// Demonstrerer brugen af fabrikker
public class Program
{
    static void Main(string[] args)
    {
        TennisRacketFactory begynderFabrik = new BegynderRacketFactory();
        ITennisRacket begynderKetsjer = begynderFabrik.ProduktionAfKetsjer();

        TennisRacketFactory professionelFabrik = new ProfessionelRacketFactory();
        ITennisRacket professionelKetsjer = professionelFabrik.ProduktionAfKetsjer();

        Console.WriteLine("Attributterne for en begynder-ketsjer er: Stivhed = " + begynderKetsjer.Stivhed + ", Vægt = " + begynderKetsjer.Vægt);
        Console.WriteLine("Attributterne for en professionel-ketsjer er: Stivhed = " + professionelKetsjer.Stivhed + ", Vægt = " + professionelKetsjer.Vægt);

        Console.ReadLine();
    }
}