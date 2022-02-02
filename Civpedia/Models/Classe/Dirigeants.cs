using System.Collections.Generic;

namespace Civpedia.Models
{
    public class Dirigeants
    {
        public int Id { get; set; }
        public string NomDirigeant { get; set; }
        public string TitrePassifDirigeant { get; set; }
        public string PassifDirigeant { get; set; }
        public string NomEmpire { get; set; }
        public string TitrePassifEmpire { get; set; }
        public string PassifEmpire { get; set; }
        public List<UniteEmpire> UnitesEmpire { get; set; }
        public string NomQuartierEmpire { get; set; }
        public string QuartierEmpire { get; set; }
        public string NomBatimentEmpire { get; set; }
        public string BatimentEmpire { get; set; }
        public string NomAmenagementEmpire { get; set; }
        public string AmenagementEmpire { get; set; }

        public Dirigeants()
        {

        }
    }
}
