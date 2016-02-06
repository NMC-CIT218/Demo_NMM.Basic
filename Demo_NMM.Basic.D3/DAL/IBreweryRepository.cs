using Demo_NMM.Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_NMM.Basic.DAL
{
    public interface IBreweryRepository
    {
        IEnumerable<Brewery> SelectAll();
        Brewery SelectByID(int id);
        void Insert(Brewery brewery);
        void Update(Brewery brewery);
        void Delete(int id);
        void Save();
    }
}