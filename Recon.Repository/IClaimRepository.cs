﻿using ReconUtility_Core.Recon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReconUtility_Core.Recon.Repository
{
    public interface IClaimRepository
    {
        List<Claims> Get();
        void Update(List<Claims> entity);
    }
}
