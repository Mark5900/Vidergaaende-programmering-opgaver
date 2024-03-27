namespace mekanikerværksted
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            var medarbejderCollection = new MedarbejderListe<CprNr>();

            var morten = new Mekanikere("Morten", new Adresse("Vej", "1", "8000", "Aarhus"), new CprNr("211271", "7777"), "1320", new DateTime(2017, 11, 23), 195);
            var karina = new Mekanikere("Karina", new Adresse("Vej", "2", "8000", "Aarhus"), new CprNr("141174", "8888"), "1410", new DateTime(2019, 1, 20), 190);
            var vaerfoerer = new Vaerfoerere("Vær",new Adresse("Vej", "3", "8000", "Aarhus"), new CprNr("201232", "8888"), "1420", new DateTime(2019, 1, 20), 190, 2019, 1000);
            var synsmand = new Synsmand("Syns", new Adresse("Vej", "2", "8000", "Aarhus"), new CprNr("8209232", "8888"), "1430", new DateTime(2019, 1, 20), 190, 10);

            medarbejderCollection.AddElement(karina.CprNr, karina);
            medarbejderCollection.AddElement(morten.CprNr, morten);
            medarbejderCollection.AddElement(vaerfoerer.CprNr, vaerfoerer);
            medarbejderCollection.AddElement(synsmand.CprNr, synsmand);
            var test = medarbejderCollection.GetElement(new CprNr("211271", "7777"));
            Console.WriteLine(test);
            Console.WriteLine("Press enter");
            Console.ReadLine();

            keyMedarbejdernummer();
            firmaer();
        }

        private static void keyMedarbejdernummer()
        {
            Console.WriteLine("Medarbejdernummer som key");
            var medarbejderCollection = new MedarbejderListe<string>();

            var morten = new Mekanikere("Morten", new Adresse("Vej", "1", "8000", "Aarhus"), new CprNr("211271", "7777"), "1320", new DateTime(2017, 11, 23), 195);
            var karina = new Mekanikere("Karina", new Adresse("Vej", "2", "8000", "Aarhus"), new CprNr("141174", "8888"), "1410", new DateTime(2019, 1, 20), 190);
            var vaerfoerer = new Vaerfoerere("Vær", new Adresse("Vej", "3", "8000", "Aarhus"), new CprNr("201232", "8888"), "1420", new DateTime(2019, 1, 20), 190, 2019, 1000);
            var synsmand = new Synsmand("Syns", new Adresse("Vej", "2", "8000", "Aarhus"), new CprNr("8209232", "8888"), "1430", new DateTime(2019, 1, 20), 190, 10);

            medarbejderCollection.AddElement(karina.MedarbejderNr, karina);
            medarbejderCollection.AddElement(morten.MedarbejderNr, morten);
            medarbejderCollection.AddElement(vaerfoerer.MedarbejderNr, vaerfoerer);
            medarbejderCollection.AddElement(synsmand.MedarbejderNr, synsmand);
            var test = medarbejderCollection.GetElement("1320");
            Console.WriteLine(test);
            Console.ReadLine();

        }

        private static void firmaer()
        {
            Console.WriteLine("Firmaer");
            var firmaCollection = new MedarbejderListe<string>();

            var firma1 = new Firma("Firma1", new Adresse("Vej", "1", "8000", "Aarhus"));
            var firma2 = new Firma("Firma2", new Adresse("Vej", "2", "8000", "Odense"));

            firmaCollection.AddElement(firma1.Adresse.By, firma1);
            firmaCollection.AddElement(firma2.Adresse.By, firma2);
            var test = firmaCollection.GetElement("Aarhus");
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}