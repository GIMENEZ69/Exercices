using System;

namespace Exo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tableau1;
            Tableau1 = new int[10];
            int[] Tableau2;
            Tableau2 = new int[10];
            int[] Tableau3;
            Tableau3 = new int[10];

            for (int compt = 0; compt < 10; compt = compt + 1)
            {
                Tableau1[compt] = compt + 1;
                Tableau2[compt] = Tableau1[compt] + 10;
                Tableau3[compt] = Tableau1[compt] + Tableau2[compt];
                Console.WriteLine(Tableau1[compt] + " | " + Tableau2[compt] + " | " + Tableau3[compt]);
            }
                Console.WriteLine();
                Console.WriteLine("*********************************");
                Console.WriteLine();
                Console.WriteLine("Exercice 2 !");

                //init des tableaux


                int[] Tableau4;
                int[] Tableau5;
                int ValeurS = 0;
                Tableau4 = new int[] { 6, 25, 35, 61 };
                Tableau5 = new int[] { 12, 24, 46 };
                foreach (int val1 in Tableau4)
                {
                    foreach (int val2 in Tableau5)
                    {
                        ValeurS = ValeurS + (val1 * val2);
                    }
                }
                Console.WriteLine("la valeur calculée est : " +ValeurS);
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("*********************************");
                Console.WriteLine();
                Console.WriteLine("Exercice 3 !");

                //initialisation et aleatoire du Tableau

                int[] MonTableau; // déclaration du tableau
                MonTableau = new int[10]; // instantiation du tableau
                Random Aleatoire = new Random();
                string MaChaine = "";
                //------------------------------------
                // remplissage du tableau
                for (int Index=0;Index<10;Index++)
                {
                    MonTableau[Index] = Aleatoire.Next(1,100);
                        Console.WriteLine(MonTableau[Index]);
                }
                // trier tableau
                Array.Sort(MonTableau);

                //construire la chaine d'affichage avec un foreach
                foreach (int Val1 in MonTableau)
                {
                    if (MaChaine == "")
                    {
                        MaChaine = MaChaine + Val1;
                    }
                    else
                    {
                        MaChaine = MaChaine + ";" + Val1;
                    }
                }
                Console.WriteLine(MaChaine);
        
        
 
        


                
               

            

            
            
        }
    }
}
