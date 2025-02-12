namespace Esercizio_L3_W1_BU1.Models
{
    public class RicercaCandidato
    {
        public string[] Candidati = { "Mario", "Luca", "Carla",  "Giuseppe", "Paola", "Giovanni" };

        public string CandidatoCercato { get; set; }

        public RicercaCandidato(string candidatoCercato)
        {
            if (Candidati.Contains(candidatoCercato))
            {
                Console.WriteLine($"Il nome {candidatoCercato} è presente nella lista.");
            }
            else
            {
                Console.WriteLine($"Il nome {candidatoCercato} NON è presente nella lista.");
            }
        }
    }
}
