using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Project.Models
{
    public class Book
    {
        // ID книги 
        public int Id { get; set; }
        // Название книги
        public string Name { get; set; }
        // Автор книги 
        public string Author { get; set; }
        // Цена 
        public int Price { get; set; }

    }
}
