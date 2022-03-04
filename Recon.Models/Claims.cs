using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Models
{
    public class Claims
    {
        [Key]
        public string ClaimNo { get; set; }
        public string LOBDesc { get; set; }
        public double CDLossReserve { get; set; }
        public double CDALAEReserve { get; set; }
        public double CDULAEReserve { get; set; }
        public double CDMedicalReserve { get; set; }
        public double CDVocRehabReserve { get; set; }
        public double CDLossPaid { get; set; }
        public double CDALAEPaid { get; set; }
        public double CDULAEPaid { get; set; }
        public double CDMedicalPaid { get; set; }
        public double CDVocRehabPaid { get; set; }
        public double CDLossRecovery { get; set; }
        public double CDALAERecovery { get; set; }
        public double CDULAERecovery { get; set; }
        public double CDMedicalRecovery { get; set; }
        public double CDVocRehabRecovery { get; set; }
        public double ODSLossReserve { get; set; }
        public double ODSALAEResere { get; set; }
        public double ODSULAEReserve { get; set; }
        public double ODSMedicalReserve { get; set; }
        public double ODSVocRehabReserve { get; set; }
        public double ODSLossRecovery { get; set; }
        public double ODSALAERecovery { get; set; }
        public double ODSULAERecovery { get; set; }
        public double ODSMedicalRecovery { get; set; }
        public double ODSVocRehabRecovery { get; set; }
    }
}
