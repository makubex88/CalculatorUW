using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace CalcX1
{
    class Operation
    {
        public string InputedNumbers(string value)
        {
            return value += value;
        }

        //static double Evaluate(string expression)
        //{
        //    var loDataTable = new DataTable();
        //    var loDataColumn = new DataColumn("Eval", typeof(double), expression);
        //    loDataTable.Columns.Add(loDataColumn);
        //    loDataTable.Rows.Add(0);
        //    return (double)(loDataTable.Rows[0]["Eval"]);
        //}


    }
}
