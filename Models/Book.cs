using System;
namespace Models
{

    public class Book
    {
        // Поля класса
        private string title;
        private string author;
        private int year;
        private string genre;
        private int pageCount;
        private bool isBestseller;
        private double price;
        private bool isInStock;

        // Конструктор класса
        public Book(string title, string author, int year, string genre, int pageCount, bool isBestseller, double price, bool isInStock)
        {
            this.title = title; // текущий экземпляр класса
            this.author = author;
            this.year = year;
            this.genre = genre;
            this.pageCount = pageCount;
            this.isBestseller = isBestseller;
            this.price = price;
            this.isInStock = isInStock;
        }

        // Методы класса
        public void DisplayInfo()
        {
            Console.WriteLine("Название: " + title);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Год: " + year);
            Console.WriteLine("Жанр: " + genre);
            Console.WriteLine("Количество страниц: " + pageCount);
            Console.WriteLine("Является ли бестселлером: " + (isBestseller ? "Да" : "Нет")); // if (isBestseller) Да else Нет
            Console.WriteLine("Цена: Р" + price);
            Console.WriteLine("В наличии: " + (isInStock ? "Да" : "Нет"));
        }

        public void CheckInfo()
        {
            if (year >= 0 && pageCount > 0 && price > 0)
            {
                Console.WriteLine("Информация корректная");
            }
            else
            {
                Console.WriteLine("Информация некорректная");
            }
        }

        public void SetTitle(string title) => this.title = title;

        public void SetAuthor(string author) => this.author = author;

        public void SetYear(int year) => this.year = year;

        public void SetGenre(string genre) => this.genre = genre;

        public void SetPageCount(int pageCount) => this.pageCount = pageCount;

        public void SetBestseller(bool isBestseller) => this.isBestseller = isBestseller;

        public void SetPrice(double price) => this.price = price;

        public void SetIsInStock(bool isInStock) => this.isInStock = isInStock;

        public string GetTitle() => title;

        public double GetPrice() => price;

        public int GetYear() => year;
    }
}