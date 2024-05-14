using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Progect_Modul25.ClassRepository
{
    public class BookRepository
    {
        public void Commands()
        {
            using (var db = new EntityFrame.AppContext())
            {
                // Выбор книги по id
                var BookForId = db.Books.Where(b => b.Id == 2).ToList();

                // Список всех книг
                var AllBook = db.Books.ToList();

                // Добавление книги 
                db.AddRange(
                    // Список объектов
                    );

                // Удаление книг
                db.RemoveRange(
                    // список книг
                    );

                // обновление года выпуска книги 
                var ChangeYear = db.Books.FirstOrDefault(b => b.Id == 2);
                ChangeYear.Year_of_issue = 2000;


                int FirstYear = 1996;
                int OldYear = 2004;
                // Получаем список книг определенного жанра и вышедших между определенными годами
                db.Books.Where(g => g.Gender == "Happy" && g.Year_of_issue > FirstYear && g.Year_of_issue < OldYear);

                //Получаем количество книг определенного автора в библиотеке.
                var CountAuthor = db.Books.Count(b => b.Author == "Pushkin");

                // Получаем количество книг определенного жанра в библиотеке
                var CountGender = db.Books.Count(b => b.Gender == "Fantastic");

                // Получаем булевый флаг о том, есть ли книга определенного автора и с определенным названием в библиотеке
                var Author = "Pushkin";
                var Title = "Не помню))";
                db.Books.Any(b => b.Author == Author && b.Title == Title);

                // Получение последней вышедшей книги
                var SortBook = db.Books.OrderByDescending(b => b.Year_of_issue).FirstOrDefault();

                // Получение списка всех книг, отсортированного в алфавитном порядке по названию
                var SortBookName = db.Books.OrderBy(b => b.Title);

                //Получение списка всех книг, отсортированного в порядке убывания года их выхода.
                var SortBookYear = db.Books.OrderByDescending(b => b.Year_of_issue);






            }
        }

    }
}
