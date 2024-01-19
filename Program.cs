using etudiantsoir;

//IHM tt = new IHM();
//tt.menu();
Dao dao=new Dao();
//dao.addEtudiantdb(4, "hhh", DateTime.Now, "femme");
//dao.deleteetudiant(2);
Etudiant? ee= dao.findById(1);
Console.WriteLine(ee.Nom);

