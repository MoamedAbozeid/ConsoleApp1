using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            #region
            //السوال الثاني
            /* Create a Book class with a Title(string) and Pages(int). Create a Book object and store it
           in a variable of type object.Print it.*/


            Book book = new Book();
            object obj = book;
            #endregion


            #region
            /*
             * السول لثالث
            Using the Book class above, print the result of calling ToString(), Equals() (compare book
          with itself), GetHashCode(), and GetType() on book.*/

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetType());
            #endregion

            #region
            /*السوال الرابع
             Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
             int pages = "464";*/
            string pagesText = "464";
            int pages = Convert.ToInt32(pagesText);
            #endregion

            #region
            /*
             * السوال الخامس
            Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            divide by zero", and then prints "Done" in a finally block.*/




            int x = 0;


            try
            {
                Console.WriteLine(10 / x);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("con't divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");

            }
            #endregion

            #region
            /*السوال السادس
             * Declare an int pages = 300; then store it in a double variable without using a cast.
             */

            int age = 300;
            double ageDouble = (double)age;
            Console.WriteLine(age);
            #endregion

            #region
            /*السوال السابع
            Declare a double price = 49.99; then convert it into an int using a cast.
             */


            double price = (int)49.99;
            Console.WriteLine(price);
            #endregion

            #region

            /* لسوال الثامن
            Given string pagesText = "464";, convert it into an int using the Convert class.
            */
            string pagesText01 = "464";
            int pages01 = Convert.ToInt32(pagesText01);
            Console.WriteLine(pages01);
            #endregion
            #region
            /* السوال التاسع
             Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
             "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            */
            string yeartext = "2023";
            int year = int.Parse(yeartext);
            Console.WriteLine(year);
            String badText = "abc";

            if (int.TryParse(badText, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {

                Console.WriteLine("Invalid number");
            }

            #endregion
            #region
            /*
             * السوال العاثر
             * Given int pages = 464;, convert it into a string using ToString() and print its type using
              GetType() to prove it's now a string.
             */
            int page = 464;
            string pagtext = page.ToString();
            Console.WriteLine(pagtext);
            Console.WriteLine(pagtext.GetType());
            #endregion
            #region
            /*
             Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
              variable, and print both.
             */
            int copies = 100;
            object poxcopies = copies;
            Console.WriteLine(poxcopies);
            object poxcopies01 = 100;
            int copies01 = (int)poxcopies;
            Console.WriteLine(copies01);
            #endregion
            #region
            /*
             * السوال الحادي عشر
            Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
            value. 
             */
            int? year01 = null;
            Console.WriteLine(year01.HasValue);
             year01 = 2023;
            Console.WriteLine(year01.Value);
            #endregion
            #region
            /*
            السوال لثاني عشر
             * Declare a string? reviewer = null;. Print whether it is null*/
            string? reviewer = null;
            Console.WriteLine(reviewer is null);
            #endregion
            #region
            /* السوال الثالث عشر
             * Declare a Book? book = null;. Use?.to safely read book.Title without crashing the
              program, and print the result*/
            Book? book01 = null;
            Console.WriteLine(book01?.title);

            #endregion
            #region
            /*
             * السول الرابع عشر
             * Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??=
              to assign title the value "Untitled" only if it's still null.
             */
            string? title = null;
            Console.WriteLine(title ?? "Untitled");
            title ??= "Untitled";
            #endregion
            #region
            /*
             السول الخامس عشر
            Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable
            string confirmedName using the ! operator j.
             */
            string name = "ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);
            #endregion

        }
    }
        }