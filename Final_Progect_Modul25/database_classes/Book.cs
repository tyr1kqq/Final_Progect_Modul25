using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Final_Progect_Modul25.database_classes
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year_of_issue { get; set; }

    }
}
