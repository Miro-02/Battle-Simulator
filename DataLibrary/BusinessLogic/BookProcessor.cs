using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class BookProcessor
    {
        public static int CreateBook(string Title, string Author, string Genre, int Year, string Des, string Photo)
        {
            AllBooks data = new AllBooks
            {
                Title = Title,
                Author = Author,
                Genre = Genre,
                Year = Year,
                Des = Des,
                Photo = Photo
            };

            string sql = @"insert into dbo.Books (Id, Title, Author, Genre, Year, Des, Photo)
                           values (5, @Title, @Author, @Genre, @Year, @Des, @Photo)";

            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<AllBooks> LoadBooks()
        {
            string sql = @"select *
                        from dbo.Books;";
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }


        public static List<AllBooks> LoadBiography()
        {
            string sql = @"select *
                        from dbo.Books where Genre = 'Biography';";
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }


        public static List<AllBooks> LoadComedy()
        {
            string sql = @"select *
                        from dbo.Books where Genre = 'Comedy';";
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        public static List<AllBooks> LoadHorror()
        {
            string sql = @"select *
                        from dbo.Books where Genre = 'Horror';";
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        public static List<AllBooks> LoadFantasy()
        {
            string sql = @"select *
                        from dbo.Books where Genre = 'Fantasy';";
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        public static List<AllBooks> LoadTragedy()
        {
            string sql = @"select *
                        from dbo.Books where Genre = 'Tragedy';";
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }
    }
}
