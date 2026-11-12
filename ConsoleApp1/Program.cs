using System.Runtime.Versioning;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Book book = new Book();
            object obj = book;




            Console.WriteLine(book.ToString());
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetType());

            /*
             * int pages="464";
             * combile time
             * */
            /* int pages = 464;
             Console.WriteLine(pages);

             int x = 0;

             try
             {
                 int result = 10/x;
             }
             catch (DivideByZeroException)
             {
                 Console.WriteLine("con't divide by zero");
             }
             finally
             {
                 Console.WriteLine("Done");

             }
            */
            int age = 300;
            double agedoubel = age;
            Console.WriteLine(age);

            double price = (int)49.99;
            Console.WriteLine(price);

            String pagestext = "464";
            int pages = Convert.ToInt32(pagestext);
            Console.WriteLine(pages);

            string yeartext = "2023";

            int year = int.Parse(yeartext);
            Console.WriteLine(year);

            string yeartext01 = "abc";
            bool result = int.TryParse(yeartext01, out int text);
            Console.WriteLine(result);
        }
    }
}
