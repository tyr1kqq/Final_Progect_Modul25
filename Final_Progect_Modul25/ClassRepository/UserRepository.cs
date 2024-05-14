using Final_Progect_Modul25.database_classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Progect_Modul25.ClassRepository
{
    public class UserRepository
    {
        // метод с общей выборкой объектов из БД
        public void Commands(User user)
        {
            var db = new EntityFrame.AppContext();
            

                // выборка пользователя по id
                var UserdForId = db.Users.Where(u => u.Id == 2).ToList();

                var allUSers =  db.Users.ToList();
                // Удаление пользователей
                db.Users.RemoveRange(
                    // пользователи
                    );

                // Добавление пользователей
                db.Users.AddRange(
                    // пользователи
                    );

                // изменение данных 
                var firstUser = db.Users.FirstOrDefault();
                firstUser.Email = "gmail@gmail.com";
                // или 
                var user2 = db.Users.FirstOrDefault(x => x.Id == 2);
                user2.Email = "2gmail@gmail.com";

            // Получаем булевый флаг о том, есть ли определенная книга на руках у пользователя.
             var UsersHaveBook = db.Books.Include(u=> u.User).Where(u => u.User.Id == 2).ToList();

            // Получаем количество книг на руках у пользователя
            var CountBooksUser = db.Books.Count(b => b.UserId == user.Id);




        }


    }
}
