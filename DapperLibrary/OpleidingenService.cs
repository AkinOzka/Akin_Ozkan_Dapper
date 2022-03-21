using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DapperLibrary.Models;



namespace DapperLibrary
{
    public class OpleidingenService : IOpleidingenService
    {
        public List<Campus> GetCampussen()
        {
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                var campussen = connection.Query<Campus>("spGetAllCampussen", commandType: CommandType.StoredProcedure).ToList();
                return campussen;
            }
        }

        public List<Docent> GetDocenten()
        {
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                var docenten = connection.Query<Docent>("spGetAllDocenten", commandType: CommandType.StoredProcedure).ToList();
                return docenten;
            }
        }

        public bool AddNewDocent(Docent docent)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Voornaam", docent.Voornaam);
            param.Add("@Familienaam", docent.Familienaam);
            param.Add("@Wedde", docent.Wedde);
            param.Add("@CampusNr", docent.CampusNr);

            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                try
                {
                    connection.Execute("AddNewDocent", param, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public void DeleteDocent(int docentNr)
        {
            DynamicParameters param = new DynamicParameters();
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                connection.Execute("DELETE FROM Book where DocentNr=@DocentNr", new { DocentNr = docentNr });
            }
        }

        public List<Docent> GetDetailsDocent()
        {
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                var docenten = connection.Query<Docent>("spGetAllDocenten", commandType: CommandType.StoredProcedure).ToList();
                return docenten;
            }
        }
    }
}
