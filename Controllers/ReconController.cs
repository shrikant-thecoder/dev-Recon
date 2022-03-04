using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Recon.Repository;
using ReconUtility_Core.Recon.Models;
using ReconUtility_Core.Recon.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReconUtility_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReconController : ControllerBase
    {
        IBillingRepository _billingrepository;
        IPolicyRepository _policyRepository;
        IReInsurancePolicyRepository _reInsurancePolicyRepository;
        IReInsuranceClaimRepository _reInsuranceClaimRepository;
        IClaimRepository _claimRepository;
        public ReconController(IBillingRepository repository, IPolicyRepository policyRepository,IReInsurancePolicyRepository reInsurancePolicyRepository,IReInsuranceClaimRepository reInsuranceClaimRepository,IClaimRepository claimRepository)
        {
            _billingrepository = repository;
            _policyRepository = policyRepository;
            _reInsurancePolicyRepository = reInsurancePolicyRepository;
            _reInsuranceClaimRepository = reInsuranceClaimRepository;
            _claimRepository = claimRepository;
        }
        // GET: api/<ReconController>
        [HttpGet]
        public IActionResult Get(string domain)
        {
            switch (domain.ToLower())
            {
                case "billing":
                    return Ok(_billingrepository.Get());
                case "policy":
                    return Ok(_policyRepository.Get());
                case "reinsurancepolicy":
                    return Ok(_reInsurancePolicyRepository.Get());
                case "reinsuranceclaim":
                    return Ok(_reInsuranceClaimRepository.Get());
                case "claims":
                    return Ok(_claimRepository.Get());
            }
            return NotFound("Domain not found");
        }

        // PUT api/<ReconController>/5
        [HttpPut]
        public IActionResult Put(string domain, object obj)
        {
            switch (domain.ToLower())
            {
                case "billing":
                    var billings = JsonConvert.DeserializeObject<List<Billing>>(obj.ToString());
                    _billingrepository.Update(billings);
                    return Ok("Record Updated Successfully");
                case "policy":
                    var policies= JsonConvert.DeserializeObject<List<Policy>>(obj.ToString());
                    _policyRepository.Update(policies);
                    return Ok("Record Updated Successfully");
                case "reinsurancepolicy":
                    var reInsurancepolicies = JsonConvert.DeserializeObject<List<ReInsurancePolicy>>(obj.ToString());
                    _reInsurancePolicyRepository.Update(reInsurancepolicies);
                    return Ok("Record Updated Successfully");
                case "reinsuranceclaim":
                    var reInsuranceClaims = JsonConvert.DeserializeObject<List<ReInsuranceClaim>>(obj.ToString());
                    _reInsuranceClaimRepository.Update(reInsuranceClaims);
                    return Ok("Record Updated Successfully");
                case "claims":
                    var claims = JsonConvert.DeserializeObject<List<Claims>>(obj.ToString());
                    _claimRepository.Update(claims);
                    return Ok("Record Updated Successfully");
            }
            return NotFound("Domain Not Found");
        }

        // DELETE api/<ReconController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
