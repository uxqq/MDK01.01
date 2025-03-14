using System;
using System.Collections.Generic;

namespace Лаба_2
{
     public class ReportSales
    {
        private List<SalesRecords> salesRecords;

        public ReportSales()
        {
            salesRecords = new List<SalesRecords>();
        }

        public void AddSale(SalesRecords record)
        {
            salesRecords.Add(record);
        }

        public void PrintReportAll() 
        {
            double totalRevenue = 0;
            foreach (var record in salesRecords)
            {
                var film = record.GetFilm();

                Console.WriteLine($"День: {record.GetDay()}, Название фильма: {film.GetName()}, Жанр: {film.GetGenre()}, Цена: {film.GetPrice()}, Количество: {film.GetQuantity()}, Выручка с фильма: {film.GetPrice() * film.GetQuantity()}");
                totalRevenue += film.GetQuantity() * film.GetPrice();
            }
            Console.WriteLine($"Общая выручка: {totalRevenue}");
        }

        public void PrintReportPerGenre()
        {
            string genre;
            Console.WriteLine("Введите жанр: ");
            genre = Console.ReadLine();

            double totalRevenue = 0;
            foreach (var record in salesRecords)
            {
                var film = record.GetFilm();
                if (genre == Convert.ToString(film.GetGenre()))
                {
                    Console.WriteLine($"День: {record.GetDay()}, Название фильма: {film.GetName()}, Жанр: {film.GetGenre()}, Цена: {film.GetPrice()}, Количество: {film.GetQuantity()}, Выручка с фильма: {film.GetPrice() * film.GetQuantity()}");
                    totalRevenue += film.GetQuantity() * film.GetPrice();
                }
            }
            if (totalRevenue != 0)
            {
                Console.WriteLine($"Общая выручка: {totalRevenue}");
            }
            if (totalRevenue == 0)
            {
                Console.WriteLine("Выручка по жанру нулевая/Данного жанра не существует");
            }
        }
    }
}
