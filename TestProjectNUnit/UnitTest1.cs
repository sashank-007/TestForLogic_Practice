using NUnit.Framework;

namespace TestProjectNUnit;

public class Tests
{
    private Author author1 = new Author(randomAlphabetic(8), randomAlphabetic(10));
    private Author author2 = new Author(randomAlphabetic(8), randomAlphabetic(10));
    private Author author3 = new Author(randomAlphabetic(8), randomAlphabetic(10));
    private Author author4 = new Author(randomAlphabetic(8), randomAlphabetic(10));
    private Author author5 = new Author(randomAlphabetic(8), randomAlphabetic(10));
    private Author author6 = new Author(randomAlphabetic(8), randomAlphabetic(10));
    private Book book1 = new Book(author1, randomAlphabetic(15), randomAlphabetic(10), HORROR, 5);
    private Book book2 = new Book(author1, randomAlphabetic(15), randomAlphabetic(10), HORROR, 4);
    private Book book3 = new Book(author2, randomAlphabetic(15), randomAlphabetic(10), HORROR, 3);
    private Book book4 = new Book(author3, randomAlphabetic(15), randomAlphabetic(10), ROMANTIC, 5);
    private Book book5 = new Book(author4, randomAlphabetic(15), randomAlphabetic(10), HORROR, 5);
    private Book book6 = new Book(author5, randomAlphabetic(15), randomAlphabetic(10), DRAMA, 5);
    private Book book7 = new Book(author1, randomAlphabetic(15), randomAlphabetic(10), HORROR, 3);
    private Book book8 = new Book(author1, randomAlphabetic(15), randomAlphabetic(10), FICTION, 4);
    private Book book9 = new Book(author1, randomAlphabetic(15), randomAlphabetic(10), HORROR, 4);
    private Book book10 = new Book(author6, randomAlphabetic(15), randomAlphabetic(10), FICTION, 4);
    private int randomAge1 = nextInt(0, 120);
    private int randomAge2 = nextInt(0, 120);
    private Reader reader1 = new Reader(randomAge1);
    private Reader reader2 = new Reader(randomAge1);
    private Reader reader3 = new Reader(randomAge2);
    private BookSuggestionService suggestionService;
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}