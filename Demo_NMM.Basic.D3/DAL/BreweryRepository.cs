using Demo_NMM.Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_NMM.Basic.DAL
{
    public class BreweryRepository : IBreweryRepository
    {
        private List<Brewery> breweries = null;

        public BreweryRepository()
        {
            //this.breweries = new List<Brewery>();
            this.breweries = (List<Brewery>)HttpContext.Current.Session["Breweries"];
        }

        public BreweryRepository(List<Brewery> breweries)
        {
            this.breweries = breweries;
        }

        public IEnumerable<Brewery> SelectAll()
        {
            return this.breweries;
        }

        public Brewery SelectByID(int id)
        {
            var index = breweries.FindIndex(a => a.ID == id);

            if (index != -1)
            {
                return this.breweries[index];
            }
            else
            {
                throw new ArgumentException("BreweryNotFound");
            }
        }

        public void Insert(Brewery brewery)
        {
            this.breweries.Add(brewery);
        }

        public void Update(Brewery brewery)
        {
            var breweryToUpdate = this.breweries.FirstOrDefault(x => x.ID == brewery.ID);

            if (breweryToUpdate != null) breweryToUpdate = brewery;
            else throw new ArgumentException("BreweryNotFound");
        }

        public void Delete(int id)
        {
            var index = breweries.FindIndex(a => a.ID == id);
            
            if (index != -1) this.breweries.RemoveAt(index);
            else throw new ArgumentException("BreweryNotFound");
        }

        public void Save()
        {
            HttpContext.Current.Session["Breweries"] = this.breweries;
         }
    }
}