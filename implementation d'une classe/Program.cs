using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementation_d_une_classe
{
    using System;

    public class Bibliotheque
    {
        public char commanderLivre()
        {
            // TODO: implement
            return '0';
        }

        public char enregistrerLivre()
        {
            // TODO: implement
            return '0';
        }

        private char nom;
        private int adresse;
        private char employe;
        private char livre;

    }

    public class Livre
    {
        public char emprunter()
        {
            // TODO: implement
            return '0';
        }

        public int prolonger()
        {
            // TODO: implement
            return 0;
        }

        public char restaurer()
        {
            // TODO: implement
            return '0';
        }

        private char titre;
        private char auteur;
        private int numero;

    }
    public class Employe
    {
        public char enregistrementLivre()
        {
            // TODO: implement
            return '0';
        }

        public char indexerDesLivre()
        {
            // TODO: implement
            return '0';
        }

        private char nom;
        private char poste;

    }
    public class Emprunteur
    {
        public char retar()
        {
            // TODO: implement
            return '0';
        }

        public char suspension()
        {
            // TODO: implement
            return '0';
        }

        private char nom;
        private int numero;
        private int duree;

    }

    public class Archive
    {
        private DateTime dateArchive;
        private char nom;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
