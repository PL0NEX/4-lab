using lab4;

class Program
{
    static void Main()
    {
        List<Book> library = new List<Book>
        {
            new Book {Title = "Война и мир",Pagecount = 1507 },
            new Book {Title = "Герой нашего времени",Pagecount = 224},
            new Book {Title = "Преступление и наказание",Pagecount = 672},
            new Book {Title = "Отцы м дети",Pagecount = 288},
            new Book {Title = "Мёртвые души",Pagecount = 352}
        };

        try
        {
            if (library == null)
            {
                Console.WriteLine("Библиотека не была инициализирована");
                return;
            }

            if (!library.Any())
            {
                Console.WriteLine("Библиотека пуста");
                return;
            }


            var filteredBooksLinq = from book in library
                                    where book.Pagecount > 20
                                    orderby book.Title
                                    select book;

            Console.WriteLine("Книги с более чем 20 страницами:");
            foreach (var book in filteredBooksLinq)
            {
                Console.WriteLine($"{book.Title} - {book.Pagecount} страниц");
            }

            Console.WriteLine();


            var filteredBooksMethod = library.Where(b => b.Pagecount > 20).OrderBy(b => b.Title);

            Console.WriteLine("Книги с более чем 20 страницами:");
            foreach (var book in filteredBooksMethod)
            {
                Console.WriteLine($"{book.Title} - {book.Pagecount} страниц");
            }
        }
        catch (Exception ex) { Console.WriteLine($"Произошла ошибка: {ex.Message}"); }
    }
}