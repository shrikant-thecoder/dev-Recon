using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Models
{
    public class Policy
    {
        [Key]
        public string PolicyNo { get; set; }
        public DateTime PolicyEffDt { get; set; }
        public string MasterPolicyNo { get; set; }
        public string LOBDesc { get; set; }
        public double WrittenPremium { get; set; }
    }
}
