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

            string sql = @"insert int dbo.Books (Title, Author, Genre, Year, Des, Photo)
                           values (@Title, @Author, @Genre, @Year, @Des, @Photo)";

            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<AllBooks> LoadBooks()
        {
            string sql = @"select Id, Title, Author, Genre, Year, Des, Photo
                        from dbo.Books;";
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }
    }
}
