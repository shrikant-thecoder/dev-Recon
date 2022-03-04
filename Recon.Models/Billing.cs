using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Models
{
    public class Billing
    {
        [Key]
        public string PolicyNo { get; set; }
        public DateTime TermEffDt { get; set; }
        public string BillingMethod { get; set; }
        public double PremiumAmt { get; set; }
        public double TaxAmount { get; set; }
        public double PolicyFee { get; set; }
        public double SurchargeAmt { get; set; }
        public double FeeAmount { get; set; }
        public double CashReceiptAmt { get; set; }
        public double DisbursementAmt { get; set; }
        public double JournalAmt { get; set; }
        public double CommissionAmt { get; set; }
    }
}
