namespace mekanikerværksted
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            CprNr cprNr = new CprNr("010101", "1234");
            Mekanikere mekaniker = new Mekanikere("Mekaniker", "Mekanikervej 1", 5, 200, cprNr, "1234");
            Console.WriteLine(mekaniker.ToString() + $"Svendeproveår: {mekaniker.SvendeproeveAar}, Timeløn: {mekaniker.Timeloen}, Ugeløn: {mekaniker.BeregnUgeLøn()}");
            Console.WriteLine();

            cprNr = new CprNr("020202", "5678");
            Vaerfoerere vaerfoerer = new Vaerfoerere("Værkfører", "Værkførervej 1", 10, 300, 2010, 100, cprNr, "5678");
            Console.WriteLine(vaerfoerer.ToString() + $"Svendeproveår: {vaerfoerer.SvendeproeveAar}, Timeløn: {vaerfoerer.Timeloen}, Udnaevnelsesår: {vaerfoerer.UdnaevnelsesAar}, Tillæg: {vaerfoerer.Tillaeg}, Ugeløn: {vaerfoerer.BeregnUgeLøn()}");
            Console.WriteLine();

            cprNr = new CprNr("030303", "9101");
            Synsmand synsmand = new Synsmand("Synsmand", "Synsmandsvej 1", 15, 10, cprNr, "9101");
            Console.WriteLine(synsmand.ToString() + $"Svendeproveår: {synsmand.SvendeproeveAar}, Synsantal: {synsmand.SynsAntal}, Ugeløn: {synsmand.BeregnUgeLøn()}");
            Console.WriteLine();
        }
    }
}