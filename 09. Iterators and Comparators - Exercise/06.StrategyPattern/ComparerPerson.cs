namespace _06.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class ComparerPersonName : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int result = first.Name.Length - second.Name.Length;
            if (result == 0)
            {
                result = first.Name.ToLower()[0].CompareTo(second.Name.ToLower()[0]);
            }

            return result;
        }
    }
}
