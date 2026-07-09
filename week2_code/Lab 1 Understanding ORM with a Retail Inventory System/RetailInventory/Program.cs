using RetailInventory.Data;

Console.WriteLine("Creating database context...");

using var db = new AppDbContext();

Console.WriteLine("Connected successfully!");