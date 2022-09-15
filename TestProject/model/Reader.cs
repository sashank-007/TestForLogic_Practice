namespace TestProject.model;

public class Reader
{
    public HashSet<Book> FavouriteBooks { get; }
    public HashSet<Genre> FavouriteGenres { get; }
    public int Age { get; private set; }

    public Reader(int age)
    {
        Age = age;
        FavouriteBooks = new HashSet<Book>();
        FavouriteGenres = new HashSet<Genre>();
    }

    protected bool Equals(Reader other)
    {
        return FavouriteBooks.Equals(other.FavouriteBooks) && FavouriteGenres.Equals(other.FavouriteGenres) &&
               Age == other.Age;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Reader) obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FavouriteBooks, FavouriteGenres, Age);
    }

    public void AddToFavourites(Genre horror)
    {
        this.FavouriteGenres.Add(horror);
    }
    
    public void AddToFavourites(Book book)
    {
        this.FavouriteBooks.Add(book);
    }
}