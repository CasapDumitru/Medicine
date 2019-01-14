﻿using HealthInsurance.Core.Models;
using System.Collections.Generic;

namespace HealthInsurance.Core.Interfaces.Services
{
    public interface IOfficeService
    {
        IList<Office> GetAll();
    }
}
