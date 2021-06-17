// déclaration et instanciation d'un nouvel objet en utilisant son constructeur
CompteBancaire comptePierre = new CompteBancaire("Pierre", 0, "euros");

// appels de méthodes
comptePierre.Crediter(300);
comptePierre.Debiter(500);
Console.WriteLine(comptePierre.Decrire());
