using Civpedia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Civpedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CivpediaModel _civPediaModel;

        public HomeController(ILogger<HomeController> logger, CivpediaModel civPediaModel)
        {
            _logger = logger;
            _civPediaModel = civPediaModel;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Merveilles()
        {
            return View();
        }

        public IActionResult Conversion()
        {
            return View();
        }

        public IActionResult Unite(int idCivilisation, int idUnite)
        {
            ViewBag.Unite = _civPediaModel.getUnite(idCivilisation, idUnite);
            return View();
        }

        public IActionResult Civilisations(string RechercheNomDirigeant = "", string RechercheTitrePassifDirigeant = "", string RecherchePassifDirigeant = "", string RechercheNomEmpire = "", string RechercheTitrePassifEmpire = "", string RecherchePassifEmpire = "", string RechercheNomQuartierEmpire = "", string RechercheQuartierEmpire = "", string RechercheNomBatimentEmpire = "", string RechercheBatimentEmpire = "", string RechercheNomAmenagementEmpire = "", string RechercheAmenagementEmpire = "", string tri = "", string continents = "")
        {
            TriEntity unTri = Tri(tri);
            RechercheNomDirigeant = String.IsNullOrEmpty(RechercheNomDirigeant) ? "" : RechercheNomDirigeant;
            RechercheTitrePassifDirigeant = String.IsNullOrEmpty(RechercheTitrePassifDirigeant) ? "" : RechercheTitrePassifDirigeant;
            RecherchePassifDirigeant = String.IsNullOrEmpty(RecherchePassifDirigeant) ? "" : RecherchePassifDirigeant;
            RechercheNomEmpire = String.IsNullOrEmpty(RechercheNomEmpire) ? "" : RechercheNomEmpire;
            RechercheTitrePassifEmpire = String.IsNullOrEmpty(RechercheTitrePassifEmpire) ? "" : RechercheTitrePassifEmpire;
            RecherchePassifEmpire = String.IsNullOrEmpty(RecherchePassifEmpire) ? "" : RecherchePassifEmpire;
            RechercheNomQuartierEmpire = String.IsNullOrEmpty(RechercheNomQuartierEmpire) ? "" : RechercheNomQuartierEmpire;
            RechercheQuartierEmpire = String.IsNullOrEmpty(RechercheQuartierEmpire) ? "" : RechercheQuartierEmpire;
            RechercheNomBatimentEmpire = String.IsNullOrEmpty(RechercheNomBatimentEmpire) ? "" : RechercheNomBatimentEmpire;
            RechercheBatimentEmpire = String.IsNullOrEmpty(RechercheBatimentEmpire) ? "" : RechercheBatimentEmpire;
            RechercheNomAmenagementEmpire = String.IsNullOrEmpty(RechercheNomAmenagementEmpire) ? "" : RechercheNomAmenagementEmpire;
            RechercheAmenagementEmpire = String.IsNullOrEmpty(RechercheAmenagementEmpire) ? "" : RechercheAmenagementEmpire;
            ViewBag.Civilisations = _civPediaModel.getCivilisations(RechercheNomDirigeant, RechercheTitrePassifDirigeant, RecherchePassifDirigeant, RechercheNomEmpire, RechercheTitrePassifEmpire, RecherchePassifEmpire, RechercheNomQuartierEmpire, RechercheQuartierEmpire, RechercheNomBatimentEmpire, RechercheBatimentEmpire, RechercheNomAmenagementEmpire, RechercheAmenagementEmpire, unTri, continents);
            return View();
        }

        public TriEntity Tri(string tri = "")
        {
            switch(tri)
            {
                case "0":
                    HttpContext.Session.SetString("NameDirigeantOrder", HttpContext.Session.GetString("NameDirigeantOrder") == "NameDirigeant" ? "NameDirigeantDesc" : HttpContext.Session.GetString("NameDirigeantOrder") == "NameDirigeantDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameDirigeantOrder")) ? "NameDirigeant" : "");  
                   // NameDirigeantOrder = NameDirigeantOrder == "NameDirigeantDesc" ? "NameDirigeant" : "NameDirigeantDesc";
                    break;
                case "1":
                    HttpContext.Session.SetString("TitlePassifDirigeantOrder", HttpContext.Session.GetString("TitlePassifDirigeantOrder") == "TitlePassifDirigeant" ? "TitlePassifDirigeantDesc" : HttpContext.Session.GetString("TitlePassifDirigeantOrder") == "TitlePassifDirigeantDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("TitlePassifDirigeantOrder")) ? "TitlePassifDirigeant" : "");
                    //TitlePassifDirigeantOrder = TitlePassifDirigeantOrder == "TitlePassifDirigeantDesc" ? "TitlePassifDirigeant" : "TitlePassifDirigeantDesc"; 
                    break;
                case "2":
                    HttpContext.Session.SetString("PassifDirigeantOrder", HttpContext.Session.GetString("PassifDirigeantOrder") == "PassifDirigeant" ? "PassifDirigeantDesc" :  HttpContext.Session.GetString("PassifDirigeantOrder") == "PassifDirigeantDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("PassifDirigeantOrder")) ? "PassifDirigeant" : "");
                    //PassifDirigeantOrder = PassifDirigeantOrder == "PassifDirigeantDesc" ? "PassifDirigeant" : "PassifDirigeantDesc"; 
                    break;
                case "3":
                    HttpContext.Session.SetString("NameEmpireOrder", HttpContext.Session.GetString("NameEmpireOrder") == "NameEmpire" ? "NameEmpireDesc" : HttpContext.Session.GetString("NameEmpireOrder") == "NameEmpireDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameEmpireOrder")) ? "NameEmpire" : "");
                   // NameEmpireOrder = NameEmpireOrder == "NameEmpireDesc" ? "NameEmpire" : "NameEmpireDesc"; 
                    break;
                case "4":
                    HttpContext.Session.SetString("TitlePassifEmpireOrder", HttpContext.Session.GetString("TitlePassifEmpireOrder") == "TitlePassifEmpire" ? "TitlePassifEmpireDesc" : HttpContext.Session.GetString("TitlePassifEmpireOrder") == "TitlePassifEmpireDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("TitlePassifEmpireOrder")) ? "TitlePassifEmpire" : "");
                   // TitlePassifEmpireOrder = TitlePassifEmpireOrder == "TitlePassifEmpireDesc" ? "TitlePassifEmpire" : "TitlePassifEmpireDesc"; 
                    break;
                case "5":
                    HttpContext.Session.SetString("PassifEmpireOrder", HttpContext.Session.GetString("PassifEmpireOrder") == "PassifEmpire" ? "PassifEmpireDesc" : HttpContext.Session.GetString("PassifEmpireOrder") == "PassifEmpireDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("PassifEmpireOrder")) ? "PassifEmpire" : "");
                    //PassifEmpireOrder = PassifEmpireOrder == "PassifEmpireDesc" ? "PassifEmpire" : "PassifEmpireDesc"; 
                    break;
                case "6":
                    HttpContext.Session.SetString("NameQuartierOrder", HttpContext.Session.GetString("NameQuartierOrder") == "NameQuartier" ? "NameQuartierDesc" : HttpContext.Session.GetString("NameQuartierOrder") == "NameQuartierDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameQuartierOrder")) ? "NameQuartier" : "");
                    //NameQuartierOrder = NameQuartierOrder == "NameQuartierDesc" ? "NameQuartier" : "NameQuartierDesc"; 
                    break;
                case "7":
                    HttpContext.Session.SetString("QuartierOrder", HttpContext.Session.GetString("QuartierOrder") == "Quartier" ? "QuartierDesc" : HttpContext.Session.GetString("QuartierOrder") == "QuartierDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("QuartierOrder")) ? "Quartier" : "");
                    //QuartierOrder = QuartierOrder == "QuartierDesc" ? "Quartier" : "QuartierDesc"; 
                    break;
                case "8":
                    HttpContext.Session.SetString("NameBatimentOrder", HttpContext.Session.GetString("NameBatimentOrder") == "NameBatiment" ? "NameBatimentDesc" : HttpContext.Session.GetString("NameBatimentOrder") == "NameBatimentDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameBatimentOrder")) ? "NameBatiment" : "");
                    //NameBatimentOrder = NameBatimentOrder == "NameBatimentDesc" ? "NameBatiment" : "NameBatimentDesc"; 
                    break;
                case "9":
                    HttpContext.Session.SetString("BatimentOrder", HttpContext.Session.GetString("BatimentOrder") == "Batiment" ? "BatimentDesc" : HttpContext.Session.GetString("BatimentOrder") == "BatimentDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("BatimentOrder")) ? "Batiment" : "");
//                    BatimentOrder = BatimentOrder == "BatimentDesc" ? "Batiment" : "BatimentDesc"; 
                    break;
                case "10":
                    HttpContext.Session.SetString("NameAmenagementOrder", HttpContext.Session.GetString("NameAmenagementOrder") == "NameAmenagement" ? "NameAmenagementDesc" : HttpContext.Session.GetString("NameAmenagementOrder") == "NameAmenagementDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameAmenagementOrder")) ? "NameAmenagement" : "");
                    //NameAmenagementOrder = NameAmenagementOrder == "NameAmenagementDesc" ? "NameAmenagement" : "NameAmenagementDesc"; 
                    break;
                case "11":
                    HttpContext.Session.SetString("AmenagementOrder", HttpContext.Session.GetString("AmenagementOrder") == "Amenagement" ? "AmenagementDesc" : HttpContext.Session.GetString("AmenagementOrder") == "AmenagementDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("AmenagementOrder")) ? "Amenagement" : "");
                    //AmenagementOrder = AmenagementOrder == "AmenagementDesc" ? "Amenagement" : "AmenagementDesc"; 
                    break;
            }

            TriEntity unTri = new TriEntity(HttpContext.Session.GetString("NameDirigeantOrder"), HttpContext.Session.GetString("TitlePassifDirigeantOrder"), HttpContext.Session.GetString("PassifDirigeantOrder"), HttpContext.Session.GetString("NameEmpireOrder"), HttpContext.Session.GetString("TitlePassifEmpireOrder"), HttpContext.Session.GetString("PassifEmpireOrder"), HttpContext.Session.GetString("NameQuartierOrder"), HttpContext.Session.GetString("QuartierOrder"), HttpContext.Session.GetString("NameBatimentOrder"), HttpContext.Session.GetString("BatimentOrder"), HttpContext.Session.GetString("NameAmenagementOrder"), HttpContext.Session.GetString("AmenagementOrder"));



            return unTri;
        }

        public IActionResult CitesEtats()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
