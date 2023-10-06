using ParquetViewer.Engine;
using System.Data;

if (args.Length < 1)
{
    Console.WriteLine("Please set valid source parquet file path. Output file name is optional.");
    return;
}

if (!File.Exists(args[0]))
{
    Console.WriteLine($"Source file not found:{args[0]}");
    return;
}

try
{
    var openParquetEngine = await ParquetEngine.OpenFileOrFolderAsync(args[0], CancellationToken.None);
    var columns = openParquetEngine.Schema.Fields.Select(f => f.Name).ToList();

    var mainDataSource = await openParquetEngine.ReadRowsAsync(columns, 0, 0, CancellationToken.None);
    mainDataSource.TableName = Path.GetFileNameWithoutExtension(args[0]).ToLower();

    var dataset = new DataSet();
    dataset.Tables.Add(mainDataSource);
    var scriptAdapter = new CustomScriptBasedSchemaAdapter();
    var sql = scriptAdapter.GetSchemaScript(dataset, false, ScriptType.Vertica);

    if (args.Length > 1)
    {
        File.WriteAllText(args[1], sql);
        Console.WriteLine($"Create table SQL was saved to file: {args[1]}");
    }
    else
    {
        Console.WriteLine(sql);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}

