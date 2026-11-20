using System.Text;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            string title1 = "clean code";
            string uppertitle1 = title1.ToUpper();
            Console.WriteLine(title1);
            Console.WriteLine(uppertitle1);
            #endregion
            #region 2
            string a = "clean code";
            string b = "clean code";
            bool result = ReferenceEquals(a, b);
            Console.WriteLine(result);
            #endregion
            #region 3 ,4
            StringBuilder SB = new StringBuilder();
            SB.Append("Book List");
            SB.Append(" - Updated");
            Console.WriteLine(SB);
            SB.Replace( "Book List", "Library");
            Console.WriteLine(SB);
            #endregion
            #region 5,6,7
            string title2 = "clean code";
            int pages1 = 464;
            string result1 = "Book:"+ title2+",pages:"+pages1;
            Console.WriteLine(result1);
            Console.WriteLine($"Book: {title2}, Pages: {pages1}");
            Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title2, pages1));
            #endregion

            #region point 8
            int pages = 464;
            bool isavallible = true;
            if (pages > 300 && isavallible == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion
            #region point 9
            string title = "Refactoring";
            switch (title)
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
            #region point 10
                    string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            #endregion
            #region point 11,12
            string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine(Books[i] + (i + 1));
            }
            int counter = 0;
            while (counter < Books.Length)
            {
                Console.WriteLine(Books[counter] + (counter + 1));
                counter++;
            }
            #endregion
            #region point 13
            int count=1;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count<=3);
            #endregion
            #region point 14
            foreach(string item in Books)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region point 15,16
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i]== "Refactoring")
                {
                    break;
                }
                    Console.WriteLine(Books[i] );
            }
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(Books[i]  );
            }
            #endregion
            string[] sd = { };
            PrintFirstBook(sd);
            PrintFirstBook(Books);
        }
        #region point 17
        static void PrintFirstBook(string[]BookList)
        {
            int index = 0;
            if (index == BookList.Length)
                return;
            Console.WriteLine(BookList[0]);
           
        }
        #endregion
    }
}
