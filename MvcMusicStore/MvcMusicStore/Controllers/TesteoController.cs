using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class TesteoController : Controller
    {
        // GET: Testeo
        public ActionResult Index()
        {
            FloraAndFaunaEntities db = new FloraAndFaunaEntities();
            PLANTA planta = db.PLANTAs.SingleOrDefault(x => x.idplanta == 1);

            PlantaViewModel plantaVM = new PlantaViewModel();
            plantaVM.idplanta = planta.idplanta;
            plantaVM.nombrePlanta = planta.nombrePlanta;
            plantaVM.especie = planta.especie;
            plantaVM.flor = planta.flor;
            plantaVM.familia = planta.familia;
            plantaVM.nombrechileno = planta.nombrechileno;
            plantaVM.nombreingles = planta.nombreingles;
            plantaVM.description = planta.description;

            return View(plantaVM);
        }
    }
}