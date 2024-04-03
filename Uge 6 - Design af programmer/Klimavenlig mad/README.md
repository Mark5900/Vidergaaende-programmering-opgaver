# Opgave 2 - Klimavenlig mad

IT spås en stor rolle i den grønne omstilling. Når vi taler om bæredygtighed inden for IT, så taler vi om Green in IT - som vil sige, at vores IT-drift er så grøn som muligt - og Green by IT, som handler om, at IT hjælper med at gøre andre løsninger mere grønne.

I denne opgave tager vi vinklen Green by IT - du skal altså lave software, som hjælper folk med at tage klimavenlige valg.

Du er sikkert klar over, at den mad du spiser, har et eller andet klimaaftryk, men hvilken fødevare der er mest klimavenlig kan være svært at afgøre (se bare denne video hvor nogle af elementer gennemgås, hvis du er nysgerrig).

[CO2 fra fødevarer. Kød vs grøntsager. Consito ny udregning, ILUC](https://www.youtube.com/watch?v=az4-WUyOyWI)

I denne opgave skal du lave et system, som kan registrere Co2-udledning for en fødevare - hele vejen fra produktion til den er i butikken.

Vi skal have de samme oplysninger, som findes på [Den store klimadatabase](https://denstoreklimadatabase.dk). Det vil sige:

- Fødevarens navn
- Kategori
- Landbrugets Co2 udledning
- ILUC Co2 udledning
- Forarbejdsnings Co2 udledning
- Emballagens Co2 udledning
- Transportens Co2 udledning
- Detailhandlens Co2 udledning

## Hvad skal du lave

En klasse der repræsenterer fødevare:

1. Den skal indeholde ovennævnte oplysninger som properties.
2. Klassen skal desuden have en metode, der beregner den samlede Co2 udledning for produktet (summen af de 6 Co2-udledninger angivet ovenfor)

En brugergrænseflade:

1. Hvor brugeren kan indtaste de 6 oplysninger.
2. Trykke på en knap og se den samlede Co2 udledning for den indtastede fødevare.
Dette punkt skal laves ved, at du laver en instans af din klasse, sætter de rigtige properties, og derefter kalder beregningsmetoden. Lige nu synes det måske ikke at være den letteste måde at gøre det på, men det er vigtigt, når du skal arbejde videre med opgaven.
