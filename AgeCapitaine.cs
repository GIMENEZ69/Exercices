using System;

namespace _1erProgramme
{
    class Program
    {

        //<modificateurs d'accès><type de retour><Nom_Fonction>([parametres1],
        //[parametres2]...])
        //{
            //traitements
            //return<valeur>;
        //}
        // fonction sans arametres
        static int AgeDuCapitaine()
        {
            int ageducapitaine = 25;
            return ageducapitaine;
        }

        static decimal CalculerTTC(decimal PrixHt,decimal TauxTva=0.2M)
        {
            return PrixHt * (1+TauxTva);
        }

        static additionnerNombre(int Nb1,int Nb2)
        {
            return Nb1 + Nb2;
        }
        static additionnerNombre(int Nb1, int Nb2, int Nb3)
        {
            return Nb1 + Nb2 + Nb3;
        }

        static void MaProcedure()
        {
            //traitements
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AgeDuCapitaine());
            Console.WriteLine("----------------------------");
            Console.WriteLine(CalculerTTC(10.25M,0.2M));
            Console.WriteLine(CalculerTTC(TauxTva:0.5M,PrixHt:15.05M));
        }
    }
}
