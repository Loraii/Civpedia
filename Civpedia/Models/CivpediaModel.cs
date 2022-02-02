using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Xml.Linq;

namespace Civpedia.Models
{
    public class CivpediaModel
    {
        private List<Dirigeants> lesCivilisations = ListCivilisationData.ListDirigeants;
        private JObject lesCitesEtats = JObject.Parse(File.ReadAllText($@"{Directory.GetCurrentDirectory()}/Models/Json/citystates.json"));
        private XElement lesMerveillesNaturelles = XElement.Load($@"{Directory.GetCurrentDirectory()}/Models/XML/merveillesnaturelles.xml");
        private XElement lesMerveillesDuMondes = XElement.Load($@"{Directory.GetCurrentDirectory()}/Models/XML/merveilles.xml");

        public CivpediaModel()
        {
        }

        public List<Dirigeants> getCivilisations(string RechercheNomDirigeant, string RechercheTitrePassifDirigeant, string RecherchePassifDirigeant, string RechercheNomEmpire, string RechercheTitrePassifEmpire, string RecherchePassifEmpire, string RechercheNomQuartierEmpire, string RechercheQuartierEmpire, string RechercheNomBatimentEmpire, string RechercheBatimentEmpire, string RechercheNomAmenagementEmpire, string RechercheAmenagementEmpire, TriEntity unTri, string continent)
        {

            List<Dirigeants> lesDirigeants = lesCivilisations.AsQueryable().Where(x => x.NomDirigeant.Contains(RechercheNomDirigeant, StringComparison.CurrentCultureIgnoreCase)).OrderBy("NomDirigeant , NomBatimentEmpire desc" ).Select(x => x).ToList();

            List<Dirigeants> lesDirigeants2 = lesCivilisations.Select(x =>x).ToList();

            switch(continent)
            {
                case "europe":
                    lesDirigeants2 = lesDirigeants2.Where(x => x.NomEmpire == ListContinent.ListEurope.Find(w => w.Contains(x.NomEmpire))).Select(x => x).ToList();
                    break;
                case "amerique":
                    lesDirigeants2 = lesDirigeants2.Where(x => x.NomEmpire == ListContinent.ListAmerique.Find(w => w.Contains(x.NomEmpire))).Select(x => x).ToList();
                    break;
                case "asie":
                    lesDirigeants2 = lesDirigeants2.Where(x => x.NomEmpire == ListContinent.ListAsie.Find(w => w.Contains(x.NomEmpire))).Select(x => x).ToList();
                    break;
                case "afrique":
                    lesDirigeants2 = lesDirigeants2.Where(x => x.NomEmpire == ListContinent.ListAfrique.Find(w => w.Contains(x.NomEmpire))).Select(x => x).ToList();
                    break;
            }

            

            if (!String.IsNullOrEmpty(RechercheNomDirigeant))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.NomDirigeant.Contains(RechercheNomDirigeant, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercheTitrePassifDirigeant))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.TitrePassifDirigeant.Contains(RechercheTitrePassifDirigeant, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RecherchePassifDirigeant))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.PassifDirigeant.Contains(RecherchePassifDirigeant, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercheNomEmpire))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.NomEmpire.Contains(RechercheNomEmpire, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercheTitrePassifEmpire))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.TitrePassifEmpire.Contains(RechercheTitrePassifEmpire, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RecherchePassifEmpire))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.PassifEmpire.Contains(RecherchePassifEmpire, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercheNomQuartierEmpire))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.NomQuartierEmpire.Contains(RechercheNomQuartierEmpire, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercheQuartierEmpire))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.QuartierEmpire.Contains(RechercheQuartierEmpire, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercheNomBatimentEmpire))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.NomBatimentEmpire.Contains(RechercheNomBatimentEmpire, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercheBatimentEmpire))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.BatimentEmpire.Contains(RechercheBatimentEmpire, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercheNomAmenagementEmpire))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.NomAmenagementEmpire.Contains(RechercheNomAmenagementEmpire, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercheAmenagementEmpire))
            {
                lesDirigeants2 = lesDirigeants2.Where(x => x.AmenagementEmpire.Contains(RechercheAmenagementEmpire, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }

            string order = returnOrder(unTri);

            
            if (!String.IsNullOrEmpty(order))
            {
                 lesDirigeants2 = lesDirigeants2.AsQueryable().OrderBy(order).Select(x => x).ToList();
            }
            foreach (Dirigeants unDirigeant in lesDirigeants)
            {
                Console.WriteLine(unDirigeant.NomDirigeant);
            }

            foreach (Dirigeants unDirigeant in lesDirigeants2)
            {
                Console.WriteLine(unDirigeant.NomDirigeant);
            }
            //List<Dirigeants> lesDirigeants = lesCivilisations.Where(x => x.NomDirigeant.Contains(champRecherche, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            return lesDirigeants2;
        }

        public UniteEmpire getUnite(int idCivilisation, int idUnite)
        {
            List<List<UniteEmpire>> liste = lesCivilisations.Where(x => x.Id == idCivilisation).Select(x => x.UnitesEmpire).ToList();
            //liste.ForEach(x => x.Where(y => y.Id) == idUnite).Select(y => y));
            List<UniteEmpire> uneListe = liste[0].Where(x => x.Id == idUnite).Select(x => x).ToList();
            return uneListe[0];
        
        }

        public List<XElement> getMerveillesNaturelles(string RechercheNomMerveille, string RechercherEffetMerveille, string triAFaire, string TailleMerveille)
        {

            var listeMerveillesNaturelles = lesMerveillesNaturelles.Descendants("merveille").Select(x => x).ToList();

            if (!String.IsNullOrEmpty(RechercheNomMerveille))
            {
                listeMerveillesNaturelles = listeMerveillesNaturelles.Where(x => x.Element("nom").Value.Contains(RechercheNomMerveille, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }
            if (!String.IsNullOrEmpty(RechercherEffetMerveille))
            {
                listeMerveillesNaturelles = listeMerveillesNaturelles.Where(x => x.Element("effet").Value.Contains(RechercherEffetMerveille, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            }

            switch (TailleMerveille)
            {
                case "-1":
                    listeMerveillesNaturelles = listeMerveillesNaturelles.Where(x => Convert.ToInt32(x.Element("nbCases").Value) == -1).Select(x => x).ToList();
                    break;
                case "1":
                    listeMerveillesNaturelles = listeMerveillesNaturelles.Where(x => Convert.ToInt32(x.Element("nbCases").Value) == 1).Select(x => x).ToList();
                    break;
                case "2":
                    listeMerveillesNaturelles = listeMerveillesNaturelles.Where(x => Convert.ToInt32(x.Element("nbCases").Value) == 2).Select(x => x).ToList();
                    break;
                case "3":
                    listeMerveillesNaturelles = listeMerveillesNaturelles.Where(x => Convert.ToInt32(x.Element("nbCases").Value) == 3).Select(x => x).ToList();
                    break;
                case "4":
                    listeMerveillesNaturelles = listeMerveillesNaturelles.Where(x => Convert.ToInt32(x.Element("nbCases").Value) == 4).Select(x => x).ToList();
                    break;
                case "2-":
                    listeMerveillesNaturelles = listeMerveillesNaturelles.Where(x => Convert.ToInt32(x.Element("nbCases").Value) <= 2 && Convert.ToInt32(x.Element("nbCases").Value) >= 0).Select(x => x).ToList();
                    break;
                case "2+":
                    listeMerveillesNaturelles = listeMerveillesNaturelles.Where(x => Convert.ToInt32(x.Element("nbCases").Value) > 2).Select(x => x).ToList();
                    break;
            }
            if (triAFaire == "NameMerveille")
            {
                listeMerveillesNaturelles = listeMerveillesNaturelles.OrderBy(x => x.Element("nom").Value).Select(x => x).ToList();
            }
            else if (triAFaire == "NameMerveilleDesc")
            {
                listeMerveillesNaturelles = listeMerveillesNaturelles.OrderByDescending(x => x.Element("nom").Value).Select(x => x).ToList();
            }
            else if (triAFaire == "EffetMerveille")
            {
                listeMerveillesNaturelles = listeMerveillesNaturelles.OrderBy(x => x.Element("effet").Value).Select(x => x).ToList();
            }
            else if (triAFaire == "EffetMerveilleDesc")
            {
                listeMerveillesNaturelles = listeMerveillesNaturelles.OrderByDescending(x => x.Element("effet").Value).Select(x => x).ToList();
            }

            /*foreach (Dirigeants unDirigeant in lesDirigeants2)
            {
                Console.WriteLine(unDirigeant.NomDirigeant);
            }*/
            //List<Dirigeants> lesDirigeants = lesCivilisations.Where(x => x.NomDirigeant.Contains(champRecherche, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
            return listeMerveillesNaturelles;
        }
        public void conversionEnListe(string Donnees)
        {
            switch (Donnees)
            {
                case "civilisations":
                    List<Dirigeants> lesDirigeants = lesCivilisations.Select(x => x).ToList();
                    foreach(var unDirigeant in lesDirigeants)
                    {
                        Console.WriteLine(unDirigeant.NomDirigeant);
                    }
                    break;
                case "citesEtats":
                    var listCitesEtats = lesCitesEtats["Cités-états"].Select(x => x).ToList();
                    foreach (var uneCiteEtat in listCitesEtats)
                    {
                        Console.WriteLine(uneCiteEtat["name"]);
                    }
                    break;
                case "merveillesNaturelles":
                    var listMerveillesNaturelles = lesMerveillesNaturelles.Descendants("merveille").Select(x => x).ToList();
                    foreach (var uneMerveilleNaturelle in listMerveillesNaturelles)
                    {
                        Console.WriteLine(uneMerveilleNaturelle.Element("nom").Value);
                    }
                    break;
                case "merveillesMonde":
                    var listMerveillesMonde = lesMerveillesDuMondes.Descendants("merveille").Select(x => x).ToList();
                    break;
            }


        }
        public void conversionEnXML(string Donnees)
        {
            switch (Donnees)
            {
                case "civilisations":
                    break;
                case "citesEtats":
                    break;
                case "merveillesNaturelles":
                    break;
                case "merveillesMonde":
                    break;
            }

        }
        public void conversionEnJson(string Donnees)
        {
            switch (Donnees)
            {
                case "civilisations":
                    break;
                case "citesEtats":
                    break;
                case "merveillesNaturelles":
                    break;
                case "merveillesMonde":
                    break;
            }


        }

        private string returnOrder(TriEntity unTri)
        {
            List<string> listOrdering = new List<string>();
            if (unTri.NameDirigeantOrder == "NameDirigeant")
            {
                listOrdering.Add("NomDirigeant");
            }
            else if (unTri.NameDirigeantOrder == "NameDirigeantDesc")
            {
                listOrdering.Add("NomDirigeant desc");
            }

            if (unTri.TitlePassifDirigeantOrder == "TitlePassifDirigeant")
            {
                listOrdering.Add("TitrePassifDirigeant");
            }
            else if (unTri.TitlePassifDirigeantOrder == "TitlePassifDirigeantDesc")
            {
                listOrdering.Add("TitrePassifDirigeant desc");
            }

            if (unTri.PassifDirigeantOrder == "PassifDirigeant")
            {
                listOrdering.Add("PassifDirigeant");
            }
            else if (unTri.PassifDirigeantOrder == "PassifDirigeantDesc")
            {
                listOrdering.Add("PassifDirigeant desc");
            }

            if (unTri.NameEmpireOrder == "NameEmpire")
            {
                listOrdering.Add("NomEmpire");
            }
            else if (unTri.NameEmpireOrder == "NameEmpireDesc")
            {
                listOrdering.Add("NomEmpire desc");
            }

            if (unTri.TitlePassifEmpireOrder == "TitlePassifEmpire")
            {
                listOrdering.Add("TitrePassifEmpire");
            }
            else if (unTri.TitlePassifEmpireOrder == "TitlePassifEmpireDesc")
            {
                listOrdering.Add("TitrePassifEmpire desc");
            }

            if (unTri.PassifEmpireOrder == "PassifEmpire")
            {
                listOrdering.Add("PassifEmpire");
            }
            else if (unTri.PassifEmpireOrder == "PassifEmpireDesc")
            {
                listOrdering.Add("PassifEmpire desc");
            }

            if (unTri.NameQuartierOrder == "NameQuartier")
            {
                listOrdering.Add("NomQuartierEmpire");
            }
            else if (unTri.NameQuartierOrder == "NameQuartierDesc")
            {
                listOrdering.Add("NomQuartierEmpire desc");
            }

            if (unTri.QuartierOrder == "Quartier")
            {
                listOrdering.Add("QuartierEmpire");
            }
            else if (unTri.QuartierOrder == "QuartierDesc")
            {
                listOrdering.Add("QuartierEmpire desc");
            }

            if (unTri.NameBatimentOrder == "NameBatiment")
            {
                listOrdering.Add("NomBatimentEmpire");
            }
            else if (unTri.NameBatimentOrder == "NameBatimentDesc")
            {
                listOrdering.Add("NomBatimentEmpire desc");
            }

            if (unTri.BatimentOrder == "Batiment")
            {
                listOrdering.Add("BatimentEmpire");
            }
            else if (unTri.BatimentOrder == "BatimentDesc")
            {
                listOrdering.Add("BatimentEmpire desc");
            }

            if (unTri.NameAmenagementOrder == "NameAmenagement")
            {
                listOrdering.Add("NomAmenagementEmpire");
            }
            else if (unTri.NameAmenagementOrder == "NameAmenagementDesc")
            {
                listOrdering.Add("NomAmenagementEmpire desc");
            }

            if (unTri.AmenagementOrder == "Amenagement")
            {
                listOrdering.Add("AmenagementEmpire");
            }
            else if (unTri.AmenagementOrder == "AmenagementDesc")
            {
                listOrdering.Add("AmenagementEmpire desc");
            }

            return string.Join(',', listOrdering);
        }

      
    }
}
