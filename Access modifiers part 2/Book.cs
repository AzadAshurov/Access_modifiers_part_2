namespace Access_modifiers_part_2
{
    internal class Book
    {
        public string _name;
        public string _author;
        public bool _isAvailable = true;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {

                if (value.Trim().Length > 1)
                {
                    _name = value.Trim();
                }
                else
                {
                    Console.WriteLine("Too short for name");
                }
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (value.Trim().Length > 1)
                {
                    _author = value.Trim();
                }
                else
                {
                    Console.WriteLine("Too short for author name");
                }
            }
        }
        public bool IsAvailable
        {
            get
            {
                return _isAvailable;
            }
            set
            {
                _isAvailable = value;
            }
        }
        public Book(string name, string author, bool isAvailable)
        {
            Name = name;
            Author = author;
            IsAvailable = isAvailable;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Available: {IsAvailable}");
        }

    }


}
