using EFCoreExample.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.CodeFirst
{
    class Program
    {    
        public static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                foreach (var item in context.Sections.Include(x => x.Course))
                {
                    Console.WriteLine($"Section: {item.SectionName}, " +
                        $"Course {item.Course.CourseName}");
                }
            }

            Console.ReadKey();
        }
    }
}

