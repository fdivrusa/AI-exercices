using Fact_introduction.Interfaces;

namespace Fact_introduction
{
    internal class IntFact : IFact
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public int Level { get; set; }
        public string Question { get; set; }

        public void SetLevel(int level)
        {
            Level = level;
        }

        public IntFact(string name, int value, string question, int level = 0)
        {
            Name = name;
            Value = value;
            Question = question;
            Level = level;
        }

        public override string ToString()
        {
            return Name + "=" + Value + " (" + Level + ")";
        }
    }
}
