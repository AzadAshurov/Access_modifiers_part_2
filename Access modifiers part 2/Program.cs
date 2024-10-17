namespace Access_modifiers_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Robinson Crusoe", "Defo", true);
            Book book2 = new Book("Berserk", "Kentaro Miuro", true);
            Book book3 = new Book("3 pigs", "Li Prist", true);
            Book book4 = new Book("a", "L", true);
            Book book5 = new Book("Roxana", "Defo", true);


            BookLibrary library = new BookLibrary("BDU kitabxana");


            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);
            library.Add(book5);
            library.ShowAll();
            library.Remove("3 pigs");
            library.ShowAll();
            library.ReturnBook("Berserk");
            library.BorrowBook("Berserk");
            library.BorrowBook("Berserk");
            library.ReturnBook("Berserk");
            library.ReturnBook("Berghrthrthserk");
            library.SearchByAuthor("Azad");
            library.SearchByAuthor("Defo");








        }
    }
}
