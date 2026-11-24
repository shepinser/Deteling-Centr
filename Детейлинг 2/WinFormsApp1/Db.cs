using System.Data;
using System.Data.OleDb;

namespace WinFormsApp1;

// Здесь только подключение к Access и выполнение запросов.
public static class Db
{
    public static string DatabasePath { get; } = FindDatabase();

    private static string FindDatabase()
    {
        // При работе из Visual Studio используем ту же базу, которую открываем в Access.
        string source = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory,
            "..", "..", "..", "..", "БД", "бд.accdb"));
        return File.Exists(source) ? source : Path.Combine(AppContext.BaseDirectory, "бд.accdb");
    }

    public static OleDbConnection Open()
    {
        var connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};");
        connection.Open();
        return connection;
    }

    public static OleDbCommand Command(OleDbConnection connection, OleDbTransaction? transaction,
        string sql, params object?[] values)
    {
        var command = new OleDbCommand(sql, connection, transaction);
        // В Access параметры ? подставляются строго по порядку.
        foreach (object? value in values)
        {
            var parameter = new OleDbParameter();
            parameter.Value = value ?? DBNull.Value;
            parameter.OleDbType = value switch
            {
                DateTime => OleDbType.Date,
                int or null => OleDbType.Integer,
                decimal => OleDbType.Currency,
                bool => OleDbType.Boolean,
                _ => OleDbType.VarWChar
            };
            command.Parameters.Add(parameter);
        }
        return command;
    }

    public static DataTable Read(string sql, params object?[] values)
    {
        using var connection = Open();
        using var command = Command(connection, null, sql, values);
        using var adapter = new OleDbDataAdapter(command);
        var table = new DataTable();
        adapter.Fill(table);
        return table;
    }

    public static int Execute(string sql, params object?[] values)
    {
        using var connection = Open();
        using var command = Command(connection, null, sql, values);
        return command.ExecuteNonQuery();
    }

    public static void Transaction(Action<OleDbConnection, OleDbTransaction> action)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction();
        try { action(connection, transaction); transaction.Commit(); }
        catch { transaction.Rollback(); throw; }
    }

    public static int Execute(OleDbConnection connection, OleDbTransaction transaction,
        string sql, params object?[] values)
    {
        using var command = Command(connection, transaction, sql, values);
        return command.ExecuteNonQuery();
    }

    public static int NewId(OleDbConnection connection, OleDbTransaction transaction)
    {
        using var command = Command(connection, transaction, "SELECT @@IDENTITY");
        return Convert.ToInt32(command.ExecuteScalar());
    }
}

// Это пользователь, который сейчас вошёл в программу.
public sealed record Session(int Id, string FullName, string Role)
{
    public bool IsAdmin => Role == "Admin";
}
