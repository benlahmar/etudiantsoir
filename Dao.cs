using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
namespace etudiantsoir
{
    public class Dao : IDao
    {
        List<Etudiant> Etudiants = new List<Etudiant>();

        public void addEtudiant(Etudiant e)
        {
            Etudiants.Add(e);

        }

        public void addEtudiant(int id, string nom, DateTime date, string sexe)
        {
            Etudiant e = new Etudiant(id, nom, date, sexe);
            Etudiants.Add(e);

        }

        public Etudiant? findById(int id)
        {
            Etudiant et=null ;
            DBInteraction.connect();
            string sql = "select * from etudiant where id=" + id;

            SqlDataReader rs = DBInteraction.select(sql);
            if (rs.Read())
            {
                et=new Etudiant();
                et.Id = rs.GetInt32(0);
                et.Nom = rs.GetString(1);
                et.Date = rs.GetDateTime(2);
                et.Sexe = rs.GetString(3);
            }
            DBInteraction.disconnect();
            return et;
        }

        public List<Etudiant> allEtudiant()
        {

            return Etudiants;
        }

        public bool deleteEtudiant(int id)
        {
            Etudiant? e = Etudiants.Find(a => a.Id == id);
            return Etudiants.Remove(e);
        }


        public void addEtudiantdb(int id, string nom, DateTime date, string sexe)
        {
            DBInteraction.connect();
            string sql = "insert into etudiant values(" + id + ",'" + nom + "','" + date + "','" + sexe + "')";
          int nb=  DBInteraction.Maj(sql);
            DBInteraction.disconnect();


        }

        public int deleteetudiant(int id)
        {
            DBInteraction.connect();
            string sql = "delete from etudiant where id=" + id;
            int nb = DBInteraction.Maj(sql);
            DBInteraction.disconnect();
           
           
            return nb;

        }

        public void getetudiant(int id)
        {
            DBInteraction.connect();
            string sql = "select * from etudiant where id=" + id;
            
            SqlDataReader rs = DBInteraction.select(sql);
            while (rs.Read())
            {
                Console.WriteLine(rs.GetString(1));
            }
            DBInteraction.disconnect();
        }
    } 
}

