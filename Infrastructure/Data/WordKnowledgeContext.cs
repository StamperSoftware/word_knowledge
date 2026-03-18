using Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class WordKnowledgeContext(DbContextOptions<WordKnowledgeContext> options)
        :IdentityDbContext<AppUser>(options)
    {
        public DbSet<Word> Words { get; set; }
        public new DbSet<AppUser> Users { get; set; }
    }
}
