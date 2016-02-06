using Demo_NMM.Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_NMM.Basic.DAL
{
    public static class Data
    {
        public static void InitializeBreweries()
        {
            List<Brewery> breweries = new List<Brewery>();

            breweries.Add(new Brewery
            {
                ID = 1,
                Name = "Right Brain Brewery",
                Address = "225 E. 16th St",
                City = "Traverse City",
                State = AppEnum.StateAbrv.MI,
                Zip = "49684",
                Phone = "(231) 944-1239"
            });

            breweries.Add(new Brewery
            {
                ID = 2,
                Name = "Acoustic Tap Room",
                Address = "119 Maple St",
                City = "Traverse City",
                State = AppEnum.StateAbrv.MI,
                Zip = "49684",
                Phone = "(231) 883-2012"
            });

            breweries.Add(new Brewery
            {
                ID = 3,
                Name = "Beggars Brewery",
                Address = "4177 Village Park Dr. Suite C",
                City = "Traverse City",
                State = AppEnum.StateAbrv.MI,
                Zip = "49684",
                Phone = "N/A"
            });

            HttpContext.Current.Session["Breweries"] = breweries;

        }
    }
}