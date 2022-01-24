namespace Fact_introduction.Interfaces
{
    public interface IFact
    {
        string Name { get; set; }
        object Value { get; set; }
        int Level { get; set; }
        string Question { get; set; }

        void SetLevel(int level);
    }
}
