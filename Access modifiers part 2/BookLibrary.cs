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
        public BookLibrary(string name)
        {
            Name = name;
            //name of library

        }
        public void Add(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }
        public void Remove(string book)
        {
            int j = 0;
            for (int k = 0; k < _books.Length; k++)
            {
                if (_books[k].Name == book)
                {

                    Book[] _newBooks = new Book[_books.Length - 1];

                    for (int i = 0; i < _books.Length; i++)
                    {
                        if (_books[i].Name != book)
                        {
                            _newBooks[j] = _books[i];
                            j++;
                        }
                    }
                    _books = _newBooks;
                    Console.WriteLine($"The book {book} has been removed from our list.");
                    break;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("We cant remove book, that doesnt even exist");
            }

        }
        public void ShowAll()
        {
            Console.WriteLine($"It is all books of {Name} library:`");
            for (int i = 0; i < _books.Length; i++)
            {
                Console.WriteLine(_books[i].Name);
            }


        }
        public void BorrowBook(string book)
        {
            bool bookExist = false;

            for (int i = 0; i < _books.Length; i++)
            {

                if (_books[i].IsAvailable == true && _books[i].Name == book)
                {
                    Console.WriteLine($"We have this book {book}, take it and dont forget to return it");
                    _books[i].IsAvailable = false;
                    bookExist = true;
                    break;
                }
                else if (_books[i].Name == book)
                {
                    Console.WriteLine("Sorry book was already taken, please check later");
                    bookExist = true;
                }

            }
            if (!bookExist)
            {
                Console.WriteLine("This book is unknown for our liblary, we never had it");
            }


        }
        public void ReturnBook(string book)
        {
            bool bookExist = false;

            for (int i = 0; i < _books.Length; i++)
            {

                if (_books[i].IsAvailable == true && _books[i].Name == book)
                {
                    Console.WriteLine($"The book {book}, is already in our library, you didnt take it from our labrary");
                    bookExist = true;
                    break;
                }
                else if (_books[i].Name == book)
                {
                    Console.WriteLine($"The book {book} returned succesufully,thanks");
                    bookExist = true;
                    _books[i].IsAvailable = true;
                }

            }
            if (!bookExist)
            {
                Console.WriteLine("This book is unknown for our liblary, we never had it");
            }


        }
        public void SearchByAuthor(string name)
        {
            bool authorFound = false;
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Author == name)
                {
                    Console.WriteLine(_books[i].Name);
                    authorFound = true;
                }
            }
            if (!authorFound)
            {
                Console.WriteLine($"We dont have books of {name} in our library");
            }
        }
    }
}
