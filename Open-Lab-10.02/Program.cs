using System;

namespace Open_Lab_10._02
{
    class Program
    {
        static void Main()
        {
            Console.Write("KEKW");
            Book LOTR = new Book();
            LOTR.SetTitle("Plebovia a ich vyskyt, ");
            LOTR.SetPages(888);
            LOTR.SetCategory(", Intelektualne");
            LOTR.SetAuthor(", Vladimir Iľjič Lenin, ");
            LOTR.SetreleaseDate(10,4,1998);
        }
    }
    class Book
    {
       public void SetTitle(string title)
        {
            Console.Write(title);
        }
        public void SetPages(int pages)
        {
            Console.Write(pages);
        }
        public void SetCategory(string category)
        {
            Console.Write(category);
        }
        public void SetAuthor(string author)
        {
            Console.Write(author);
        }
        public void SetreleaseDate(int day ,int month ,int year)
        {
            Console.Write("day" + "month" + "year");
        }












    }

}
