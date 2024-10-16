namespace Access_modifiers_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Robinzon Kruzo", "Defo", false);
            Book book2 = new Book("Berserk", "Kentaro Miuro", false);
            Book book3 = new Book("3 pigs", "Li Prist", true);


            BookLibrary library = new BookLibrary();


            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.ShowAll();
            library.Remove(book1);
            library.ShowAll();







        }
    }
}
