using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string artricleContent = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {articleTitle}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {artricleContent}");
            Console.WriteLine("</article>");

            string articleComments = Console.ReadLine();

            while (articleComments != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"   {articleComments}");
                Console.WriteLine("</div>");

                articleComments = Console.ReadLine();
            }
        }
    }
}
