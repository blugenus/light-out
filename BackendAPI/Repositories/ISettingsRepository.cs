using BackendAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Repositories
{
    public interface ISettingsRepository
    {
        Task<Settings> Get();

    }
}
