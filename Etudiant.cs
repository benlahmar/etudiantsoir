using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etudiantsoir
{
    public class Etudiant
    {
        int id;
        string nom;
        DateTime date;
        string sexe;

        public Etudiant()
        {
        }

        public Etudiant(int id, string nom, DateTime date, string sexe)
        {
            this.id = id;
            this.nom = nom;
            this.date = date;
            this.sexe = sexe;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Sexe { get => sexe; set => sexe = value; }
    }
}
