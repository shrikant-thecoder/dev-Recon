using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Models
{
    public class ReInsuranceClaim
    {
        public string ClaimNo { get; set; }
        public string CompClaimNo { get; set; }
        public string PolicyNo { get; set; }
        public DateTime PolicyEffDt { get; set; }
        public double CoverageCd { get; set; }
        public double TreatyNm { get; set; }
        public DateTime TreatyEffDt { get; set; }
        public DateTime TreatyExpDt { get; set; }
        public double PaidLossAmt { get; set; }
        public double LossReserveAmt { get; set; }
        public double AcctPeriod { get; set; }
    }
}
