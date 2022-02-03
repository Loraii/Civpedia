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

            return listeMerveillesNaturelles;
        }

        public void addCivilisation(string NomDirigeant, string TitrePassifDirigeant, string PassifDirigeant, string NomEmpire, string TitrePassifEmpire, string PassifEmpire, string NomQuartierEmpire, string QuartierEmpire, string NomBatimentEmpire, string BatimentEmpire, string NomAmenagementEmpire, string AmenagementEmpire, string[] NomUnite, int[] AttaqueUnite, string[] TexteUnite, string[] AmenagementUnite)
        {
            Dirigeants toto = new Dirigeants()
            {
                Id = lesCivilisations.OrderByDescending(x => x.Id).Select(x => x.Id).First() + 1,
                NomDirigeant = NomDirigeant,
                TitrePassifDirigeant = TitrePassifDirigeant,
                PassifDirigeant = PassifDirigeant,
                NomEmpire = NomEmpire,
                TitrePassifEmpire = TitrePassifEmpire,
                PassifEmpire = PassifEmpire,
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite=NomUnite[0],
                        AtkUnite=AttaqueUnite[0],
                        TexteUnite=TexteUnite[0],
                        AmenagementUnite= AmenagementUnite[0]
                    } ,
                    new UniteEmpire() {
                        Id=2,
                        NomUnite=NomUnite[1],
                        AtkUnite=AttaqueUnite[1],
                        TexteUnite=TexteUnite[1],
                        AmenagementUnite= AmenagementUnite[1]
                    }
                },
                NomQuartierEmpire = NomQuartierEmpire,
                QuartierEmpire = QuartierEmpire,
                NomBatimentEmpire = NomBatimentEmpire,
                BatimentEmpire = BatimentEmpire,
                NomAmenagementEmpire = NomAmenagementEmpire,
                AmenagementEmpire = AmenagementEmpire
            };
            lesCivilisations.Add(toto);
        }

        public void addMerveilleNaturelle(string NomMerveille, string Effet, int NbCases)
        {

            
            lesMerveillesNaturelles.Add(new XElement("merveille",
                        new XElement("id", Convert.ToInt32(lesMerveillesNaturelles.Descendants("merveille").OrderByDescending(x => Convert.ToInt32(x.Element("id").Value)).Select(x => x.Element("id").Value).First()) + 1),
                        new XElement("nom", NomMerveille),
                        new XElement("effet", Effet),
                        new XElement("nbCases", NbCases)
                        ));
        }

        public void conversionEnXML(string Donnees)
        {
            switch (Donnees)
            {
                case "civilisations":
                    var newXmlCivilisationFile = new XElement("Civilisations",
                        from civilisation in lesCivilisations
                        select new XElement("Civilisation",
                        new XElement("Id", civilisation.Id),
                        new XElement("NomDirigeant", civilisation.NomDirigeant),
                        new XElement("TitrePassifDirigeant", civilisation.TitrePassifDirigeant),
                        new XElement("PassifDirigeant", civilisation.PassifDirigeant),
                        new XElement("NomEmpire", civilisation.NomEmpire),
                        new XElement("TitrePassifEmpire", civilisation.TitrePassifEmpire),
                        new XElement("PassifEmpire", civilisation.PassifEmpire),
                        new XElement("UnitesEmpire",
                        from uniteEmpire in civilisation.UnitesEmpire
                        select new XElement("UniteEmpire",
                        new XElement("IdUnite", uniteEmpire.Id),
                        new XElement("NomUnite", uniteEmpire.NomUnite),
                        new XElement("AtkUnite", uniteEmpire.AtkUnite),
                        new XElement("TexteUnite", uniteEmpire.TexteUnite),
                        new XElement("AmenagementUnite", uniteEmpire.AmenagementUnite)
                        )),
                        new XElement("NomQuartierEmpire", civilisation.NomQuartierEmpire),
                        new XElement("QuartierEmpire", civilisation.QuartierEmpire),
                        new XElement("NomBatimentEmpire", civilisation.NomBatimentEmpire),
                        new XElement("BatimentEmpire", civilisation.BatimentEmpire),
                        new XElement("NomAmenagementEmpire", civilisation.NomAmenagementEmpire),
                        new XElement("AmenagementEmpire", civilisation.AmenagementEmpire)
                        )
                        );
                    File.WriteAllText($@"{Directory.GetCurrentDirectory()}/Models/XML/civilisations.xml", newXmlCivilisationFile.ToString());
                    break;
                case "citesEtats":
                    var newXmlCitesEtatsFile = new XElement("Cités-états",
                        from citeEtat in lesCitesEtats["Cités-états"]
                        select new XElement("Cité-état",
                        new XElement("Id", citeEtat["id"]),
                        new XElement("Name", citeEtat["name"]),
                        new XElement("Type", citeEtat["type"]),
                        new XElement("Bonus", citeEtat["bonus"]),
                        new XElement("Amenagement", citeEtat["amenagement"]),
                        new XElement("Unite", citeEtat["unité"])
                        )
                        );
                    File.WriteAllText($@"{Directory.GetCurrentDirectory()}/Models/XML/citystates.xml", newXmlCitesEtatsFile.ToString());
                    break;
                case "merveillesNaturelles":
                    var newXmlMerveillesNaturellesFile = new XElement("merveilles-naturelles",
                        from merveillesNaturelles in lesMerveillesNaturelles.Descendants("merveille")
                        select new XElement("merveille",
                        new XElement("id", merveillesNaturelles.Element("id").Value),
                        new XElement("nom", merveillesNaturelles.Element("nom").Value),
                        new XElement("effet", merveillesNaturelles.Element("effet").Value),
                        new XElement("nbCases", merveillesNaturelles.Element("nbCases").Value)
                        )
                        );
                    File.WriteAllText($@"{Directory.GetCurrentDirectory()}/Models/XML/merveillesnaturelles.xml", newXmlMerveillesNaturellesFile.ToString());
                    break;
                case "merveillesMonde":
                    var newXmlMerveillesMondesFile = new XElement("merveilles",
                        from merveillesNaturelles in lesMerveillesNaturelles.Descendants("merveille")
                        select new XElement("merveille",
                        new XElement("id", merveillesNaturelles.Element("id").Value),
                        new XElement("nom", merveillesNaturelles.Element("nom").Value),
                        new XElement("ere", merveillesNaturelles.Element("ere").Value),
                        new XElement("prerequis", merveillesNaturelles.Element("prerequis").Value),
                        new XElement("cout-production", merveillesNaturelles.Element("cout-production").Value),
                        new XElement("effet", merveillesNaturelles.Element("effet").Value)
                        )
                        );
                    File.WriteAllText($@"{Directory.GetCurrentDirectory()}/Models/XML/merveilles.xml", newXmlMerveillesMondesFile.ToString());
                    break;
            }

        }
        public void conversionEnJson(string Donnees)
        {
            switch (Donnees)
            {
                case "civilisations":
                    var myJsonCivilisationFile =
                        new JObject(
                            new JProperty("Civilisations",
                            new JArray(
                                from civilisation in lesCivilisations
                                select new JObject(
                                    new JProperty("id", civilisation.Id),
                                    new JProperty("nomDirigeant", civilisation.NomDirigeant),
                                    new JProperty("titrePassifDirigeant", civilisation.TitrePassifDirigeant),
                                    new JProperty("passifDirigeant", civilisation.PassifDirigeant),
                                    new JProperty("nomEmpire", civilisation.NomEmpire),
                                    new JProperty("titrePassifEmpire", civilisation.TitrePassifEmpire),
                                    new JProperty("passifEmpire", civilisation.PassifEmpire),
                                    new JProperty("unitesEmpire",
                                    new JArray(
                                        from unite in civilisation.UnitesEmpire
                                        select new JObject(
                                            new JProperty("idUnite", unite.Id),
                                            new JProperty("nomUnite", unite.NomUnite),
                                            new JProperty("atkUnite", unite.AtkUnite),
                                            new JProperty("texteUnite", unite.TexteUnite),
                                            new JProperty("amenagementUnite", unite.AmenagementUnite)
                                        ))),
                                        new JProperty("nomQuartierEmpire", civilisation.NomQuartierEmpire),
                                        new JProperty("quartierEmpire", civilisation.QuartierEmpire),
                                        new JProperty("nomBatimentEmpire", civilisation.NomBatimentEmpire),
                                        new JProperty("batimentEmpire", civilisation.BatimentEmpire),
                                        new JProperty("nomAmenagementEmpire", civilisation.NomAmenagementEmpire),
                                        new JProperty("amenagementEmpire", civilisation.AmenagementEmpire)
                                    ))));
                    File.WriteAllText($@"{Directory.GetCurrentDirectory()}/Models/Json/civilisations.json", myJsonCivilisationFile.ToString());
                    break;
                case "citesEtats":
                    var myJsonCitesEtatsFile =
                        new JObject(
                            new JProperty("Cités-Etats",
                            new JArray(
                                from citeEtat in lesCitesEtats["Cités-états"]
                                select new JObject(
                                    new JProperty("id", citeEtat["id"]),
                                    new JProperty("name", citeEtat["name"]),
                                    new JProperty("type", citeEtat["type"]),
                                    new JProperty("bonus", citeEtat["bonus"]),
                                    new JProperty("amenagement", citeEtat["amenagement"]),
                                    new JProperty("unité", citeEtat["unité"])
                                    ))));
                    File.WriteAllText($@"{Directory.GetCurrentDirectory()}/Models/Json/citystates.json", myJsonCitesEtatsFile.ToString());
                    break;
                case "merveillesNaturelles":
                    var myJsonMerveillesNaturellesFile =
                        new JObject(
                            new JProperty("Merveilles-Naturelles",
                            new JArray(
                                from merveille in lesMerveillesNaturelles.Descendants("merveille")
                                select new JObject(
                                    new JProperty("id", merveille.Element("id").Value),
                                    new JProperty("nom", merveille.Element("nom").Value),
                                    new JProperty("effet", merveille.Element("effet").Value),
                                    new JProperty("nbCases", merveille.Element("nbCases").Value)
                                    ))));
                    File.WriteAllText($@"{Directory.GetCurrentDirectory()}/Models/Json/merveillesnaturelles.json", myJsonMerveillesNaturellesFile.ToString());
                    break;
                case "merveillesMonde":
                    var myJsonMerveillesMondeFile =
                        new JObject(
                            new JProperty("Merveilles",
                            new JArray(
                                from merveille in lesMerveillesNaturelles.Descendants("merveille")
                                select new JObject(
                                    new JProperty("id", merveille.Element("id").Value),
                                    new JProperty("nom", merveille.Element("nom").Value),
                                    new JProperty("ere", merveille.Element("ere").Value),
                                    new JProperty("prerequis", merveille.Element("prerequis").Value),
                                    new JProperty("cout-production", merveille.Element("cout-production").Value),
                                    new JProperty("effet", merveille.Element("effet").Value)
                                    ))));
                    File.WriteAllText($@"{Directory.GetCurrentDirectory()}/Models/Json/merveilles.json", myJsonMerveillesMondeFile.ToString());
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
