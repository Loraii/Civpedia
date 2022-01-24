using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Civpedia.Models
{
    public class CivpediaModel
    {
        private List<Dirigeants> lesCivilisations = ListCivilisationData.ListDirigeants;

        public CivpediaModel()
        {
        }

        public List<Dirigeants> getCivilisations(string champRecherche)
        {
            return lesCivilisations.Where(x => x.NomDirigeant.Contains(champRecherche, StringComparison.CurrentCultureIgnoreCase)).Select(x => x).ToList();
        }
    }
}
