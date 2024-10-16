namespace Access_modifiers_part_2
{
    internal class BookLibrary
    {
        public Book[] _books = new Book[0];
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public BookLibrary()
        {

        }
        public void Add(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }
        public void Remove(Book book)
        {
            int j = 0;

            Book[] _newBooks = new Book[_books.Length - 1];
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Name != book.Name)
                {
                    _newBooks[j] = _books[i];
                    j++;
                }
            }
            _books = _newBooks;

        }
        public void ShowAll()
        {
            for (int i = 0; i < _books.Length; i++)
            {
                Console.WriteLine(_books[i].Name);
            }

        }
    }
}
