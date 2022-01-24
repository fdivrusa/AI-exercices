using Fact_introduction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact_introduction
{
    public class FactBase
    {
        public List<IFact> Facts { get; set; }

        public FactBase()
        {
            Facts = new List<IFact>();
        }

        public void Clear()
        {
            Facts.Clear();
        }

        public void AddFact(IFact fact)
        {
            if (fact == null)
            {
                return;
            }
            Facts.Add(fact);
        }

        public IFact? Search(string name)
        {
            return Facts.FirstOrDefault(predicate: x =>
            {
                return x.Name.ToUpperInvariant() == name.ToUpperInvariant();
            });
        }

        public object? Value(string name)
        {
            return Facts.FirstOrDefault(predicate: x =>
            {
                return x.Name.ToUpperInvariant() == name.ToUpperInvariant();
            })?.Value;
        }
    }
}
