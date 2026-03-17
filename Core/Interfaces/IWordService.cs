using Core.Enums;
using Core.Models;

namespace Core.Interfaces
{
    public interface IWordService
    {
        public IEnumerable<Word> GetWords(WordType? type, string search);

    }
}
