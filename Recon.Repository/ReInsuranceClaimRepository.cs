using Recon.Repository.Infrastructure;
using ReconUtility_Core.Recon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Repository
{
    public class ReInsuranceClaimRepository : IReInsuranceClaimRepository
    {
        ReconDB _reconDB;
        public ReInsuranceClaimRepository(ReconDB reconDB)
        {
            _reconDB = reconDB;
        }
        public List<ReInsuranceClaim> Get()
        {
            try
            {
                return _reconDB.ReInsuranceClaims.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(List<ReInsuranceClaim> reInsuranceClaims)
        {
            try
            {
                _reconDB.ReInsuranceClaims.UpdateRange(reInsuranceClaims);
                _reconDB.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
