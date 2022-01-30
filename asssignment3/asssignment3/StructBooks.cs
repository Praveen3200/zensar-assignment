using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssignment3
{
        struct Bookex
        {
            public string Book_Name;
            private int Book_ID { get; set; }


            public int book_ID
            {
                get { return Book_ID; }
                set { Book_ID = value; }

            }
            public void Display()
            {
                Console.WriteLine("Book Name:{0}\nBookID:{1}", Book_Name, Book_ID);
            }
        }
        class StructBook
        {
            public static void Main()
            {
                Bookex b = new Bookex();
                b.Book_Name = "clever fox";
                b.book_ID = 67592;
                b.Display();
                Console.Read();
            }
        }
}
