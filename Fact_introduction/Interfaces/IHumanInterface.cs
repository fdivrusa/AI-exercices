
using Fact_introduction.Rules;

namespace Fact_introduction.Interfaces
{
    public interface IHumanInterface
    {
        int AskIntValue(string question);
        bool AskBoolValue(string question);
        void PrintFacts(List<IFact> facts);
        void PrintRules(List<Rule> rules);
    }
}
