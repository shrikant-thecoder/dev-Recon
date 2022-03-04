using ReconUtility_Core.Recon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon.Repository
{
    public interface IBillingRepository
    {
        List<Billing> Get();
        void Update(List<Billing> entity);
    }
}
