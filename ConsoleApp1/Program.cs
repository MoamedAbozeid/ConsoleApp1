
using commn.Enum;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using System.Text;

namespace ConsoleApp1
{
    internal class Program

    {
     
        static void Main(string[] args)

        {
            #region السوال الاول
            /*
             Add a private string password = "secret"; field to a Book class. Try to print it from Main
           (outside the class). What happens, and why?
             */
            //هيدي error علشان password privet ومينفعش اوصلو برا class.
           /* Book book = new Book();
            book.password;
            Console.WriteLine(book.password);*/
            #endregion
            /////////////////////////////
            #region  السوال الثاني
            /*
             Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
             Why?
             */
            //هيشتغل عادي من غير error علشان copiesInStock internal وممكن اوصلو برا class.
            Book book= new Book();
            book.copiesInStock=5;
            Console.WriteLine(book.copiesInStock);
            #endregion
            ///////////////////////////////////
            #region لسوال الثالث
            /*
            Add a public string Title; field to Book. Set it and print it from Main
            */

            Book obj= new Book();
            obj.Title="book";
            Console.WriteLine(obj.Title);
            #endregion
            //////////////////
            #region السول الرابع
            /*
             Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
               assign it Genre.Science, and print it.
             */
            Book book01= new Book();
            book01.Genre = Gener.science;
            Console.WriteLine(book01.Genre);

            #endregion
            /////////////////////////
            #region السوال الخامس
            /*
             Using the Genre enum above, print the underlying int value of
              Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
             */
            Console.WriteLine((int)Gener.Fiction);
            Console.WriteLine((int)Gener.Nonfiction);
            Console.WriteLine((int)Gener.science);
            #endregion
            /////////////////////////
            #region السوال السادس
            /*
             Given int genreNumber = 1;, cast it into a Genre value and print the result
             */
            int genreNumber = 1;
            Gener genre = (Gener)genreNumber;
            Console.WriteLine(genre);
            #endregion
            ////////////////////////////
            #region السوال السابع
            /*
             * Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
             */
            Gener genre1 = Gener.Fiction;
            string genreString = genre1.ToString();
            Console.WriteLine(genreString);
            #endregion
            /////////////////////////////
            #region السوال الثامن 
            /*
             Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
              print the result.

             */
            string genreText = "Science";
            Gener genre2 = (Gener)Enum.Parse(typeof(Gener), genreText);
            Console.WriteLine(genre2);
            #endregion
            /////////////////////
            #region السوال التاسع
            /*
             Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to
              attempt the conversion. Print "Unknown genre" if it fails.
             */
            string genreText1 = "Mystery";
            Gener gener;
            if (Enum.TryParse(genreText1, out gener))
            {
                Console.WriteLine(gener);
            }
            else
            {
                Console.WriteLine("Unknown genre");

            #endregion
            }
        }
    }
        }

           