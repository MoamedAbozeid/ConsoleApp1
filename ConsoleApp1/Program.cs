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
        void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }
            Console.WriteLine(books[0]);
        }
        static void Main(string[] args)

        {
            #region
            /*
             * asignment tow
              */
            #endregion
            #region


            /*
            * السوال الاول
             *Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
               both title and upperTitle to show that title did not change.*/

            string title = "clean code";
            String uppertitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(uppertitle);
            #endregion

            #region
            /*
             السوال الثاني
             Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
              to check if they point to the same object in memory.
             */
            string title01 = "Clean Code";
            string title02 = "Clean Code";
            bool thesamerefrence = ReferenceEquals(title01, title02);

            Console.WriteLine(thesamerefrence);
            #endregion

            #region
            /*
            السوال الثالث
             Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
             Print the result.           
             */
            /* 
             السول الرابع
             Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
              Print the result.

            السوالين تبع بعض
             */
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append("-updated");
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());
            #endregion

            #region السوال الخامس
            /*
             Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
             Pages: 464" using the + operator.
             */
            string title1 = "Clean Code";
            int pages = 464;
            string sentence = "Book: " + title1 + ", Pages: " + pages;
            Console.WriteLine(sentence);
            #endregion

            #region السوال السادس
            /*
             Build the same sentence as above, but using string interpolation ($"...").
             */
            string title101 = "Clean Code";
            int pages01 = 464;
            string sentence01 = $"Book:  {title101} ,  Pages01: {pages01}";
            Console.WriteLine(sentence01);
            #endregion
            #region السوال لسابع
            /*
             Build the same sentence again, but using string.Format().
             */
            string title102 = "Clean Code";
            int pages02 = 464;
            string sentence02 = string.Format("Book: {0}, Pages: {1}", title102, pages02);
            Console.WriteLine(sentence02);

            #endregion
            #region السوال الثامن
            /* 
             Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
              300, otherwise prints "Short Book".
             */
            int pages03 = 464;

            if (pages03 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region السوال التاسع
            /*
            Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            greater than 300 and isAvailable is true. Use the && operator. 
             */
            int pages04 = 464;
            bool isAvailable = true;

            if (pages04 > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion
            #region السوال العاشر
            /*Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
             "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.*/

            string title03 = "Refactoring";
            switch (title03)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region السوال الحادي عشر
            /*
             Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
             variable sizeLabel (same rule as question 8: long if pages > 300).
             */
            int pages05 = 464;
            string sizeLabel = (pages05 > 300) ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            #region السوال الثاني عثر
            /*
             Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
             to print each book with its position number, like 1. Clean Code.
             */


            /*    
             
             * السوال الثالث عثر 

             Using the same books array, use a while loop to print every book title.
             */

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");

            }
            int j = 0;
            while (j < books.Length)
            {
                Console.WriteLine(books[j]);
                j++;
            }
            
            #endregion
                    #region السوال الرابع عشر
                    /*
                     Write a do-while loop that prints "Checking book..." exactly 3 times.
                     */
                    int x = 0;
                    do
                    { Console.WriteLine("Checking book...");
                        x++;
                    }
                    while (x < 3);



            #endregion
            #region سوال الخامس عشر
            /* السوال الخامس عشر
            * Using the same books array, use a foreach loop to print every book title.
            */
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion


            #region  لسوال السادس عشر
            /*
             Using the same books array, loop through it and print each title, but stop completely (break) once
              you reach "Refactoring".
             */
            int k = 0;
                    while (k < books.Length)
                    {
                        if (books[k] == "Refactoring")
                        {
                            break;
                        }
                        Console.WriteLine(books[k]);
                        k++;
                    }
            #endregion
            #region  السوال السابع عشر
            /*
             Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
             continue, don't stop the loop).
             */
            int m = 0;
            while (m < books.Length)
            {
                if (books[m] == "The Pragmatic Programmer")
                {
                    m++;
                    continue;
                }
                Console.WriteLine(books[m]);
                m++;
            }

            #endregion
            #region السوال الثامن عشر
            /*
             * Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
use return to exit the method early instead of printing anything.
             */
            
            #endregion
        }
    }
        }

           