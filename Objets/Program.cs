using System;

namespace Objets
{
    class Program
    {
        public class Animal
        {
            // Propriétés de l'animal
            private string couleur;
            private int poids;
            private static int s_compteur;
            //public string MaPropriete {get; set;}

            // constructeur
            public Animal(string couleurAnimal, int poidsAnimal)
            {
                couleur = couleurAnimal;
                poids = poidsAnimal;
                s_compteur++;
            }

            //accesseurs

            public static int Compteur
            {
                get { return s_compteur; }
            }
            public int Poids
            {
                get
                {
                    return poids;
                }
                set
                {
                    poids = value;
                }
            }
            public string Couleur
            {
                get
                {
                    return couleur;
                }
                set
                {
                    couleur = value;
                }
            }

            //Méthodes
            public void Manger(Animal animalMange)
            {
                poids = poids + animalMange.poids;
                animalMange.poids = 0;
                animalMange.couleur = "";
            }
            public void SeDeplacer( int Km)
            {
                Console.WriteLine("L'animal se déplace de " +Km + " Km.");
                poids = poids - Km;
            }
        }

        // création d'une classe dérivée de Animal

        public class Poisson : Animal
        {
            private bool vivant_en_mer;


            // constructeur
            public Poisson(string couleur, int poids, bool Vivant_en_mer):base(couleur,poids)
            {
                vivant_en_mer = Vivant_en_mer;
            }
            // accesseur
            public bool Vivant_En_Mer
            {
                get { return Vivant_En_Mer; }
            }
           
        }



        static void Main(string[] args)
        {

            // declaration des instances de classe
            
            Animal poisson1;
            Animal chat1;
            poisson1 = new Animal("bleu",8, true );
            Animal Requin;
            Requin = new Animal("rouge", 100);
            chat1 = new Animal("Noir", 13);

            //poisson.Poids = 10;
            //poisson.Couleur = "Bleu";

            Console.WriteLine("Le poids du poisson est de : "+poisson1.Poids + " Kgs");
            Console.WriteLine("Le Poids du chat est de : "+chat1.Poids + " Kgs");
            chat1.Manger(poisson1);
            Console.WriteLine("Le chat à diner ! ! ! ");
            Console.WriteLine("Le poids du poisson est maintenant de : " + poisson1.Poids + " Kgs");
            Console.WriteLine("Le poids du chat après avoir manger est de  : " + chat1.Poids + " Kgs");

            //poisson1.SeDeplacer();
            //chat1.SeDeplacer();
            // Le chat se deplace et comme il a fait du sport il a perdu 2 Kgs

            Console.WriteLine("Le chat avant de faire du sport se pèse : " + chat1.Poids + " Kgs");
            chat1.Poids = chat1.Poids - 2;
            Console.WriteLine("Le chat après avoir fait du sport se pèse de nouveau : " + chat1.Poids + " Kgs" );
            chat1.SeDeplacer(5);
            Console.WriteLine("Le nouveau poids du chat est de : " + chat1.Poids + " Kgs");
            Console.WriteLine(poisson1.Couleur);
            Console.WriteLine(poisson1.Poids);
            
            
        }
    }
}
