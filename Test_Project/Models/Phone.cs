using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Project.Models
{
    public class Phone
    {
        // ID телефона 
        public int Id { get; set; }
        // Модель телефона
        public string Name { get; set; }
        // Производитель телефона
        public string Company { get; set; }
        // Цена 
        public int Price { get; set; }

    }
}
