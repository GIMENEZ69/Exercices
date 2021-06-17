using System;

namespace Vehicule
{
    class Program
    {
        public class Vehicule
        {
            // Propriete du vehicule
            protected string couleur;
            protected int poids;


            //Constructeur
            public Vehicule(string couleurVehicule, int poidsVehicule)
            {
                couleur = couleurVehicule;
                poids = poidsVehicule;
            }
            // Accesseur
            public int Poids
            {
                get { return poids; }
                set { poids = value; }
            }
            public string Couleur
            {
                get { return couleur; }
                set { couleur = value; }
            }
            //Méthodes

            public void Rouler()
            {
                Console.WriteLine(" Ma Audi RS3 roule en direction du sud.");
            }
            public void ajouter_personne(int poidsPersonne, byte nombrePersonnes = 1)
            {
                //poids += poidspersonne;
                poids += poidsPersonne * nombrePersonnes;
            }
        }
        public class DeuxRoues : Vehicule
        {
            // Propriétés
            private int cylindree;

            //constructeur
            public DeuxRoues(string couleur, int poids, int cylindreeVehicule) : base(couleur, poids)
            {
                cylindree = cylindreeVehicule;
            }

            //accesseur 
            public int Cylindree
            {
                get { return cylindree; }
                set { cylindree = value; }
            }
            // Méthodes 
            public void MettreEssence(int quantiteLitre)
            {
                poids += quantiteLitre;
            }
        }
        public class QuatreRoues : Vehicule
        {
            // Propriétés
            private byte nombrePortes;

            // constructeur
            public QuatreRoues(string couleur, int poids, byte nombrePortesVehicule = 5) : base(couleur, poids)
            {
                nombrePortes = nombrePortesVehicule;
            }
            // Accesseurs 
            public byte NombrePortes
            {
                get { return nombrePortes; }
                set { nombrePortes = value; }
            }
            // Méthodes 
            public void Repeindre(string couleurPeinture)
            {
                couleur = couleurPeinture;
                Console.WriteLine($" Mon véhicule ( Audi RS3 !! ) est repeinte en {couleurPeinture}.");
            }

        }
        public class Voiture : QuatreRoues
        {
            // Propriété
            private byte pneusNeige;

            // constructeur
            public Voiture(string couleur, int poids, byte nombrePortes = 5, byte nombrePneusNeige = 0) : base(couleur, poids, nombrePortes)
            {
                pneusNeige = nombrePneusNeige;
            }
            // Accesseur voiture

            public byte PneuNeige
            {
                get { return pneusNeige; }
                set { pneusNeige = value; }
            }

            // Méthodes ajouter_pneu_neige et enlever_pneu_neige
            public void AjouterPneuNeige(byte nombre)
            {
                pneusNeige += nombre;
                Math.Clamp(pneusNeige, (byte)0, (byte)4);
            }
            public void EnleverPneuNeige(byte nombre)
            {
                pneusNeige -= nombre;
                Math.Clamp(pneusNeige, (byte)0, (byte)4);
            }
        }
        public class camion : QuatreRoues
        {
            //Propriétés
            int longueur;

            //constructeur
            public camion(string couleur, int poids, byte nombrePortes, int longueurCamion) : base(couleur, poids, nombrePortes)
            {
                longueur = longueurCamion;
            }

            //Accesseur 

            public int Longueur
            {
                get { return longueur; }

            }
            // Méthode
            public void AjouterRemorque(int longueurRemorque)
            {
                longueur += longueurRemorque;
            }

        }

        static void Main(string[] args)
        {
            Vehicule vehiculeNoir = new Vehicule("Audi RS3 noir", 1500);
            Console.WriteLine($" Ma nouvelle {vehiculeNoir.Couleur} pèse {vehiculeNoir.Poids} Kgs.");
            vehiculeNoir.Rouler();
            Console.WriteLine();
            vehiculeNoir.ajouter_personne(70);
            //vehiculeNoir.ajouter_essence(faire_plein);
            int MonPoids = 70;
            Console.WriteLine($" Le poids total de ma {vehiculeNoir.Couleur} avec 1 personne de {MonPoids} Kgs est de {vehiculeNoir.Poids} Kgs. ");
            Console.WriteLine();

            //Créer un véhicule vert de 1400 Kgs.
            Voiture voiture1 = new Voiture("Audi RS3 Vert", 1400);
            Console.WriteLine($" Le poids de ma seconde {voiture1.Couleur} est de {voiture1.Poids} Kgs.");
            // Ajouter 2 personnes de 65 Kgs chacune.
            // Afficher dans la console sa couleur et son nouveau poids.
            int Poids2 = 65;
            voiture1.ajouter_personne(65, 2);
            Console.WriteLine($" Le poids de ma {voiture1.Couleur} avec 2 personnes de {Poids2} Kgs est de {voiture1.Poids} Kgs ");
            Console.WriteLine();

            // Repeindre la voiture en rouge et ajouter 2 pneus neige.
            voiture1.Repeindre("rouge");
            voiture1.AjouterPneuNeige(2);
            // Afficher dans la console la couleur et son nombre de pneu neige.
            Console.WriteLine($" Ma Audi RS3 repeinte en {voiture1.Couleur} possède {voiture1.PneuNeige} pneus neige.");
            Console.WriteLine();

            // Créer un objet Deux_Roues noir de 120 Kgs.
            DeuxRoues moto = new DeuxRoues("Ninja Noir", 120, 2);
            // Ajouter 1 personne de 80 Kgs
            moto.ajouter_personne(80);
            // Mettre 20 Litres d'essence.
            moto.MettreEssence(20);
            int MotoPoids = 120;
            int PoidsAdulte = 80;
            int PoidsEssence = 20;
            // Afficher dans la console la couleur et le poids du deux roues
            Console.WriteLine($" Ma moto est une {moto.Couleur}. Seule elle pèse {MotoPoids} Kgs, je fait le plein avec {PoidsEssence} Litres d'essence et je pèse {PoidsAdulte} Kgs. ");
            Console.WriteLine($" Donc le poids total de ma {moto.Couleur} est de : {moto.Poids} Kgs.");
            Console.WriteLine();

            // Créer un camion bleu de 10000 Kgs et d'une longueur de 10 Mètres avec 2 portes.
            camion camion1 = new camion("Renault Trucks bleu ", 10000, 2, 10);
            // Lui ajouter une remorque de 5 Mètres et 1 personne de 80 Kgs.
            camion1.AjouterRemorque(5);
            camion1.ajouter_personne(80);
            int Poids3 = 10000;
            int Poids4 = 80;
            int Long = 10;
            int Long2 = 5;
            // Afficher dans la console la couleur , son poids , sa longueur et son nombre de portes.
            Console.WriteLine($" Mon camion {camion1.Couleur}seul pèse {Poids3} Kgs et mesure {Long} Mètres, on ajoute 1 personne de {Poids4} Kgs et 1 remorque de {Long2} Mètres. ");
            Console.WriteLine($" Son poids total est de : {camion1.Poids} Kgs et mesure maintenant {camion1.Longueur} Mètres de long et possède {camion1.NombrePortes} portes. ");
            Console.WriteLine();
            Console.WriteLine(" Merci de m'avoir lu.");













        }
    }
}
