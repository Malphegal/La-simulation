using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Simulation.Classes
{
    public class Personne
    {
            // --------------------------
            // Propriétés
            // --------------------------

        protected static List<Personne> listPersonne = new List<Personne>(); // à lire depuis un fichier de sauvegarde

        private static ushort nextId = 0; // à lire depuis un fichier de sauvegarde

        public ushort id { get; protected set; } // id unique de la Personne
        public string nom { get; } // nom de la Personne
        public string prenom { get; } // prenom de la Personne
        public bool sexe { get; } // sexe de la Personne
        public byte age { get; } // age de la Personne

            // --------------------------
            // Constructeurs et création de Personne
            // --------------------------

        public static void ajouterUnePersonne(string nom, string prenom, byte age, bool sexe) // Méthode public, pour la création d'une Personne
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom)) // Verif à faire à l'appel de la méthode ? -----
                throw new ArgumentException();
            listPersonne.Add(new Personne(nom, prenom, age, sexe));
        }

        protected Personne(string Pnom, string Pprenom, byte Page, bool Psexe) // Constructeur protected, pour l'héritage
        {
            id = getNextId();
            nom = Pnom;
            prenom = Pprenom;
            age = Page;
            sexe = Psexe;
        }

            // --------------------------
            // Méthodes
            // --------------------------

        private static ushort getNextId() // Renvoie le prochain id à utiliser pour la création d'une Personne
        {
            return nextId++;
        }

        public static void nextIdMoinsUn() // Baisser de un le prochain id à utiliser (suppression d'une Personne)
        {
            nextId--;
        }

        public virtual string sePresenter() // Renvoie un string de présentation de this
        {
            return "Je suis " + nom + ' ' + prenom + " et j'ai " + age + (int.Parse(age.ToString()) > 1 ? " ans." : " an.");
        }

        public static string[] listerPersonnes() // Renvoie chaque string sePresenter de chaque Personne
        {
            string[] res = new string[listPersonne.Count];
            for (int i = 0; i < listPersonne.Count; i++)
                res[i] = listPersonne[i].sePresenter();
            return res;
        }

        public static Personne getPersonne(ushort id) // Renvoie un objet de type Personne en fonction de l'id fournit en paramètre
        {
            if (id >= nextId)
                throw new ArgumentOutOfRangeException();
            return listPersonne[id];
        }

        public static Personne[] getAllPersonnes() // Renvoie un tableau de toutes les Personnes
        {
            return listPersonne.ToArray();
        }

        public static void supprimerPersonne(int index)
        {
            foreach (Personne p in listPersonne)
                if (p.id > index)
                    p.id--;
            listPersonne.RemoveAt(index);
        }
    }

    class Test : Personne
    {
            // --------------------------
            // Propriétés
            // --------------------------

        int aaaa; // A remplacer par quelque chose d'autre

            // --------------------------
            // Constructeurs et création de Test
            // --------------------------

        public static void ajouterUnTest(string nom, string prenom, byte age, bool sexe, int aaaa) // Méthode public, pour la création d'un Test
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom))
                throw new ArgumentException();
            listPersonne.Add(new Test(nom, prenom, age, sexe, aaaa));
        }

        private Test(string nom, string prenom, byte age, bool sexe, int aaaa) : base(nom, prenom, age, sexe) // Constructeur private
        {
            this.aaaa = aaaa;
        }

            // --------------------------
            // Méthodes
            // --------------------------

        public override string sePresenter() // Override sePresenter(), pour afficher les autres propriétés
        {
            return base.sePresenter() + "\nMon code aaaa est : " + aaaa ;
        }
    }
}
