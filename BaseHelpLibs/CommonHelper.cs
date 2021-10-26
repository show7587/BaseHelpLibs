using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHelpLibs
{
    public class CommonHelper
    {
        private static readonly string defultSplitSymbol = "-";
        /// <summary> 民國、西元轉換 </summary>
        /// <param name="dateT">時間</param>
        /// <param name="type">(民國:Republic、西元:AD)</param>
        /// <param name="_splitSymbol">分割符號</param>
        /// <param name="_outputSymbol">輸出格式符號</param>
        /// <returns> 年度轉換結果 </returns>
        public static string ChangeYear(string dateT, string type, string _splitSymbol = null, string _outputSymbol = null)
        {
            var splitSymbol = (!string.IsNullOrEmpty(_splitSymbol) ? _splitSymbol : defultSplitSymbol).ToCharArray();
            var outputSymbol = !string.IsNullOrEmpty(_outputSymbol) ? _outputSymbol.ToCharArray() : splitSymbol;
            return PrivateChangeYear(dateT.Split(splitSymbol).ToList(), type, outputSymbol);
        }

        /// <summary> 民國、西元轉換 </summary>
        /// <param name="dateT">時間</param>
        /// <param name="type">(民國:Republic、西元:AD)</param>
        /// <param name="_splitSymbol">分割符號</param>
        /// <returns></returns>
        public static string ChangeYear(string dateT, string type, string _splitSymbol = null)
        {
            var splitSymbol = (!string.IsNullOrEmpty(_splitSymbol) ? _splitSymbol : defultSplitSymbol).ToCharArray();
            return PrivateChangeYear(dateT.Split(splitSymbol).ToList(), type, defultSplitSymbol.ToCharArray());
        }

        /// <summary> 民國、西元轉換 </summary>
        /// <param name="dateT">時間</param>
        /// <param name="type">(民國:Republic、西元:AD)</param>
        /// <returns></returns>
        public static string ChangeYear(string dateT, string type)
        {
            return PrivateChangeYear(dateT.Split(defultSplitSymbol.ToCharArray()[0]).ToList(), type, defultSplitSymbol.ToCharArray());
        }

        /// <summary> 民國、西元轉換 </summary>
        /// <param name="dateT">時間</param>
        /// <param name="type">(民國:Republic、西元:AD)</param>
        /// <param name="_splitSymbol">分割符號</param>
        /// <returns></returns>
        private static string PrivateChangeYear(List<string> dtA, string type, char[] outputSymbol)
        {
            if (dtA.Count != 3)
            {
                dtA.Add("01");
                dtA.Add("01");
            }
            int year = type == "Republic" ? 1911 : -1911;
            var y = int.Parse(dtA.First()) + year;
            string str = string.Format("{0}{3}{1}{3}{2}", y.ToString(), dtA[1], dtA[2], outputSymbol[0]);
            return str;
        }
    }
}
