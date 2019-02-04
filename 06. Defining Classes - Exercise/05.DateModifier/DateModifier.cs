namespace _05.DateModifier
{
    using System;
    using System.Collections.Generic;

    public class DateModifier
    {
        private DateTime startData;
        private DateTime endData;

        public DateModifier(DateTime start, DateTime end)
        {
            this.StartData = start;
            this.EndData = end;
        }
        public DateTime StartData
        {
            get { return this.startData; }
            set { this.startData = value; }
        }

        public DateTime EndData
        {
            get { return this.endData; }
            set { this.endData = value; }
        }

        public double GetDifference()
        {
            return Math.Abs((EndData - StartData).TotalDays);
        }
    }
}
