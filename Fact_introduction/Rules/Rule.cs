using Fact_introduction.Interfaces;

namespace Fact_introduction.Rules
{
    public class Rule
    {
        public List<IFact> Premises { get; set; }
        public IFact Conclusion { get; set; }
        public string Name { get; set; }

        public Rule(string name, List<IFact> premises, IFact conclusion)
        {
            Name = name;
            Premises = premises;
            Conclusion = conclusion;
        }

        public override string ToString()
        {
            return Name + " : IF (" + string.Join(" AND ", Premises) + ") THEN " + Conclusion.ToString();
        }
    }
}
