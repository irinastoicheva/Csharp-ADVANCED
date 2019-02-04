namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class DateModifier
    {
        private DateTime date;
        private List<DateTime> dates = new List<DateTime>();

        public double GetDateModifier()
        {
            DateTime firstDate = this.dates[0];
            DateTime secondDate = this.dates[1];
            double differenceInTheDays = (secondDate - firstDate).TotalDays;
            return differenceInTheDays;
        }
    }
}
