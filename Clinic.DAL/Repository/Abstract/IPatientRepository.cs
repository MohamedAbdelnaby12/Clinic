﻿using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepository;

namespace Clinic.DAL.Repository.Abstract
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        Task<List<Patient>> GetPatientsByNameAsync(string Name);
    }
}
