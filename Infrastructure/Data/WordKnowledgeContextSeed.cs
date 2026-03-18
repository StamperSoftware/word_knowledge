using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Infrastructure.Data
{
    public static class WordKnowledgeContextSeed
    {

        public static async Task SeedAsync(WordKnowledgeContext db, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, string adminEmail, string adminPassword) 
        {
            
            await AddWords(db);
            await CreateAdminRole(roleManager);
            await AddAdminUser(db, userManager, roleManager, adminEmail, adminPassword);
        }


        private static async Task AddWords(WordKnowledgeContext db) 
        {
            if (db.Words.Any()) return;
            var wordsJSON = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/word_bank1.json");
            var words = JsonSerializer.Deserialize<IList<Word>>(wordsJSON);
            if (words is null) return;
            await db.Words.AddRangeAsync(words);
            await db.SaveChangesAsync();
        }

        private static async Task AddAdminUser(WordKnowledgeContext db, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, string adminEmail, string adminPassword) 
        {
            var user = await userManager.FindByEmailAsync(adminEmail);
            if (user != null) return;
            
            user = AppUser.CreateAppUser(adminEmail, "admin", "admin", "admin");
            await userManager.CreateAsync(user, adminPassword);
            await userManager.AddToRoleAsync(user, "admin");
        }

        private async static Task CreateAdminRole(RoleManager<IdentityRole> roleManager) 
        {
            if (await roleManager.RoleExistsAsync("admin")) return;
            await roleManager.CreateAsync(new IdentityRole("admin"));
        }

    }
}
