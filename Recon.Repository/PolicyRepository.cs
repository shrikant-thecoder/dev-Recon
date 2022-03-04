using Recon.Repository.Infrastructure;
using ReconUtility_Core.Recon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        ReconDB _reconDB;
        public PolicyRepository(ReconDB reconDB)
        {
            _reconDB = reconDB;
        }
        public List<Policy> Get()
        {
           return _reconDB.Policies.ToList();
        }

        public void Update(List<Policy> policies)
        {
            try
            {
                _reconDB.Policies.UpdateRange(policies);
                _reconDB.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
