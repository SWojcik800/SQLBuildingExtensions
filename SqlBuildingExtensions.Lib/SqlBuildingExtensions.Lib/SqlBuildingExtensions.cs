using System.Text;

namespace SqlBuildingExtensions.Lib
{
    public static class SqlBuildingExtensions
    {
        public static string SelectExpressions(params object[] cols)
        {
            StringBuilder sb = new StringBuilder(" ");
            for (int i = 0; i < cols.Length; i++)
            {
                var col = cols[i];
                if (col is ValueTuple<string, string>)
                {
                    var tuple = (ValueTuple<string, string>)col;
                    var colName = tuple.Item1;
                    var alias = tuple.Item2;
                    sb.Append(colName);
                    sb.Append(" AS ");
                    sb.Append(alias);
                }
                else if (col is ValueTuple<string, string>)
                {
                    var tuple = (Tuple<string, string>)col;
                    var colName = tuple.Item1;
                    var alias = tuple.Item2;
                    sb.Append(colName);
                    sb.Append(" AS ");
                    sb.Append(alias);
                }
                else if (col is string)
                {
                    var colName = col.ToString();

                    sb.Append(colName);
                }
                else
                {
                    throw new ArgumentException($"Invalid parameter type: {col.GetType().Name}. Parameter index: {i}");
                }

                if (i < cols.Length - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();


        }
    }

}
