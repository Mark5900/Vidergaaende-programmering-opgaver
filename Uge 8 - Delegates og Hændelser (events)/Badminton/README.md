# Opgave: Badminton

I denne opgave skal du udvikle en C#-applikation, der simulerer en badmintonkamp. Applikationen skal have mulighed for at beregne pointene i en kamp baseret på forskellige pointberegningssystemer, som brugerne kan vælge.

**Krav**:

1. Opret en delegate med navnet PointBeregning, der repræsenterer en metode, der tager to heltal som argumenter og returnerer et heltal. Dette heltal skal repræsentere pointene i en badmintonkamp.

2. Implementer to metoder: TraditionelPointBeregning og AlternativPointBeregning, der følger de regler, der er beskrevet nedenfor:
   1. Traditionel pointberegning: Spilleren skal have mindst 21 point for at vinde, og forskellen mellem pointene skal være mindst 2.
   2. Alternativ pointberegning: Spilleren skal have mindst 11 point for at vinde, og forskellen mellem pointene skal være mindst 2.

3. Opret en klasse med navnet BadmintonKamp, der indeholder følgende:
   1. Private instansvariabler til at holde styr på pointene for hver spiller.
   2. En constructor, der modtager en PointBeregning-delegate som parameter og tildeler den til en intern variabel.
   3. Metoder til at lade hver spiller vinde point: Spiller1VinderPoint og Spiller2VinderPoint.
   4. En metode BeregnPoint, der bruger den tildelte pointberegning via delegaten til at beregne pointene i kampen.

4. I Main-metoden, opret to instanser af BadmintonKamp - en med TraditionelPointBeregning og en med AlternativPointBeregning. Lad spillerne vinde point, og brug derefter BeregnPoint-metoden til at vise resultaterne for begge kampene.

**Bonusopgave**:

Tilføj yderligere pointberegningssystemer som f.eks. 15-pointsberegning eller 25-pointsberegning, og lad brugeren vælge, hvilken pointberegning der skal anvendes.

**Vær opmærksom på**:

- Korrekt brug af delegates til at implementere pointberegningssystemer.
- Implementering af BadmintonKamp-klassen med de nødvendige metoder og logik.
- Korrekte pointberegninger i overensstemmelse med valgt system.
- Brugervenlig interaktion i Main-metoden, hvor brugeren kan vælge pointberegningssystemet og se resultatet.
