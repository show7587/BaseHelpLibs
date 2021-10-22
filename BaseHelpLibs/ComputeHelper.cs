using System;
using System.Data;

namespace BaseHelpLibs
{
    public class ComputeHelper
    {
        private static readonly DataTable _dt = new DataTable();
        public static object Compute(string expression) => _dt.Compute(expression, null);
        
    }
}
