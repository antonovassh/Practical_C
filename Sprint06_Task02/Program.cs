using System.Reflection.Metadata;

//Please, implement class Library with public property Books of generic IEnumerable type that can be set only inside the class,

//    and public property Filter(generic predicate) that sets a condition on book. The default value of Filter: any book satisfies the condition.

//    The constructor of Library class takes 1 parameter for initialization Books property.

//    Implement GetEnumerator method that will allow to enumerate by only those books that satisfy the condition in Filter.

//    Do not use yields in this task.

//    Create  MyEnumerator class that implements IEnumerator<Book>.

//    The constructor of MyEnumerator takes 2 parameters: for initialization books and filter.

//    Implement all the necessary methods and properties in MyEnumerator.



//    Implement MyUtils class with public static method GetFiltered that takes generics IEnumerable and Predicate and returns list of filtered books using Library class and its enumerator.
public class Library
{
    public IEnumerable<Book> Books { get; }
    public Predicate<Book> Filter { get; set; } = book => true;

    public Library(IEnumerable<Book> books)
    {
        Books = books;
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new MyEnumerator(Books, Filter);
    }
}

public sealed class MyEnumerator : IEnumerator<Book>
{
    private readonly IEnumerable<Book> _books;
    private readonly Predicate<Book> _filter;
    private IEnumerator<Book> _enumerator;

    public MyEnumerator(IEnumerable<Book> books, Predicate<Book> filter)
    {
        _books = books;
        _filter = filter;
        _enumerator = _books.GetEnumerator();
    }

    public Book Current => _enumerator.Current;


    object System.Collections.IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public void Dispose()
    {
        _enumerator.Dispose();
    }

    public bool MoveNext()
    {
        while (_enumerator.MoveNext())
        {
            if (_filter(_enumerator.Current))
                return true;
        }
        return false;
    }

    public void Reset()
    {
        _enumerator.Dispose();
        _enumerator = _books.GetEnumerator();
    }
}

public class MyUtils
{
    public static List<Book> GetFiltered(IEnumerable<Book> books, Predicate<Book> filter)
    {
        var filteredBooks = new List<Book>();
        using (var enumerator = new MyEnumerator(books, filter))
        {
            while (enumerator.MoveNext())
            {
                filteredBooks.Add(enumerator.Current);
            }
        }
        return filteredBooks;
    }
}