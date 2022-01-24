namespace Fact_introduction.Rules
{
    public class RulesBase
    {
        public List<Rule> Rules { get; set; }

        public RulesBase()
        {
            Rules = new List<Rule>();
        }

        public void ClearBase()
        {
            Rules.Clear();
        }

        public void AddRule(Rule rule)
        {
            if (rule == null)
            {
                return;
            }

            Rules.Add(rule);
        }

        public void Remove(Rule rule)
        {
            Rules.Remove(rule);
        }
    }
}
