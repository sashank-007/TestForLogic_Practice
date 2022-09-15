namespace TestProject.model;

public class Book
{
    public Author Author { get; set; }

    public string Title { get; set; }

    public string Isbn { get; set; }

    public Genre Genre { get; set; }

    public int Rating { get; set; }

    public Book(Author author, string title, string isbn, Genre genre)
    {
        Author = author;
        Title = title;
        Isbn = isbn;
        Genre = genre;
    }

    public Book(Author author, string title, string isbn, Genre genre, int rating)
    {
        Author = author;
        Title = title;
        Isbn = isbn;
        Genre = genre;
        Rating = rating;
    }

    protected bool Equals(Book other)
    {
        return Author.Equals(other.Author) && Title == other.Title && Isbn == other.Isbn && Genre == other.Genre &&
               Rating == other.Rating;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Book) obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Author, Title, Isbn, (int) Genre, Rating);
    }
}