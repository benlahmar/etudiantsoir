using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etudiantsoir
{
    public class IHM
    {
        Dao dao=new Dao();
        string choix;
        public void menu()
        {
            Console.WriteLine("choisir une operation");
            Console.WriteLine("1------ add");
            Console.WriteLine("2------ find");
            Console.WriteLine("3------ delete");
            Console.WriteLine("4------ lister");
            Console.WriteLine("q------ quitter");
            choix = Console.ReadLine();
            while (choix != "q")
            {
                start();
                Console.WriteLine("un autre essai");
                choix = Console.ReadLine();
            }
        }

        public void start()
        {
            int id;
                switch (choix)
            {
                case "1":
                    Console.WriteLine("saisir le id");
                     id= Int32.Parse(Console.ReadLine());
                    Console.WriteLine("entrer le nom");
                    string nom = Console.ReadLine();
                    Console.WriteLine("entrer la date");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("entrer le sexe");
                    string sexe = Console.ReadLine();
                    dao.addEtudiant(id, nom, date, sexe);
                    break;
                case "2":
                    Console.WriteLine("saisir le id");
                     id = Int32.Parse(Console.ReadLine());
                    Etudiant? ee = dao.findById(id);
                    Console.WriteLine(ee.Nom+".."+ee.Sexe);
                    break;
            }    
        }
    }
}
