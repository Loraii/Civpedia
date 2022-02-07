using Civpedia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

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

        //Fonctions d'ajout
        public IActionResult AddCivilisation(string NomDirigeant, string TitrePassifDirigeant, string PassifDirigeant, string NomEmpire, string TitrePassifEmpire, string PassifEmpire, string NomQuartierEmpire, string QuartierEmpire, string NomBatimentEmpire, string BatimentEmpire, string NomAmenagementEmpire, string AmenagementEmpire, string[] NomUnite, int[] AttaqueUnite, string[] TexteUnite, string[] AmenagementUnite)
        {
            _civPediaModel.addCivilisation(NomDirigeant, TitrePassifDirigeant, PassifDirigeant, NomEmpire, TitrePassifEmpire, PassifEmpire, NomQuartierEmpire, QuartierEmpire, NomBatimentEmpire, BatimentEmpire, NomAmenagementEmpire, AmenagementEmpire, NomUnite, AttaqueUnite, TexteUnite, AmenagementUnite);
             Civilisations();
            return View("Civilisations");
        }

        public IActionResult AddMerveilleNaturelle(string NomMerveille, string Effet, int NbCases)
        {
            _civPediaModel.addMerveilleNaturelle(NomMerveille, Effet, NbCases);
            Merveilles();
            return View("Merveilles");
        }

        public IActionResult AddMerveilleDuMonde(string NomMerveille, string EreMerveille, string PrerequisMerveille, string Effet)
        {
            _civPediaModel.addMerveilleDuMonde(NomMerveille, EreMerveille, PrerequisMerveille, Effet);
            MerveillesMonde();
            return View("MerveillesMonde");
        }

        public IActionResult AddCiteEtat(string NomCiteEtat, string TypeCiteEtat, string BonusCiteEtat, string AmenagementCiteEtat, string UniteCiteEtat)
        {
            _civPediaModel.addCiteEtat(NomCiteEtat, TypeCiteEtat, BonusCiteEtat, AmenagementCiteEtat, UniteCiteEtat);
            CitesEtats();
            return View("CitesEtats");
        }

        //Mise en forme des données pour les vues
        public IActionResult Civilisations(string RechercheNomDirigeant = "", string RechercheTitrePassifDirigeant = "", string RecherchePassifDirigeant = "", string RechercheNomEmpire = "", string RechercheTitrePassifEmpire = "", string RecherchePassifEmpire = "", string RechercheNomQuartierEmpire = "", string RechercheQuartierEmpire = "", string RechercheNomBatimentEmpire = "", string RechercheBatimentEmpire = "", string RechercheNomAmenagementEmpire = "", string RechercheAmenagementEmpire = "", string tri = "", string continents = "")
        {
            TriEntity unTri = TriCivilisation(tri);
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

        public IActionResult Unite(int idCivilisation, int idUnite)
        {
            ViewBag.Unite = _civPediaModel.getUnite(idCivilisation, idUnite);
            return View();
        }

        public IActionResult Merveilles(string RechercheNomMerveille = "", string RechercheEffetMerveille = "", string tri = "", string TailleMerveille = "")
        {
            string triAFaire = TriMerveillesNaturelles(tri);
            RechercheNomMerveille = String.IsNullOrEmpty(RechercheNomMerveille) ? "" : RechercheNomMerveille;
            RechercheEffetMerveille = String.IsNullOrEmpty(RechercheEffetMerveille) ? "" : RechercheEffetMerveille;
            ViewBag.MerveillesNaturelles = _civPediaModel.getMerveillesNaturelles(RechercheNomMerveille, RechercheEffetMerveille, triAFaire, TailleMerveille);
            return View();
        }

        public IActionResult MerveillesMonde(string RechercheNomMerveille = "", string RechercheEreMerveille = "", string RecherchePrerequisMerveille = "", string RechercheEffetMerveille = "", string tri = "")
        {
            string triAFaire = TriMerveillesDuMonde(tri);
            RechercheNomMerveille = String.IsNullOrEmpty(RechercheNomMerveille) ? "" : RechercheNomMerveille;
            RechercheEreMerveille = String.IsNullOrEmpty(RechercheEreMerveille) ? "" : RechercheEreMerveille;
            RecherchePrerequisMerveille = String.IsNullOrEmpty(RecherchePrerequisMerveille) ? "" : RecherchePrerequisMerveille;
            RechercheEffetMerveille = String.IsNullOrEmpty(RechercheEffetMerveille) ? "" : RechercheEffetMerveille;
            ViewBag.MerveillesDuMonde = _civPediaModel.getMerveillesDuMonde(RechercheNomMerveille, RechercheEreMerveille, RecherchePrerequisMerveille, RechercheEffetMerveille, triAFaire);
            return View();
        }

        public IActionResult CitesEtats(string RechercheNomCiteEtat = "", string RechercheTypeCiteEtat = "", string RechercheBonusCiteEtat = "", string RechercheAmenagementCiteEtat = "", string RechercheUniteCiteEtat = "", string tri = "")
        {
            string triAFaire = TriCitesEtats(tri);
            RechercheNomCiteEtat = String.IsNullOrEmpty(RechercheNomCiteEtat) ? "" : RechercheNomCiteEtat;
            RechercheTypeCiteEtat = String.IsNullOrEmpty(RechercheTypeCiteEtat) ? "" : RechercheTypeCiteEtat;
            RechercheBonusCiteEtat = String.IsNullOrEmpty(RechercheBonusCiteEtat) ? "" : RechercheBonusCiteEtat;
            RechercheAmenagementCiteEtat = String.IsNullOrEmpty(RechercheAmenagementCiteEtat) ? "" : RechercheAmenagementCiteEtat;
            RechercheUniteCiteEtat = String.IsNullOrEmpty(RechercheUniteCiteEtat) ? "" : RechercheUniteCiteEtat;
            ViewBag.CitesEtats = _civPediaModel.getCitesEtats(RechercheNomCiteEtat, RechercheTypeCiteEtat, RechercheBonusCiteEtat, RechercheAmenagementCiteEtat, RechercheUniteCiteEtat, triAFaire);
            return View();
        }

        //Fonctions de tri
        public TriEntity TriCivilisation(string tri = "")
        {
            switch(tri)
            {
                case "0":
                    HttpContext.Session.SetString("NameDirigeantOrder", HttpContext.Session.GetString("NameDirigeantOrder") == "NameDirigeant" ? "NameDirigeantDesc" : HttpContext.Session.GetString("NameDirigeantOrder") == "NameDirigeantDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameDirigeantOrder")) ? "NameDirigeant" : "");  
                    break;
                case "1":
                    HttpContext.Session.SetString("TitlePassifDirigeantOrder", HttpContext.Session.GetString("TitlePassifDirigeantOrder") == "TitlePassifDirigeant" ? "TitlePassifDirigeantDesc" : HttpContext.Session.GetString("TitlePassifDirigeantOrder") == "TitlePassifDirigeantDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("TitlePassifDirigeantOrder")) ? "TitlePassifDirigeant" : "");
                    break;
                case "2":
                    HttpContext.Session.SetString("PassifDirigeantOrder", HttpContext.Session.GetString("PassifDirigeantOrder") == "PassifDirigeant" ? "PassifDirigeantDesc" :  HttpContext.Session.GetString("PassifDirigeantOrder") == "PassifDirigeantDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("PassifDirigeantOrder")) ? "PassifDirigeant" : "");
                    break;
                case "3":
                    HttpContext.Session.SetString("NameEmpireOrder", HttpContext.Session.GetString("NameEmpireOrder") == "NameEmpire" ? "NameEmpireDesc" : HttpContext.Session.GetString("NameEmpireOrder") == "NameEmpireDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameEmpireOrder")) ? "NameEmpire" : ""); 
                    break;
                case "4":
                    HttpContext.Session.SetString("TitlePassifEmpireOrder", HttpContext.Session.GetString("TitlePassifEmpireOrder") == "TitlePassifEmpire" ? "TitlePassifEmpireDesc" : HttpContext.Session.GetString("TitlePassifEmpireOrder") == "TitlePassifEmpireDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("TitlePassifEmpireOrder")) ? "TitlePassifEmpire" : ""); 
                    break;
                case "5":
                    HttpContext.Session.SetString("PassifEmpireOrder", HttpContext.Session.GetString("PassifEmpireOrder") == "PassifEmpire" ? "PassifEmpireDesc" : HttpContext.Session.GetString("PassifEmpireOrder") == "PassifEmpireDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("PassifEmpireOrder")) ? "PassifEmpire" : "");
                    break;
                case "6":
                    HttpContext.Session.SetString("NameQuartierOrder", HttpContext.Session.GetString("NameQuartierOrder") == "NameQuartier" ? "NameQuartierDesc" : HttpContext.Session.GetString("NameQuartierOrder") == "NameQuartierDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameQuartierOrder")) ? "NameQuartier" : "");
                    break;
                case "7":
                    HttpContext.Session.SetString("QuartierOrder", HttpContext.Session.GetString("QuartierOrder") == "Quartier" ? "QuartierDesc" : HttpContext.Session.GetString("QuartierOrder") == "QuartierDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("QuartierOrder")) ? "Quartier" : ""); 
                    break;
                case "8":
                    HttpContext.Session.SetString("NameBatimentOrder", HttpContext.Session.GetString("NameBatimentOrder") == "NameBatiment" ? "NameBatimentDesc" : HttpContext.Session.GetString("NameBatimentOrder") == "NameBatimentDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameBatimentOrder")) ? "NameBatiment" : ""); 
                    break;
                case "9":
                    HttpContext.Session.SetString("BatimentOrder", HttpContext.Session.GetString("BatimentOrder") == "Batiment" ? "BatimentDesc" : HttpContext.Session.GetString("BatimentOrder") == "BatimentDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("BatimentOrder")) ? "Batiment" : "");
                    break;
                case "10":
                    HttpContext.Session.SetString("NameAmenagementOrder", HttpContext.Session.GetString("NameAmenagementOrder") == "NameAmenagement" ? "NameAmenagementDesc" : HttpContext.Session.GetString("NameAmenagementOrder") == "NameAmenagementDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameAmenagementOrder")) ? "NameAmenagement" : ""); 
                    break;
                case "11":
                    HttpContext.Session.SetString("AmenagementOrder", HttpContext.Session.GetString("AmenagementOrder") == "Amenagement" ? "AmenagementDesc" : HttpContext.Session.GetString("AmenagementOrder") == "AmenagementDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("AmenagementOrder")) ? "Amenagement" : "");
                    break;
            }

            TriEntity unTri = new TriEntity(HttpContext.Session.GetString("NameDirigeantOrder"), HttpContext.Session.GetString("TitlePassifDirigeantOrder"), HttpContext.Session.GetString("PassifDirigeantOrder"), HttpContext.Session.GetString("NameEmpireOrder"), HttpContext.Session.GetString("TitlePassifEmpireOrder"), HttpContext.Session.GetString("PassifEmpireOrder"), HttpContext.Session.GetString("NameQuartierOrder"), HttpContext.Session.GetString("QuartierOrder"), HttpContext.Session.GetString("NameBatimentOrder"), HttpContext.Session.GetString("BatimentOrder"), HttpContext.Session.GetString("NameAmenagementOrder"), HttpContext.Session.GetString("AmenagementOrder"));

            return unTri;
        }

        public string TriMerveillesNaturelles(string tri = "")
        {
            string retour = "";
            switch (tri)
            {
                case "0":
                    HttpContext.Session.SetString("NameMerveilleOrder", HttpContext.Session.GetString("NameMerveilleOrder") == "NameMerveille" ? "NameMerveilleDesc" : HttpContext.Session.GetString("NameMerveilleOrder") == "NameMerveilleDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameMerveilleOrder")) ? "NameMerveille" : "");
                    retour = HttpContext.Session.GetString("NameMerveilleOrder");
                    HttpContext.Session.SetString("EffetMerveilleOrder", "");
                    break;
                case "1":
                    HttpContext.Session.SetString("EffetMerveilleOrder", HttpContext.Session.GetString("EffetMerveilleOrder") == "EffetMerveille" ? "EffetMerveilleDesc" : HttpContext.Session.GetString("EffetMerveilleOrder") == "EffetMerveilleDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("EffetMerveilleOrder")) ? "EffetMerveille" : "");
                    retour = HttpContext.Session.GetString("EffetMerveilleOrder");
                    HttpContext.Session.SetString("NameMerveilleOrder", "");
                    break;
            }

            return retour;
        }

        public string TriMerveillesDuMonde(string tri = "")
        {
            string retour = "";
            switch (tri)
            {
                case "0":
                    HttpContext.Session.SetString("NameMerveilleOrder", HttpContext.Session.GetString("NameMerveilleOrder") == "NameMerveille" ? "NameMerveilleDesc" : HttpContext.Session.GetString("NameMerveilleOrder") == "NameMerveilleDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameMerveilleOrder")) ? "NameMerveille" : "");
                    retour = HttpContext.Session.GetString("NameMerveilleOrder");
                    HttpContext.Session.SetString("EreMerveilleOrder", "");
                    HttpContext.Session.SetString("PrerequisMerveilleOrder", "");
                    HttpContext.Session.SetString("EffetMerveilleOrder", "");
                    break;
                case "1":
                    HttpContext.Session.SetString("EreMerveilleOrder", HttpContext.Session.GetString("EreMerveilleOrder") == "EreMerveille" ? "EreMerveilleDesc" : HttpContext.Session.GetString("EreMerveilleOrder") == "EreMerveilleDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("EreMerveilleOrder")) ? "EreMerveille" : "");
                    retour = HttpContext.Session.GetString("EreMerveilleOrder");
                    HttpContext.Session.SetString("NameMerveilleOrder", "");
                    HttpContext.Session.SetString("PrerequisMerveilleOrder", "");
                    HttpContext.Session.SetString("EffetMerveilleOrder", "");
                    break;
                case "2":
                    HttpContext.Session.SetString("PrerequisMerveilleOrder", HttpContext.Session.GetString("PrerequisMerveilleOrder") == "PrerequisMerveille" ? "PrerequisMerveilleDesc" : HttpContext.Session.GetString("PrerequisMerveilleOrder") == "PrerequisMerveilleDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("PrerequisMerveilleOrder")) ? "PrerequisMerveille" : "");
                    retour = HttpContext.Session.GetString("PrerequisMerveilleOrder");
                    HttpContext.Session.SetString("NameMerveilleOrder", "");
                    HttpContext.Session.SetString("EreMerveilleOrder", "");
                    HttpContext.Session.SetString("EffetMerveilleOrder", "");
                    break;
                case "3":
                    HttpContext.Session.SetString("EffetMerveilleOrder", HttpContext.Session.GetString("EffetMerveilleOrder") == "EffetMerveille" ? "EffetMerveilleDesc" : HttpContext.Session.GetString("EffetMerveilleOrder") == "EffetMerveilleDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("EffetMerveilleOrder")) ? "EffetMerveille" : "");
                    retour = HttpContext.Session.GetString("EffetMerveilleOrder");
                    HttpContext.Session.SetString("NameMerveilleOrder", "");
                    HttpContext.Session.SetString("EreMerveilleOrder", "");
                    HttpContext.Session.SetString("PrerequisMerveilleOrder", "");
                    break;
            }

            return retour;
        }

        public string TriCitesEtats(string tri = "")
        {
            string retour = "";
            switch (tri)
            {
                case "0":
                    HttpContext.Session.SetString("NameCiteEtatOrder", HttpContext.Session.GetString("NameCiteEtatOrder") == "NameCiteEtat" ? "NameCiteEtatDesc" : HttpContext.Session.GetString("NameCiteEtatOrder") == "NameCiteEtatDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("NameCiteEtatOrder")) ? "NameCiteEtat" : "");
                    retour = HttpContext.Session.GetString("NameCiteEtatOrder");
                    HttpContext.Session.SetString("TypeCiteEtatOrder", "");
                    HttpContext.Session.SetString("BonusCiteEtatOrder", "");
                    HttpContext.Session.SetString("AmenagementCiteEtatOrder", "");
                    HttpContext.Session.SetString("UniteCiteEtatOrder", "");
                    break;
                case "1":
                    HttpContext.Session.SetString("TypeCiteEtatOrder", HttpContext.Session.GetString("TypeCiteEtatOrder") == "TypeCiteEtat" ? "TypeCiteEtatDesc" : HttpContext.Session.GetString("TypeCiteEtatOrder") == "TypeCiteEtatDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("TypeCiteEtatOrder")) ? "TypeCiteEtat" : "");
                    retour = HttpContext.Session.GetString("TypeCiteEtatOrder");
                    HttpContext.Session.SetString("NameCiteEtatOrder", "");
                    HttpContext.Session.SetString("BonusCiteEtatOrder", "");
                    HttpContext.Session.SetString("AmenagementCiteEtatOrder", "");
                    HttpContext.Session.SetString("UniteCiteEtatOrder", "");
                    break;
                case "2":
                    HttpContext.Session.SetString("BonusCiteEtatOrder", HttpContext.Session.GetString("BonusCiteEtatOrder") == "BonusCiteEtat" ? "BonusCiteEtatDesc" : HttpContext.Session.GetString("BonusCiteEtatOrder") == "BonusCiteEtatDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("BonusCiteEtatOrder")) ? "BonusCiteEtat" : "");
                    retour = HttpContext.Session.GetString("BonusCiteEtatOrder");
                    HttpContext.Session.SetString("NameCiteEtatOrder", "");
                    HttpContext.Session.SetString("TypeCiteEtatOrder", "");
                    HttpContext.Session.SetString("AmenagementCiteEtatOrder", "");
                    HttpContext.Session.SetString("UniteCiteEtatOrder", "");
                    break;
                case "3":
                    HttpContext.Session.SetString("AmenagementCiteEtatOrder", HttpContext.Session.GetString("AmenagementCiteEtatOrder") == "AmenagementCiteEtat" ? "AmenagementCiteEtatDesc" : HttpContext.Session.GetString("AmenagementCiteEtatOrder") == "AmenagementCiteEtatDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("AmenagementCiteEtatOrder")) ? "AmenagementCiteEtat" : "");
                    retour = HttpContext.Session.GetString("AmenagementCiteEtatOrder");
                    HttpContext.Session.SetString("NameCiteEtatOrder", "");
                    HttpContext.Session.SetString("TypeCiteEtatOrder", "");
                    HttpContext.Session.SetString("BonusCiteEtatOrder", "");
                    HttpContext.Session.SetString("UniteCiteEtatOrder", "");
                    break;
                case "4":
                    HttpContext.Session.SetString("UniteCiteEtatOrder", HttpContext.Session.GetString("UniteCiteEtatOrder") == "UniteCiteEtat" ? "UniteCiteEtatDesc" : HttpContext.Session.GetString("UniteCiteEtatOrder") == "UniteCiteEtatDesc" ? "" : String.IsNullOrEmpty(HttpContext.Session.GetString("UniteCiteEtatOrder")) ? "UniteCiteEtat" : "");
                    retour = HttpContext.Session.GetString("UniteCiteEtatOrder");
                    HttpContext.Session.SetString("NameCiteEtatOrder", "");
                    HttpContext.Session.SetString("TypeCiteEtatOrder", "");
                    HttpContext.Session.SetString("BonusCiteEtatOrder", "");
                    HttpContext.Session.SetString("AmenagementCiteEtatOrder", "");
                    break;
            }

            return retour;
        }

        public IActionResult Conversion()
        {
            return View();
        }

        //Appel aux méthodes de conversion
        public IActionResult ConversionDonnees(string Donnees, string TypeConversion)
        {
            switch (TypeConversion)
            {
                case "xml":
                    _civPediaModel.conversionEnXML(Donnees);
                    break;
                case "json":
                    _civPediaModel.conversionEnJson(Donnees);
                    break;
            }
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
