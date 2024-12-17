var sql = $@"SELECT 
{SqlBuildingExtensions.Lib.SqlBuildingExtensions.SelectExpressions(
    "Column1",
    ("Column2", "AliasedColumn2"),
    "COUNT(*)",
    ("(SELECT COUNT(*) FROM SomeOtherTable", "OtherTableExpression")
    )
    } FROM TableName";

Console.WriteLine(sql);