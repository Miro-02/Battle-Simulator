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
        //For creting a new book
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
            //sql query for adding inputed varialbles into the table
            string sql = @"insert into dbo.Books (Title, Author, Genre, Year, Des, Photo)
                           values (@Title, @Author, @Genre, @Year, @Des, @Photo)";

            //Using function for saving into the database 
            return SqlDataAccess.SaveData(sql, data);
        }

        //For reading from the database 
        public static List<AllBooks> LoadBooks()
        {
            //sql query for selecting (reading) from the book table
            string sql = @"select *
                        from dbo.Books ORDER BY Title ASC;";
            //Using function for reading from the book table
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        //For reading only books with Genre Biography
        public static List<AllBooks> LoadBiography()
        {
            //sql query for reading only Biography books
            string sql = @"select *
                        from dbo.Books where Genre = 'Biography';";
            //Using functions to celect from the table with our query
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }


        //For reading only books with Genre Comedy
        public static List<AllBooks> LoadComedy()
        {
            string sql = @"select *
                        from dbo.Books where Genre = 'Comedy';";
            //Using functions to celect from the table with our query
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        //For reading only books with Genre Horror
        public static List<AllBooks> LoadHorror()
        {
            string sql = @"select *
                        from dbo.Books where Genre = 'Horror';";
            //Using functions to celect from the table with our query
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        //For reading only books with Genre Fantasy
        public static List<AllBooks> LoadFantasy()
        {
            string sql = @"select *
                        from dbo.Books where Genre = 'Fantasy';";
            //Using functions to celect from the table with our query
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        //For reading only books with Genre Tragedy
        public static List<AllBooks> LoadTragedy()
        {
            string sql = @"select *
                        from dbo.Books where Genre = 'Tragedy';";
            //Using functions to celect from the table with our query
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        //For reading only new books(released after 2015)
        public static List<AllBooks> NewBooks()
        {
            string sql = @"select *
                        from dbo.Books where Year >= 2015;";
            //Using functions to celect from the table with our query
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        //For reading only new classic(released before 1900)
        public static List<AllBooks> ClassicBooks()
        {
            string sql = @"select *
                        from dbo.Books where Year <= 1900;";
            //Using functions to celect from the table with our query
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }

        //For reading the database with alphabeticlly ordered Authors
        public static List<AllBooks> AuthorsSort()
        {
            string sql = @"select *
                        from dbo.Books ORDER BY Author ASC;";
            //Using functions to celect from the table with our query
            return SqlDataAccess.LoadData<AllBooks>(sql);
        }
    }
}
