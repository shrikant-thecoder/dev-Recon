using Recon.Repository.Infrastructure;
using ReconUtility_Core.Recon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Repository
{
    public class ReInsurancePolicyRepository : IReInsurancePolicyRepository
    {
        ReconDB _reconDB;
        public ReInsurancePolicyRepository(ReconDB reconDB)
        {
            _reconDB = reconDB;
        }
        public List<ReInsurancePolicy> Get()
        {
            try
            {
                return _reconDB.ReInsurancePolicies.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(List<ReInsurancePolicy> reInsurancePolicies)
        {
            try
            {
                _reconDB.ReInsurancePolicies.UpdateRange(reInsurancePolicies);
                _reconDB.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

      
    }
}
