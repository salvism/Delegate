using System;
using System.Text.RegularExpressions;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student
            {
                No = 1,
                FullName = "Salvi Ismayilzada",
            };

            std.AddExam("C#", 100);
            std.AddExam("Intro", 100);
            std.AddExam("Front", 100);
            std.AddExam("Back", 100);

            std.ShowExams();

            Console.WriteLine(std.GetAvgPoint());

            Group group = new Group
            {
                No = "P231",
            };

            group.AddStudent(new Student { No = 1, FullName = "Nazila" });
            group.AddStudent(new Student { No = 2, FullName = "Gular" });
            group.AddStudent(new Student { No = 3, FullName = "Nigar" });

            group.No = "P231";

            Store store = new Store();

            store.Products.Add(new Product { No = 4, Name = "Kinder surprise", Price = 4, DiscountPercent = 40 });
            store.Products.Add(new Product { No = 17, Name = "Kinder deluxe", Price = 10, DiscountPercent = 10 });



            foreach (var item in store.FilterProducts(x => x.Price * ((100 - x.DiscountPercent) / 100) > 20))
            {
                Console.WriteLine($"{item.Name} - {item.Price} - {item.DiscountPercent}%");
            }

            foreach (var item in store.GetProducts(11, 21, 14, 45, 54))
            {
                Console.WriteLine($"{item.Name} - {item.Price} - {item.DiscountPercent}%");
            }


            var product = store.GetProduct(x => x.Price > 20);
            Console.WriteLine(product.Name);

            store.ChangeProduct(x => x.DiscountPercent = 0);
            Console.WriteLine("All products");
            foreach (var item in store.Products)
            {
                Console.WriteLine($"{item.Name} - {item.Price} - {item.DiscountPercent}%");
            }
        }
    }
}
