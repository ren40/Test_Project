using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Project.Models
{
    public class Order
    {
        // ID покупки
        public int OrderId { get; set; }
        // Имя и Фамилия покупателя 
        public string Person { get; set; }
        // Адрес покупателя 
        public string Address { get; set; }
        // Ссылка на связанную модель Phone
        public int PhoneID { get; set; }
        
        public Phone Phone { get; set; }

    }
}
