using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etudiantsoir
{
    internal class Dao
    {
        List<Etudiant> Etudiants = new List<Etudiant>();
        public void addEtudiant(Etudiant e)
        {
            Etudiants.Add(e);
           
        }

        public void addEtudiant(int id, string nom, DateTime date, string sexe)
        {
            Etudiant e=new Etudiant(id, nom, date, sexe);
            Etudiants.Add(e);

        }

        public Etudiant? findById(int id)
        {
          return   Etudiants.Find(a => a.Id == id);
        }

        public List<Etudiant> allEtudiant()
        {
            
            return Etudiants;
         }

        public bool deleteEtudiant(int id)
        { 
            Etudiant? e= Etudiants.Find(a => a.Id == id);
           return  Etudiants.Remove(e);
        }
    }
}
