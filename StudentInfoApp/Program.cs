using System;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace StudentInfoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dbPath = Path.GetFullPath("sis.db");
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Username TEXT, Password TEXT)",
                    conn
                ).ExecuteNonQuery();
                new SQLiteCommand(
                    "INSERT INTO Users (Username, Password) " +
                    "SELECT 'admin','1234' WHERE NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'admin')",
                    conn
                ).ExecuteNonQuery();
            }
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new LoginForm());
            Console.WriteLine("DB Path: " + dbPath);
        }
    }
}