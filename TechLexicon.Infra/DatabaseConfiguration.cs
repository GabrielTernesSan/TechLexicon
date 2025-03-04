using Microsoft.Extensions.Configuration;
using Npgsql;

namespace TechLexicon.Infra
{
    public class DatabaseConfiguration
    {
        public string Host { get; set; }
        public string ConnectionString { get; set; }
        public IConfiguration Configuration { get; }

        public DatabaseConfiguration(IConfiguration configuration)
        {
            var connectioString = configuration.GetConnectionString("Postgres");

            if (string.IsNullOrWhiteSpace(connectioString))
            {
                throw new ArgumentNullException($"Invalid ConnectionString:Postgres configuration value");
            }

            var defaultConnectioString = new NpgsqlConnectionStringBuilder(connectioString)
            {
                ApplicationName = "TechLexicon"
            };

            ConnectionString = defaultConnectioString.ToString();

            Host = defaultConnectioString.Host;
            Configuration = configuration;
        }

        public static DatabaseConfiguration LoadDevelopmentConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json", false)
                .Build();

            return new DatabaseConfiguration(configuration);
        }
    }
}
