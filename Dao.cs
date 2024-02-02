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
        

        public void addEtudiant(Etudiant e)
        {
            DBInteraction.connect();
            string sql = "insert into etudiant values(" + e.Id + ",'" + e.Nom + "','" + e.Date + "','" + e.Sexe + "')";
            int nb = DBInteraction.Maj(sql);
            DBInteraction.disconnect();

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

      

        public void addEtudiant(int id, string nom, DateTime date, string sexe)
        {
            DBInteraction.connect();
            string sql = "insert into etudiant values(" + id + ",'" + nom + "','" + date + "','" + sexe + "')";
          int nb=  DBInteraction.Maj(sql);
            DBInteraction.disconnect();


        }

        public int deleteEtudiant(int id)
        { DBInteraction.connect();
            string sql = "delete from etudiant where id=" + id;
            int nb = DBInteraction.Maj(sql);
            DBInteraction.disconnect();
            return nb;

        }

        public List<Etudiant> findAll()
        {
            List<Etudiant> ets=new List<Etudiant> ();

            
            DBInteraction.connect();
            string sql = "select * from etudiant";

            SqlDataReader rs = DBInteraction.select(sql);
            while (rs.Read())
            {
                Etudiant et = new Etudiant();
                et.Id = rs.GetInt32(0);
                et.Nom = rs.GetString(1);
                et.Date = rs.GetDateTime(2);
                et.Sexe = rs.GetString(3);
                ets.Add(et);
            }
            DBInteraction.disconnect();
            return ets;
        }

    } 
}

