namespace CompisitionLabColtonGarrett
{
    public class book
    {
        private string isbn;
        private string title;
        public author author;

        public book(string isbn, string title, author author)
        {
            this.isbn=isbn;
            this.title=title;
            this.author=author;
        }

        public string Getisbn()
        {
            return isbn;
        }

        public string GetTitle()
        {
            return title;
        }

        public author GetAuthor()
        {
            return author;
        }

        public void Setisbn(string isbn)
        {
            this.isbn=isbn;
        }

        public void SetTitle(string title)
        {
            this.title=title;
        }

        public void SetAuthor(author author)
        {
            this.author=author;
        }

        public string ToString(string isbn, string title, author author)
        {
            string combined=isbn+title+author;
            return combined;
        }
    }
}