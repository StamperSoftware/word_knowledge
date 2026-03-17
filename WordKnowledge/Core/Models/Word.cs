using System.Reflection.Metadata.Ecma335;
using WordKnowledge.Core.Enums;

namespace WordKnowledge.Core.Models
{
    public class Word
    {
        public Word(string name, string definition, WordType type)
        { 
            Name = name;
            Definition = definition;
            Type = type;
        }

        public string Name { get; set; } = "";
        public string Definition { get; set; } = "";
        public WordType Type { get; set; }

        public bool CheckDefinition(string definition) => Definition == definition;
    }
}
