using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Dapper;

#nullable disable

namespace SelfFinanceAPI.Core.Migrations
{
    /// <inheritdoc />
    public partial class InsertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "appsettings.json");
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(configPath, optional: true, reloadOnChange: true)
                .Build();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(
@"
        INSERT INTO ExpeseTypes (Name, IsIncome)
        VALUES 
            ('Salary', 1),
            ('Meal', 0),
            ('Additional income', 1),
            ('Transport', 0),
            ('Rent', 0),
            ('Utilities', 0),
            ('Groceries', 0),
            ('Entertainment', 0),
            ('Investment', 1),
            ('Healthcare', 0);

        INSERT INTO FinancialOperations (TypeId, Amount, DateTime, Description)
        VALUES 
            (1, 3000, '2023-10-21 10:00:00', 'Salary for September 7th'),
(2, 20, '2023-10-21 12:30:00', 'Lunch'),
(3, 500, '2023-10-21 15:45:00', 'Additional income'),
(4, 10, '2023-10-21 18:20:00', 'Bus fare'),
(5, 1200, '2023-10-21 20:00:00', 'Rent payment'),
(6, 150, '2023-10-21 22:15:00', 'Utilities bill'),
(7, 50, '2023-10-21 23:30:00', 'Grocery shopping'),
(2, 20, '2023-10-21 18:30:00', 'Dinner'),
(8, 40, '2023-10-21 19:00:00', 'Movie night'),
(9, 1000, '2023-10-21 14:00:00', 'Investment deposit'),
(10, 80, '2023-10-21 16:45:00', 'Doctor appointment'),
(1, 3000, '2023-10-22 10:00:00', 'Salary for September 8th'),
(2, 20, '2023-10-22 12:30:00', 'Lunch'),
(3, 500, '2023-10-22 15:45:00', 'Additional income'),
(4, 10, '2023-10-22 18:20:00', 'Bus fare'),
(5, 1200, '2023-10-22 20:00:00', 'Rent payment'),
(6, 150, '2023-10-22 22:15:00', 'Utilities bill'),
(7, 50, '2023-10-22 23:30:00', 'Grocery shopping'),
(8, 40, '2023-10-22 19:00:00', 'Movie night'),
(9, 1000, '2023-10-22 14:00:00', 'Investment deposit'),
(10, 80, '2023-10-22 16:45:00', 'Doctor appointment'),
(1, 3000, '2023-10-23 10:00:00', 'Salary for September 9th'),
(2, 20, '2023-10-23 12:30:00', 'Lunch'),
(3, 500, '2023-10-23 15:45:00', 'Additional income'),
(4, 10, '2023-10-23 18:20:00', 'Bus fare'),
(5, 1200, '2023-10-23 20:00:00', 'Rent payment'),
(6, 150, '2023-10-23 22:15:00', 'Utilities bill'),
(7, 50, '2023-10-23 23:30:00', 'Grocery shopping'),
(8, 40, '2023-10-23 19:00:00', 'Movie night'),
(9, 1000, '2023-10-23 14:00:00', 'Investment deposit'),
(10, 80, '2023-10-23 16:45:00', 'Doctor appointment'),
(1, 3000, '2023-10-24 10:00:00', 'Salary for September 10th'),
(2, 20, '2023-10-24 12:30:00', 'Lunch'),
(3, 500, '2023-10-24 15:45:00', 'Additional income'),
(4, 10, '2023-10-24 18:20:00', 'Bus fare'),
(5, 1200, '2023-10-24 20:00:00', 'Rent payment'),
(6, 150, '2023-10-24 22:15:00', 'Utilities bill'),
(7, 50, '2023-10-24 23:30:00', 'Grocery shopping'),
(8, 40, '2023-10-24 19:00:00', 'Movie night'),
(9, 1000, '2023-10-24 14:00:00', 'Investment deposit'),
(10, 80, '2023-10-24 16:45:00', 'Doctor appointment'),
(1, 3000, '2023-10-25 10:00:00', 'Salary for September 11th'),
(2, 20, '2023-10-25 12:30:00', 'Lunch'),
(3, 500, '2023-10-25 15:45:00', 'Additional income'),
(4, 10, '2023-10-25 18:20:00', 'Bus fare'),
(5, 1200, '2023-10-25 20:00:00', 'Rent payment'),
(6, 150, '2023-10-25 22:15:00', 'Utilities bill'),
(7, 50, '2023-10-25 23:30:00', 'Grocery shopping'),
(8, 40, '2023-10-25 19:00:00', 'Movie night'),
(9, 1000, '2023-10-25 14:00:00', 'Investment deposit'),
(10, 80, '2023-10-25 16:45:00', 'Doctor appointment'),
(1, 3000, '2023-10-26 10:00:00', 'Salary for September 12th'),
(2, 20, '2023-10-26 12:30:00', 'Lunch'),
(3, 500, '2023-10-26 15:45:00', 'Additional income'),
(4, 10, '2023-10-26 18:20:00', 'Bus fare'),
(5, 1200, '2023-10-26 20:00:00', 'Rent payment'),
(6, 150, '2023-10-26 22:15:00', 'Utilities bill'),
(7, 50, '2023-10-26 23:30:00', 'Grocery shopping'),
(8, 40, '2023-10-26 19:00:00', 'Movie night'),
(9, 1000, '2023-10-26 14:00:00', 'Investment deposit'),
(10, 80, '2023-10-26 16:45:00', 'Doctor appointment'),
(1, 3000, '2023-10-27 10:00:00', 'Salary for September 13th'),
(2, 20, '2023-10-27 12:30:00', 'Lunch'),
(3, 500, '2023-10-27 15:45:00', 'Additional income'),
(4, 10, '2023-10-27 18:20:00', 'Bus fare'),
(5, 1200, '2023-10-27 20:00:00', 'Rent payment'),
(6, 150, '2023-10-27 22:15:00', 'Utilities bill'),
(7, 50, '2023-10-27 23:30:00', 'Grocery shopping'),
(8, 40, '2023-10-27 19:00:00', 'Movie night'),
(9, 1000, '2023-10-27 14:00:00', 'Investment deposit'),
(10, 80, '2023-10-27 16:45:00', 'Doctor appointment');
    ");
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
