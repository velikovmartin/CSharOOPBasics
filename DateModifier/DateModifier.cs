using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;

        public static double DateModifierMethod(DateTime firstDate, DateTime secondDate)
        {
            return Math.Abs((secondDate - firstDate).TotalDays);
        }

        //public DateTime FirstDate
        //{
        //    get { return this.firstDate; }
        //    set { firstDate = value; }
        //}

        //public DateTime SecondDate
        //{
        //    get { return this.secondDate; }
        //    set { secondDate = value; }
        //}
    }
}
