using System.Linq.Expressions;
using System.Text;

namespace TaskC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //string title = "clean code";

            //string upperTitle = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            //Console.WriteLine(title.Equals(upperTitle));
            #endregion
            #region Q2
            //string str_1 = "clean code";
            //string str_2 = "clean code";

            //bool flag = string.ReferenceEquals(str_1, str_2); 
            //Console.WriteLine(flag);
            #endregion
            #region Q3 && Q4
            //StringBuilder sb = new StringBuilder(); 

            //sb.Append("Book List"); 
            //sb.Append(" - Updated");

            //Console.WriteLine(sb); 

            //sb.Replace("Book List", "Library"); 

            //Console.WriteLine(sb);
            #endregion
            #region Q5 && Q6 && Q7
            //string title = "Clean Code";
            //int pages = 464;
            //string formattedString = string.Format("Book: {0}, Pages: {1}", title, pages); //string.Format
            //Console.WriteLine("Book: " + title + ", Pages: " + pages); //concatenation
            //Console.WriteLine($"Book: {title}, Pages: {pages}");// interpolation
            //Console.WriteLine(formattedString);
            #endregion
            #region Q8
            //if else

            //int pages = 464;
            //if (pages>300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //} 
            //outPut==> "Long Book"

            #endregion
            #region Q9
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages>300 && isAvailable==true){ Console.WriteLine("You can borrow this book");}

            #endregion
            #region Q10
            // Switch 
            //string title = "Refactoring";

            //switch (title)
            //{
            //    case  "Refactoring": Console.WriteLine("Nice pick!");
            //        break;

            //    case "Clean Code":Console.WriteLine("Great choice!");
            //        break;

            //    default: Console.WriteLine("Never heard of it");break;
            //}




            #endregion
            #region Q11
            //Ternary Operator
            //int pages = 464;
            //string sizeLable = pages > 300 ? "Long Book" : "Short Book"; // output ==> "Long Book"
            //Console.WriteLine(sizeLable);
            #endregion
            #region Q12
            //Loops

            //string[] books =
            //{
            //    "Clean Code",
            //    "The Pragmatic Programmer",
            //    "Refactoring",
            //};
            //for (int i = 0; i < books.Length; i++)

            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}
            #endregion
            #region Q13
            //While 
            //int i = 0;


            //while (i<books.Length)

            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //    i++;
            //}
            #endregion
            #region Q14

            //int counter = 0;

            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    counter++;
            //}
            //while (counter < 3);

            #endregion
            #region Q15
            //FOREACH

            //foreach (string Book in books)
            //{
            //    Console.WriteLine(Book);
            //}
            #endregion
            #region Q16
            //BREAK

            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "Refactoring")
            //    {
            //        break;
            //    }
            //Console.WriteLine(books[i]);
            //}

            #endregion
            #region Q17
            // CONTINUE

            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i]== "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(books[i]);
            //}
            #endregion
            #region Q18
            //            static void PrintFirstBook()
            //            {
            //                string[] books =
            //{
            //                "Clean Code",
            //                "The Pragmatic Programmer",
            //                "Refactoring",
            //            };
            //                if (books.Length==0)
            //                {
            //                    return;
            //                }
            //                Console.WriteLine(books[0]); 
            //            }
            #endregion
        }
    }
}
