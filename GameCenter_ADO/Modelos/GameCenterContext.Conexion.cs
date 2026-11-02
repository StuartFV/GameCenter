using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GameCenter_ADO.Modelos
{
    public partial class GameCenterContext
    {
        // Solo dejamos este constructor vacío (el otro ya lo maneja el archivo principal)
        public GameCenterContext()
        {
        }

        public static string ObtenerCadena()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("GameCenterConexion");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObtenerCadena());
            }
        }
    }
}