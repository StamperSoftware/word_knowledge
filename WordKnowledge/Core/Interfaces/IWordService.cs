using WordKnowledge.Core.Enums;
using WordKnowledge.Core.Models;

namespace WordKnowledge.Core.Interfaces
{
    public interface IWordService
    {
        public IEnumerable<Word> GetWords(WordType? type, string search);

    }
}
