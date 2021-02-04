using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CompetitionMeritLists_WebAPI.Models;

namespace CompetitionMeritLists_WebAPI.Data
{
    public class CompetitionMeritLists_WebAPIContext : DbContext
    {
        public CompetitionMeritLists_WebAPIContext (DbContextOptions<CompetitionMeritLists_WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CompetitionMeritLists_WebAPI.Models.Students> Students { get; set; }
    }
}
