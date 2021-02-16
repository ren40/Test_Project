using System;
using System.Linq;
using Test_Project.Models;

namespace Test_Project.Models
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone 
                    { 
                        Name = "POCO F2 PRO",
                        Company = "Xiaomi",
                        Price = 350
                    },
                    new Phone 
                    {
                        Name = "Samsung Galaxy Edge",
                        Company = "Samsung",
                        Price = 550
                    },
                    new Phone
                    {
                        Name = "Pixel 3",
                        Company = "Google",
                        Price = 500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
