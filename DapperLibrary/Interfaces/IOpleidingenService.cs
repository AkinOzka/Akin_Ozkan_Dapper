using DapperLibrary.Models;
using System.Collections.Generic;

namespace DapperLibrary
{
    public interface IOpleidingenService
    {
        bool AddNewDocent(Docent docent);
        void DeleteDocent(int docentNr);
        List<Campus> GetCampussen();
        List<Docent> GetDetailsDocent();
        List<Docent> GetDocenten();
    }
}