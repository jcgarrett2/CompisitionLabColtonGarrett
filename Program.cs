using System;

namespace CompisitionLabColtonGarrett
{
    class Program
    {
        static void Main(string[] args)
        {
            author myauthor = new author("Jeff Lucas","jslucas@cba.ua.edu",'m');
            Console.WriteLine(myauthor.ToString());

            book mybook = new book("12243", "My book, Your Book", myauthor);
            Console.WriteLine(mybook.ToString());

            Console.WriteLine(mybook.GetAuthor().ToString());

            book yourbook= new book("4321", "The Phantom Book", new author("Jamie Hillman", "jamie@mail.com", 'f'));
            Console.WriteLine(yourbook.ToString());

            yourbook.author.SetEmail(Console.ReadLine());
            Console.WriteLine(yourbook.ToString());
        }
    }
}
