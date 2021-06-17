using System;

namespace PremierProjet
{
    class Program
    {
        static void Main(string[] args)
        {
            //<type> <NomVariable> [=valeur contenu] [, 2ème variable];
            string MonTexte;
            MonTexte = "Hello World !";
            Console.WriteLine(MonTexte);
            Console.WriteLine("-------------------------");
            // var NomClient="Jean";
            int[] tableau;
            // tableau = new int[10];
            // tableau[0] = 1;
            // tableau[4] = 2;

            tableau = new int[] { 1, 5, 6, 8, 14, 17 };

            Console.WriteLine("la valeur est : " + tableau[4]);
            Console.WriteLine("-------------------------");
            // opérateur ternaire
            //<expression booleene>?<retour si true>:retour si false>;
            int age = 50;
            string MaReponse;
            MaReponse = (age <= 30) ? "jeune" : "Moins jeune";
            Console.WriteLine(MaReponse);
            Console.WriteLine("-------------------------");
            // conditionnelle IF
            if (age<=30)
            {
                // si expression vraie
                Console.WriteLine("MoinsJeune");
            }
            Console.WriteLine(MaReponse);
            Console.WriteLine("-------------------------");

            object x = 6;
            //Motifs constants
            if (x is 4) Console.WriteLine("x is 4");
            if (x is 6) Console.WriteLine("x is 6");
            //Motifs type
            if (x is string s) Console.WriteLine("x is string s");
            if (x is int i) Console.WriteLine("x is int i");
            //Motif d'assignation
            if (x is var v) Console.WriteLine("x is var v");
            //Console.readLine();
            
            Console.WriteLine("-------------------------");

            //###################################################################
            //Structure Iteratives
            //###################################################################

            //boucle  FOR
            // for(instruction initialisation;fin d'iteration; incrementation)
            //
            //instruction executées autant de fois que d'iteration
            //
            int[] MonTableau;
            MonTableau = new int[10];

            for (int compteur = 0;compteur<MonTableau.Length; compteur = compteur + 1) 
            {
                MonTableau[compteur] = compteur;
            }

            Console.WriteLine(MonTableau[7]);
            Console.WriteLine("-------------------------");
            //boucles While & Do While
            //tant que
            int test = 0;
                while (test<MonTableau.Length) 

            {
                // ce que je fait
                MonTableau[test] = test+5;
                // ne pas oublier l'incrementation sinon boucle infinie !!!
                test = test + 1;
            }
            Console.WriteLine(MonTableau[7]);
            Console.WriteLine("-------------------------");

            do
            {
                //traitement
            } while (test < MonTableau.Length);

            // Pour chaque éléments d'un groupe
            // foreach (<type><nom de variable> in <collection>)
            string[] ArcEnCiel =
                {"rouge" , "orange","jaune","vert","bleu","indigo","violet" };

            foreach (string MaCouleur in ArcEnCiel)
            {
                Console.WriteLine("La couleur est : " + MaCouleur);
            }


        }
    }
}
