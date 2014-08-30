﻿using System;
using MySql.Data;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        Console.Write("Enter pass: ");
        string pass = Console.ReadLine();

        string connectionStr = "Server=localhost;Database=sakila;Uid=root;Pwd=" + pass + ";";
        MySqlConnection connection = new MySqlConnection(connectionStr);
        connection.Open();
        using (connection)
        {
            MySqlCommand command = new MySqlCommand("select * from country", connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
            }
        }

    }
}
