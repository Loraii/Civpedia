using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Civpedia.Models
{
    public class TriEntity
    {
        public string NameDirigeantOrder;
        public string TitlePassifDirigeantOrder;
        public string PassifDirigeantOrder;
        public string NameEmpireOrder;
        public string TitlePassifEmpireOrder;
        public string PassifEmpireOrder;
        public string NameQuartierOrder;
        public string QuartierOrder;
        public string NameBatimentOrder;
        public string BatimentOrder;
        public string NameAmenagementOrder;
        public string AmenagementOrder;

        public TriEntity(string NameDirigeantOrder_, string TitlePassifDirigeantOrder_, string PassifDirigeantOrder_, string NameEmpireOrder_, string TitlePassifEmpireOrder_, string PassifEmpireOrder_, string NameQuartierOrder_,string QuartierOrder_, string NameBatimentOrder_, string BatimentOrder_, string NameAmenagementOrder_, string AmenagementOrder_)
        {
            NameDirigeantOrder = NameDirigeantOrder_;
            TitlePassifDirigeantOrder = TitlePassifDirigeantOrder_;
            PassifDirigeantOrder = PassifDirigeantOrder_;
            NameEmpireOrder = NameEmpireOrder_;
            TitlePassifEmpireOrder = TitlePassifEmpireOrder_;
            PassifEmpireOrder = PassifEmpireOrder_;
            NameQuartierOrder = NameQuartierOrder_;
            QuartierOrder = QuartierOrder_;
            NameBatimentOrder = NameBatimentOrder_;
            BatimentOrder = BatimentOrder_;
            NameAmenagementOrder = NameAmenagementOrder_;
            AmenagementOrder = AmenagementOrder_;
        }
        public TriEntity()
        {

        }
    }
}
