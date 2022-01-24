using Fact_introduction.Interfaces;
using Fact_introduction.Rules;

namespace Fact_introduction
{
    public class Motor
    {
        private readonly FactBase _factsBase;
        private readonly RulesBase _rulesBase;
        private readonly IHumanInterface _ihm;

        public Motor(IHumanInterface ihm)
        {
            _ihm = ihm;
            _factsBase = new FactBase();
            _rulesBase = new RulesBase();
        }
    }
}
