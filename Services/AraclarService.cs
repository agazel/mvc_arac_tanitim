#nullable enable

using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Data;

public class AraclarService
{
    private readonly string? _connectionString;

    public AraclarService(string? connectionString)
    {
        _connectionString = connectionString;
    }

    public Araclar? GetAracDetails(string baslik)
    {
        if (_connectionString is null)
        {
            // _connectionString null ise, bir hata durumu veya alternatif bir işlem yapılabilir.
            Console.WriteLine("ConnectionString null olduğu için veritabanına bağlanılamıyor.");
            return null;
        }

        using (IDbConnection dbConnection = new SqliteConnection(_connectionString))
        {
            dbConnection.Open();

            // Veritabanından seçilen aracın detaylarını çek
            string query = "SELECT * FROM Araclar WHERE Baslik = @Baslik";

            // QueryFirstOrDefault metodu kullanılarak veritabanından bir Araclar nesnesi alınır.
            // Eğer veri bulunamazsa null döner.
            return dbConnection.QueryFirstOrDefault<Araclar>(query, new { Baslik = baslik });
        }
    }
}
