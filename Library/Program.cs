using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBContext db = new DBContext();

            Book book1 = new Book("Герой нашего времени", "М.Ю.Лермонтов", 1839, "Повесть", 156, false, 899.99, true);
            Book book2 = new Book("Евгений Онегин", "А.С.Пушкин", 1833, "Роман в стихах", 400, true, 1499.99, false);
            Book book3 = new Book("Война и Мир", "Л.Н.Толстой", 1863, "Роман", 1300, true, 2199.99, true);

            db.Add(book1);
            db.Add(book2);
            db.Add(book3);

            db.SortByName();
            db.SortByPrice();
            db.SortByYear();

            db.PrintAllInformation();

            Console.ReadKey();
        }
    }
}
