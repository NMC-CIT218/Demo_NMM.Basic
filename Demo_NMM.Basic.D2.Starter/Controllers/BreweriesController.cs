using Demo_NMM.Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_NMM.Basic.Controllers
{
    public class BreweriesController : Controller
    {
        // GET: Breweries
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowTable()
        {
            List<Brewery> breweries = (List<Brewery>)Session["Breweries"];

            Session["Breweries"] = breweries;

            return View(breweries);
        }

        public ActionResult ShowList()
        {
            List<Brewery> breweries = (List<Brewery>)Session["Breweries"];

            Session["Breweries"] = breweries;

            return View(breweries);
        }

        public ActionResult ShowDetail(int id)
        {
            return View();
        }


        public ActionResult DeleteBrewery(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteBrewery(FormCollection form)
        {
            return View();
        }

        public ActionResult CreateBrewery()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBrewery(FormCollection form)
        {
            return View();
        }

        public ActionResult UpdateBrewery(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateBrewery(FormCollection form)
        {
            return View();
        }

        public ActionResult ReloadData()
        {
            DAL.Data.InitializeBreweries();

            return Redirect("/Breweries/ShowTable");
        }

        private int GetNextID()
        {
            List<Brewery> breweries = (List<Brewery>)Session["Breweries"];

            return breweries.Max(x => x.ID) + 1;
        }
    }
}