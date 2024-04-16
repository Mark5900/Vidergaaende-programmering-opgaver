using Badminton;

delegate int PointBeregning(int x, int y);

class Program
{
    static int TraditionelPointBeregning(int spiller1Score, int spiller2Score)
    {
        if (spiller1Score >= 21 && spiller1Score - spiller2Score >= 2)
            return spiller1Score;
        else if (spiller2Score >= 21 && spiller2Score - spiller1Score >= 2)
            return spiller2Score;
        else
            return 0;
    }

    static int AlternativPointBeregning1(int spiller1Score, int spiller2Score)
    {
        if (spiller1Score >= 11 && spiller1Score - spiller2Score >= 2)
            return spiller1Score;
        else if (spiller2Score >= 11 && spiller2Score - spiller1Score >= 2)
            return spiller2Score;
        else
            return 0;
    }

    static int AlternativPointBeregning2(int spiller1Score, int spiller2Score)
    {
        if (spiller1Score >= 15 && spiller1Score - spiller2Score >= 2)
            return spiller1Score;
        else if (spiller2Score >= 15 && spiller2Score - spiller1Score >= 2)
            return spiller2Score;
        else
            return 0;
    }

    static int AlternativPointBeregning3(int spiller1Score, int spiller2Score)
    {
        if (spiller1Score >= 25 && spiller1Score - spiller2Score >= 2)
            return spiller1Score;
        else if (spiller2Score >= 25 && spiller2Score - spiller1Score >= 2)
            return spiller2Score;
        else
            return 0;
    }

    static void Main()
    {
        // Opret en badmintonkamp med den traditionelle pointberegning
        BadmintonKamp kampMedTraditionelPoint = new BadmintonKamp(TraditionelPointBeregning);

        // Spillerne vinder point
        kampMedTraditionelPoint.Spiller1VinderPoint();
        kampMedTraditionelPoint.Spiller2VinderPoint();

        // Beregn og vis pointene
        int pointMedTraditionelBeregning = kampMedTraditionelPoint.BeregnPoint();
        Console.WriteLine("Point med traditionel beregning: " + pointMedTraditionelBeregning);

        // Opret en anden badmintonkamp med alternativ pointberegning
        BadmintonKamp kampMedAlternativPoint = new BadmintonKamp(AlternativPointBeregning1);

        // Spillerne vinder point
        kampMedAlternativPoint.Spiller1VinderPoint();
        kampMedAlternativPoint.Spiller1VinderPoint();

        // Beregn og vis pointene
        int pointMedAlternativBeregning = kampMedAlternativPoint.BeregnPoint();
        Console.WriteLine("Point med alternativ beregning: " + pointMedAlternativBeregning);

        #region Bonusopgave
        Console.WriteLine("Vælg en pointberegning:");
        Console.WriteLine("1. Traditionel");
        Console.WriteLine("2. Alternativ 1");
        Console.WriteLine("3. Alternativ 2");
        Console.WriteLine("4. Alternativ 3");
        int valg = int.Parse(Console.ReadLine());
        Console.WriteLine();

        BadmintonKamp kamp;
        switch (valg)
        {
            case 1:
                kamp = new BadmintonKamp(TraditionelPointBeregning);
                break;
            case 2:
                kamp = new BadmintonKamp(AlternativPointBeregning1);
                break;
            case 3:
                kamp = new BadmintonKamp(AlternativPointBeregning2);
                break;
            case 4:
                kamp = new BadmintonKamp(AlternativPointBeregning3);
                break;
            default:
                throw new ArgumentException("Ugyldigt valg");
        }

        kamp.Spiller1VinderPoint();
        kamp.Spiller1VinderPoint();
        kamp.Spiller2VinderPoint();

        int point = kamp.BeregnPoint();
        Console.WriteLine("Point: " + point);
        #endregion
    }
}