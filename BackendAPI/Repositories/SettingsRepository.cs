using BackendAPI.Data;
using BackendAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Repositories
{
    public class SettingsRepository : ISettingsRepository
    {
        private readonly ApplicationDbContext _context;
        public SettingsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Settings> Get()
        {
            return  await _context.Settings.FindAsync(1);
        }
    }
}
