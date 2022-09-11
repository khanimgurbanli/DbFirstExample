using AddCategoryDbFirst.Models;
using System.Drawing;

namespace AddCategoryDbFirst
{
    class Program
    {
        public static void Main()
        {
            NorthwindContext db = new();
            var categories = db.Categories.ToList();

            foreach (var catgr in categories)
             db.Categories.Add(new Category
             {
                 CategoryName = "Task category",
                 Description = "For task description"
             });


            bool returnResult = db.SaveChanges() > 0;

                Console.BackgroundColor =ConsoleColor.Green;
            if (returnResult)
                    Console.WriteLine("Succesfully added category ");
            else
                Console.WriteLine("Warning, chack prosses and try again");
            Console.ResetColor();
            var a = db.Categories.FirstOrDefault(x => x.CategoryName == "Task category");
            Console.WriteLine($"Catgory Name: {a.CategoryName} \nCategory Description: {a.Description}");
        }
    }
}

