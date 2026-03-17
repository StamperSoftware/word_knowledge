using Core.Enums;
using Core.Interfaces;
using Core.Models;

namespace Infrastructure.Services
{
    public class WordService : IWordService
    {
        public IEnumerable<Word> GetWords(WordType? type, string search)
        {
            return Words
                .Where(w => w.Name.Contains(search))
                .Where(w => type is null || w.Type == type);
        }

        private readonly IEnumerable<Word> Words =
        [
            new("triumvirate", "a government of three officers or magistrates functioning jointly", WordType.Hard),
            new("aberration", "a deviation from the norm", WordType.Hard),
            new("benevolent", "kind-hearted", WordType.Hard),
            new("cacophony", "harsh noise", WordType.Hard),
            new("debilitate", "to weaken", WordType.Hard),
            new("ephemeral", "lasting a short time", WordType.Hard),
            new("fastidious", "very attentive to detail", WordType.Hard),
            new("achieve", "to accomplish a goal", WordType.Medium),
            new("benefit", "an advantage", WordType.Medium),
            new("challenge", "a difficult task", WordType.Medium),
            new("effort", "hard work", WordType.Medium),
            new("generous", "willing to give", WordType.Medium),
            new("important", "significant", WordType.Medium),
            new("valuable", "worth a lot", WordType.Medium),
            new("enemy", "a person who opposes", WordType.Easy),
            new("hot", "high temperature", WordType.Easy),
            new("cold", "low temperature", WordType.Easy),
            new("light", "low weight", WordType.Easy),
            new("heavy", "high weight", WordType.Easy),
            new("new", "recently made", WordType.Easy),
            new("give", "to hand over", WordType.Easy),
        ];
    }
}
