using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AmmiServices.DAL
{
    public class DBConnection
    {

       public List<Anime> GetAnimes ()
        {
            List<Anime> animes = new List<Anime>();
            string Query = "SELECT * FROM anime";
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand(Query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();

                myreader = comm.ExecuteReader();
                while (myreader.Read())
                {
                    Anime anime = new Anime();
                    anime.fName = myreader.GetString("name").ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
               conn.Close();

            return animes;
       }
    }
}
