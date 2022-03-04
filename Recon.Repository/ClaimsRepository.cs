using Recon.Repository.Infrastructure;
using ReconUtility_Core.Recon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Repository
{
    public class ClaimsRepository : IClaimRepository
    {
        ReconDB _reconDB;
        public ClaimsRepository(ReconDB reconDB)
        {
            _reconDB = reconDB;
        }
        public List<Claims> Get()
        {
            try
            {
                return _reconDB.claims.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(List<Claims> claims)
        {
            try
            {
                _reconDB.claims.UpdateRange(claims);
                _reconDB.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
