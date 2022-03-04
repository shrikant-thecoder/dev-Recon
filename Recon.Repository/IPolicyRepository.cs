using ReconUtility_Core.Recon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Repository
{
    public interface IPolicyRepository
    {
        List<Policy> Get();
        
        // Marks an entity as modified
        void Update(List<Policy> entity);
    }
}
