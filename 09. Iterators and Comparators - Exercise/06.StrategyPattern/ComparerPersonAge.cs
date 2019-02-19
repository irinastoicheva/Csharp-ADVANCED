using System.Collections;
using System.Collections.Generic;

namespace _06.StrategyPattern
{
    public class ComparerPersonAge : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            return first.Age - second.Age;
        }
    }
}
