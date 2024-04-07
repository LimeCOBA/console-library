using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBContext : List<Book>
    {
        public void SortByYear()
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                for (int j = 0; j < this.Count - i - 1; j++)
                {
                    if (this[j].GetYear() > this[j].GetYear())
                    {
                        Book temp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByPrice()
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                for (int j = 0; j < this.Count - i - 1; j++)
                {
                    if (this[j].GetPrice() > this[j].GetPrice())
                    {
                        Book temp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByName()
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                for (int j = 0; j < this.Count - i - 1; j++)
                {
                    if (this[j].GetTitle().CompareTo(this[j + 1].GetTitle()) > 0)
                    {
                        Book temp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = temp;
                    }
                }
            }
        }

        public void PrintAllInformation()
        {
            foreach (var item in this)
            {
                item.DisplayInfo();
                Console.WriteLine();
            }            
        }
    }
}
