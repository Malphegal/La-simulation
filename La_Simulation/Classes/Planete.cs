using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Simulation.Classes
{
    class Planete
    {
            // --------------------------
            // Propriétés
            // --------------------------

        protected static List<Planete> listPlanete = new List<Planete>(); // à lire depuis un fichier de sauvegarde

        private static ushort nextId = 0; // à lire depuis un fichier de sauvegarde

        public ushort id { get; } // id unique de la Planete
        public string nom { get; } // nom de la Planete

            // --------------------------
            // Constructeurs et création de planete
            // --------------------------

        public static void ajouterUnePlanete(string nom) // Méthode public, pour la création d'une Planete
        {
            if (string.IsNullOrWhiteSpace(nom)) // Verif à faire à l'appel de la méthode ? -----
                throw new ArgumentException();
            listPlanete.Add(new Planete(nom));
        }

        protected Planete(string Pnom) // Constructeur protected, pour l'héritage
        {
            id = getNextId();
            nom = Pnom;
        }

            // --------------------------
            // Méthodes
            // --------------------------

        private static ushort getNextId() // Renvoie le prochain id à utiliser pour la création d'une Planete
        {
            return nextId++;
        }

        public static void nextIdMoinsUn() // Baisser de un le prochain id à utiliser (suppression d'une Planete)
        {
            nextId--;
        }

        public virtual string sePresenter() // Renvoie un string de présentation de this
        {
            return "Je suis la planète " + nom + '.';
        }

        public static IEnumerable<string> listerPlanetes() // Renvoie chaque string sePresenter de chaque Planete
        {
            foreach (Planete p in listPlanete)
                yield return p.sePresenter();
        }

    }
}
