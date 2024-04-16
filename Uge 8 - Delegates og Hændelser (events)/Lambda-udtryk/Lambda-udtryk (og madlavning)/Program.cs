using Lambda_udtryk__og_madlavning_;

List<Opskrift> opskrifter = new List<Opskrift>();
opskrifter.Add(new Opskrift
{
    Navn = "Kylling i karry",
    Svaerhedsgrad = "Middel",
    Tid = 30,
    Ingredienser = new List<string> { "Kylling", "Karry", "Ris" }
});
opskrifter.Add(new Opskrift
{
    Navn = "Pasta carbonara",
    Svaerhedsgrad = "Svær",
    Tid = 45,
    Ingredienser = new List<string> { "Pasta", "Bacon", "Æg" }
});
opskrifter.Add(new Opskrift
{
    Navn = "Lasagne",
    Svaerhedsgrad = "Svær",
    Tid = 60,
    Ingredienser = new List<string> { "Oksekød", "Lasagneplader", "Tomatsauce" }
});
opskrifter.Add(new Opskrift
{
    Navn = "Pandekager",
    Svaerhedsgrad = "Let",
    Tid = 15,
    Ingredienser = new List<string> { "Mel", "Æg", "Mælk" }
});

// Beregn den samlede tid med lambda-udtryk
var samletTid = opskrifter.Select(o => o.Tid).Aggregate((a, b) => a + b);
Console.WriteLine($"Samlet tid: {samletTid} minutter");

// Beregn gennemsnitstiden med lambda-udtryk
var gennemsnitTid = opskrifter.Select(o => o.Tid).Aggregate((a, b) => a + b) / opskrifter.Count;
Console.WriteLine($"Gennemsnitstid: {gennemsnitTid} minutter");

// Find den korteste tid med lambda-udtryk
var kortesteTid = opskrifter.Select(o => o.Tid).Aggregate((a, b) => a < b ? a : b);
Console.WriteLine($"Korteste tid: {kortesteTid} minutter");

// Find opskrifter med æg med lambda-udtryk
var opskrifterMedAeg = opskrifter.Where(o => o.Ingredienser.Contains("Æg"));
foreach (var opskrift in opskrifterMedAeg)
{
    Console.WriteLine(opskrift.Navn);
}