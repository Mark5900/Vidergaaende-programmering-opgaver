# Opgaver om metoder med argumenter (og pizzaer)

## Opgave 1

Lav en metode i C# kaldet "BestilPizza", der modtager to argumenter: "pizzatype" (string) og "antal" (int). Metoden skal returnere en besked, der fortæller, at x antal pizzaer af typen y er bestilt.

## Opgave 2

Lav en metode i C# kaldet "LavPizza", der modtager to argumenter: "ingredienser" (string[]) og "størrelse" (string). Metoden skal returnere en streng, der indeholder information om, hvilke ingredienser pizzaen indeholder, og dens størrelse.

## Opgave 3

Lav en metode i C# kaldet "PrisBeregning", der modtager to argumenter: "pizzatype" (string) og "antal" (int). Metoden skal beregne prisen for den ønskede mængde pizzaer af den valgte type og returnere prisen som en double.

For at kunne lave denne metode skal du have en måde at holde styr på, hvilke pizzaer der er på menuen, og hvad de koster. Du kan vælge at gøre det ved hjælp af en if eller switch-case, eller du kan lave en liste eller et array over de pizzaer, du har.

## Opgave 4

Lav en metode i C# kaldet "TilføjIngredienser", der modtager tre argumenter: "pizzatype" (string), "ingredienser" (string[]) og "prisændring" (double). Metoden skal tilføje de ønskede ingredienser til pizzaen og ændre prisen på pizzaen i overensstemmelse hermed.

For at kunne gøre dette skal du først have en måde at holde styr på, hvilke pizzaer der er på menuen, og hvilke ingredienser de indeholder., og hvad de koster Det letteste er at opbevare disse oplysninger i en liste.

## Opgave 5

Udvid opgave 4, og lav en metode i C# kaldet "FindPizzaMedIngredienser", der modtager et argument: "ingredienser" (string[]). Metoden skal returnere en liste over de pizzaer, der indeholder alle de angivne ingredienser.