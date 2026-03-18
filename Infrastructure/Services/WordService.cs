using Core.Enums;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class WordService(WordKnowledgeContext db) : IWordService
    {
        public IEnumerable<Word> GetWords(WordType? type, string search)
        {
            IEnumerable<Word> words = db.Words;
            if (type != null) 
            {
                words = words.Where(w => w.Type.Equals(type));
            }
            if (search != "") 
            {
                words = words.Where(w => w.Name.Contains(search));
            }

            return words;
        }
    }
}
