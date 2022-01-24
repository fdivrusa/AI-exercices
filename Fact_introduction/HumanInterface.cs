using Fact_introduction.Interfaces;
using Fact_introduction.Rules;

namespace Fact_introduction
{
    public class HumanInterface : IHumanInterface
    {
        public bool AskBoolValue(string question)
        {
            Console.Out.WriteLine(question + " (yes, no)");
            return Console.In.ReadLine().Equals("yes");
        }

        public int AskIntValue(string question)
        {
            Console.Out.WriteLine(question);
            try
            {
                return int.Parse(Console.In.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                return 0;
            }
        }

        public void PrintFacts(List<IFact> facts)
        {
            string res = "Solution(s) found : \n";
            res += string.Join("\n", facts.Where(x => x.Level > 0).OrderByDescending(x => x.Level));
            Console.Out.WriteLine(res);
        }

        public void PrintRules(List<Rule> rules)
        {
            string res = string.Empty;
            res += string.Join("\n", rules);
            Console.Out.WriteLine(res);
        }
    }
}
