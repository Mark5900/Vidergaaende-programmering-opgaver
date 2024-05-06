// Interface til at repræsentere en tennisbold
public interface ITennisBall
{
    void Bounce();
}

// Implementering af en grusbane-tennisbold
public class ClayCourtTennisBall : ITennisBall
{
    public void Bounce()
    {
        Console.WriteLine("Clay court tennis ball bounces differently.");
    }
}

// Implementering af en hard court-tennisbold
public class HardCourtTennisBall : ITennisBall
{
    public void Bounce()
    {
        Console.WriteLine("Hard court tennis ball bounces normally.");
    }
}

// Interface til abstract factory til at producere tennisbolde
public interface ITennisBallFactory
{
    ITennisBall CreateTennisBall();
}

// Implementering af en factory til at producere tennisbolde til grusbane
public class ClayCourtTennisBallFactory : ITennisBallFactory
{
    public ITennisBall CreateTennisBall()
    {
        return new ClayCourtTennisBall();
    }
}

// Implementering af en factory til at producere tennisbolde til hard court
public class HardCourtTennisBallFactory : ITennisBallFactory
{
    public ITennisBall CreateTennisBall()
    {
        return new HardCourtTennisBall();
    }
}

// En eksempelklasse til at demonstrere factory method pattern
public class TennisBallMaker
{
    public ITennisBall CreateTennisBall(ITennisBallFactory factory)
    {
        ITennisBall tennisBall = factory.CreateTennisBall();
        Console.WriteLine("Creating a new tennis ball for " + tennisBall.GetType().Name);
        return tennisBall;
    }
}

// Brugssekvens
class Program
{
    static void Main(string[] args)
    {
        // Opret en fabrik til grusbane-tennisbold
        ITennisBallFactory clayCourtFactory = new ClayCourtTennisBallFactory();
        // Opret en fabrik til hard court-tennisbold
        ITennisBallFactory hardCourtFactory = new HardCourtTennisBallFactory();

        // Opret en tennis-bold-maker og brug den til at oprette bolde for hver type bane
        TennisBallMaker maker = new TennisBallMaker();
        ITennisBall clayTennisBall = maker.CreateTennisBall(clayCourtFactory);
        ITennisBall hardTennisBall = maker.CreateTennisBall(hardCourtFactory);

        // Test boldenes bounce()-metoder
        clayTennisBall.Bounce(); // forventet output: "Clay court tennis ball bounces differently."
        hardTennisBall.Bounce(); // forventet output: "Hard court tennis ball bounces normally."
    }
}