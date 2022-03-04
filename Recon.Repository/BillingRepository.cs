using Microsoft.EntityFrameworkCore;
using ReconUtility_Core.Recon.Models;
using Recon.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon.Repository
{
    public class BillingRepository : IBillingRepository
    {
        private ReconDB _reconDB;
        public BillingRepository(ReconDB reconDB)
        {
            _reconDB = reconDB;
        }

        public List<Billing> Get()
        {
            try
            {
                return _reconDB.Billings.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(List<Billing> billings)
        {
            try
            {
                _reconDB.Billings.UpdateRange(billings);
                _reconDB.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
