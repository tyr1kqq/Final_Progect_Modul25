using Microsoft.EntityFrameworkCore;
using Final_Progect_Modul25.database_classes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Final_Progect_Modul25
{
    public class Program
    {
        static void Main(string[] args)
        {
            using ( var db = new EntityFrame.AppContext() ) 
            {
                db.Database.EnsureCreated();

                db.SaveChanges();
            }

            Console.WriteLine("Это все:)");
            Console.ReadLine();

        }
    }
}
