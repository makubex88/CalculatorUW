using System;

namespace CalcX1
{
    internal class DataColumn
    {
        private string expression;
        private Type type;
        private string v;

        public DataColumn()
        {
        }

        public DataColumn(string v, Type type, string expression)
        {
            this.v = v;
            this.type = type;
            this.expression = expression;
        }
    }
}