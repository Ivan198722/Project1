using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollTrackingApp1
{
    public class DataBase
    {
        // Inicjalizacja obiektu SqlConnection z określoną łańcuchem połączenia do bazy danych.
        SqlConnection sqlConnection = new SqlConnection("Data Source=desktop-d7kosmm;Initial Catalog=PayrollTrackingDB;Integrated Security=True");

        // Metoda do otwarcia połączenia z bazą danych.
        public void OpenConnection()
        {
            // Sprawdzenie, czy połączenie jest zamknięte.
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                // Otwarcie połączenia z bazą danych.
                sqlConnection.Open();
            }
        }

        // Metoda do zamknięcia połączenia z bazą danych.
        public void CloseConnection()
        {
            // Sprawdzenie, czy połączenie jest otwarte.
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                // Zamknięcie połączenia z bazą danych.
                sqlConnection.Close();
            }
        }

        // Metoda zwracająca obiekt SqlConnection, umożliwiający korzystanie z tego połączenia w innych częściach programu.
        public SqlConnection GetConnection()
        {
            // Zwrócenie obiektu SqlConnection.
            return sqlConnection;
        }
    }
}
