using Esercizio_L3_W1_BU1.Models;


// Creo un nuovo Conto Corrente con intestatario "Mario Rossi" e ne utilizzo i metodi
ContoCorrente conto1 = new ContoCorrente("Mario Rossi");
Console.WriteLine("Esercizio 1) Conto Corrente");
conto1.ApriConto(1000);
conto1.Versamento(500);
conto1.Prelievo(200);

Console.WriteLine("--------------------------");

// Cerco un candidato dalla lista di candidati nell'array
Console.WriteLine("Esercizio 2) Ricerca Nome");

RicercaCandidato ricerca = new RicercaCandidato("Vittorio");
RicercaCandidato ricerca2 = new RicercaCandidato("Mario");

Console.WriteLine("--------------------------");

// Creo un Array che riceve come parametro la dimensione dell'array e lo riempie con numeri casuali, facendone la somma e la media aritmetica
Console.WriteLine("Esercizio 3) Array Numeri Casuali. Somma e media dei numeri");

SommaMediaArray sommaMedia = new SommaMediaArray();
sommaMedia.CalcolaSommaEMedia();