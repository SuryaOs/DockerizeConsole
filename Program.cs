// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

//string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EGrocer;Integrated Security=True;";

// Connection String

var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var userId = Environment.GetEnvironmentVariable("DB_USERID");
var password = Environment.GetEnvironmentVariable("DB_SA_PASSWORD");

string connectionString = $"Data Source={dbHost};User ID={userId};Password={password};";

// Retry Variables

int maxRetries = 5;
int retryDelayInSeconds = 10;

SqlConnection conn = null;
bool isConnected = false;

for (int retryCount = 1; retryCount <= maxRetries; retryCount++)
{
    try
    {
        Console.WriteLine($"Attempting database connection (Retry {retryCount})...");

        conn = new SqlConnection(connectionString);
        conn.Open();

        // If the connection is successful, set isConnected to true and break out of the loop
        isConnected = true;
        break;
    }
    catch (SqlException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");

        // Handle the exception or log it as needed

        if (retryCount < maxRetries)
        {
            Console.WriteLine($"Retrying in {retryDelayInSeconds} seconds...");
            Thread.Sleep(retryDelayInSeconds * 1000); // Delay before the next retry
        }
        else
        {
            Console.WriteLine("Maximum retries reached. Unable to connect to the database.");
        }
    }
    finally
    {
        conn?.Close();
    }
}

if (isConnected)
{
    Console.WriteLine("Connection successful!");
}
else
{
    Console.WriteLine("Unable to establish a database connection. Exiting...");
}