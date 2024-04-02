# Kortspillet Krig

I kortspillet Krig bliver et sæt spillekort (52 stk.) fordelt mellem 2 spillere. Hver spiller vender ét kort ad gangen. Den spiller der har kortet med den højeste værdi vinder omgangen og får begge kort.

Lav en winforms udgave af spillet hvor de 52 kort fordeles tilfældigt mellem 2 spillere, hvoraf den ene er computeren.
I denne udgave af spillet har Kongen den højeste værdi efterfulgt af Dronning, Knægt og videre ned indtil Es som laveste kort.

Den spiller, som vinder runden får tildelt 2 point. Hvis begge kort har ens værdi, tildeles begge spillere 1 point.
Spillet ender, når alle kort er blevet spillet og hver kort må kun spilles én gang.

Lav en klasse (Card) til at holde styr på de forskellige kort og en klasse (Game) til at styre et enkelt spil. Hvordan du repræsentere et sæt spillekort i Game klassen, vil jeg lade være op til dig. Det kan f.eks. være et array, en List eller Dictionary.

I klassen Game kan du lave en metode (f.eks. FillDeck), der udfylder array'et med værdierne for de 52 unikke kort.
Lav derudover også en metode (f.eks. SelectCard), som du kan kalde to gange for hver omgang. Denne metode skal vælge et kort (samme kort/værdi må ikke vælges 2 gange i løbet af et spil).

På grænsefladen skal der være en knap (Deal). Denne skal starte en runde og derefter gøres usynlig. Når spillet går i gang, skal der i stedet vises en knap (Play). Hver gang denne trykkes, skal der spilles 2 nye kort.

Sørg for at applikationen holder styr på, hvilke kort der er spillet og hvilken spiller, der har fået point.
