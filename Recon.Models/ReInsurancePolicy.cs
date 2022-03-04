using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Models
{
    public class ReInsurancePolicy
    {
        [Key]
        public string PolicyNo { get; set; }
        public DateTime PolicyEffDt { get; set; }
        public string MasterPolicyNo { get; set; }
        public double CoverageCd { get; set; }
        public double ReinsCd { get; set; }
        public double ReinsNm { get; set; }
        public double TreatyNm { get; set; }
        public DateTime TreatyEffDt { get; set; }
        public DateTime TreatyExpDt { get; set; }
        public double PremiumAmt { get; set; }
        public double AcctPeriod { get; set; }
    }
}
