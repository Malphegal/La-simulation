﻿using System;
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

        public ushort id { get; } // id unique de la Personne
        public string nom { get; } // nom de la Personne
        public string prenom { get; } // prenom de la Personne
        public bool sexe { get; } // sexe de la Personne
        public byte age { get; } // age de la Personne

            // --------------------------
            // Constructeurs et création de Personne
            // --------------------------

        public static ushort ajouterUnePersonne(string nom, string prenom, byte age) // Méthode public, pour la création d'une Personne
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom)) // Verif à faire à l'appel de la méthode ? -----
                throw new ArgumentException();
            listPersonne.Add(new Personne(nom, prenom, age));
            return listPersonne.Last().age;
        }

        protected Personne(string nom, string prenom, byte age) // Constructeur protected, pour l'héritage
        {
            id = getNextId();
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

            // --------------------------
            // Méthodes
            // --------------------------

        private static ushort getNextId() // Renvoie le prochain id à utiliser pour la création d'une Personne
        {
            return nextId++;
        }

        public virtual string sePresenter() // Renvoie un string de présentation de this
        {
            return "Je suis " + nom + ' ' + prenom + " et j'ai " + age + " ans.";
        }

        public static IEnumerable<string> listerPersonnes() // Renvoie chaque string sePresenter de chaque Personne
        {
            foreach (Personne p in listPersonne)
                yield return p.sePresenter();
        }

        public static Personne getPersonne(ushort id) // Renvoie un objet de type Personne en fonction de l'id fournit en paramètre
        {
            if (id >= nextId)
                throw new ArgumentOutOfRangeException();
            return listPersonne[id];
        }

        public static Personne[] getAllPersonnes()
        {
            return listPersonne.ToArray();
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

        public static void ajouterUnTest(string nom, string prenom, byte age, int aaaa) // Méthode public, pour la création d'un Test
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom))
                throw new ArgumentException();
            listPersonne.Add(new Test(nom, prenom, age, aaaa));
        }

        private Test(string nom, string prenom, byte age, int aaaa) : base(nom, prenom, age) // Constructeur private
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