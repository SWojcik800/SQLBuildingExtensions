var sql = $@"SELECT 
{SqlBuildingExtensions.Lib.SqlBuildingExtensions.SelectExpressions(
    "Column1",
    ("Column2", "AliasedColumn2"),
    "COUNT(*)",
    ("(SELECT COUNT(*) FROM SomeOtherTable", "OtherTableExpression"),
    SqlBuildingExtensions.Lib.SqlBuildingExtensions.Alias("Expr", "AliasedExpr")
    )
    } FROM TableName";

Console.WriteLine(sql);