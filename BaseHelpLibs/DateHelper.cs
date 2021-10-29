using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHelpLibs
{
    public class DateHelper
    {
        private static readonly string defultSplitSymbol = "-";

        /// <summary>取得當月的最後一天
        /// </summary>
        /// <param name="year">年度</param>
        /// <param name="month">月份</param>
        /// <param name="day">日期</param>
        /// <returns>string</returns>
        public static string GetLastDayFormat(int year, int month, string day)
        {
            var Last = string.Format("{0}{3}{1}{3}{2}", year, month, "01", defultSplitSymbol);
            DateTime last = new DateTime(DateTime.Parse(Last).Year, DateTime.Parse(Last).AddMonths(1).Month, 1).AddDays(-1);
            return string.Format("{0}{3}{1}{3}{2}", year, month.ToString("00"), (month == 12 ? "31" : last.Day.ToString()), defultSplitSymbol);
        }
    }
}
