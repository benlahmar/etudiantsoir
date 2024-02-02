using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etudiantsoir
{
    public interface IDao
    {
        public void addEtudiant(Etudiant e);
        public void addEtudiant(int id, string nom, DateTime date, string sexe);
        public Etudiant? findById(int id);
        public int deleteEtudiant(int id);
        public List<Etudiant> findAll();
    }
}
