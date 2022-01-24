using Fact_introduction.Interfaces;

namespace Fact_introduction
{
    public class BoolFact : IFact
    {
        public string Name { get; set; }

        public object Value { get; set; }

        public int Level { get; set; }
        public string Question { get; set; }

        public void SetLevel(int level)
        {
            Level = level;
        }

        public BoolFact(string name, bool value, string question, int level = 0)
        {
            Name = name;
            Value = value;
            Question = question;
            Level = level;
        }

        public override string ToString()
        {
            string res = string.Empty;
            if (!Convert.ToBoolean(Value))
            {
                res += "!";
            }
            res += Name + " (" + Level + ")";
            return res;
        }
    }
}
