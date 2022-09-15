using System;
using System.Collections.Generic;
using NUnit.Framework;
using TestProject;
using TestProject.model;

namespace Tests;

public class BookSuggestionServiceTests
{
    private Author Author1;
    private Author Author2;
    private Author Author3;
    private Author Author4;
    private Author Author5;
    private Author Author6;
    private Book Book1;
    private Book Book2;
    private Book Book3;
    private Book Book4;
    private Book Book5;
    private Book Book6;
    private Book Book7;
    private Book Book8;
    private Book Book9;
    private Book Book10;
    private int RandomAge1;
    private int RandomAge2;
    private Reader Reader1;
    private Reader Reader2;
    private Reader Reader3;
    private BookSuggestionService SuggestionService;

    public BookSuggestionServiceTests()
    {
        Author1 = new Author(RandomAlphabetic(8), RandomAlphabetic(10));
        Author2 = new Author(RandomAlphabetic(8), RandomAlphabetic(10));
        Author3 = new Author(RandomAlphabetic(8), RandomAlphabetic(10));
        Author4 = new Author(RandomAlphabetic(8), RandomAlphabetic(10));
        Author5 = new Author(RandomAlphabetic(8), RandomAlphabetic(10));
        Author6 = new Author(RandomAlphabetic(8), RandomAlphabetic(10));
        Book1 = new Book(Author1, RandomAlphabetic(15), RandomAlphabetic(10), Genre.HORROR, 5);
        Book2 = new Book(Author1, RandomAlphabetic(15), RandomAlphabetic(10), Genre.HORROR, 4);
        Book3 = new Book(Author2, RandomAlphabetic(15), RandomAlphabetic(10), Genre.HORROR, 3);
        Book4 = new Book(Author3, RandomAlphabetic(15), RandomAlphabetic(10), Genre.ROMANTIC, 5);
        Book5 = new Book(Author4, RandomAlphabetic(15), RandomAlphabetic(10), Genre.HORROR, 5);
        Book6 = new Book(Author5, RandomAlphabetic(15), RandomAlphabetic(10), Genre.DRAMA, 5);
        Book7 = new Book(Author1, RandomAlphabetic(15), RandomAlphabetic(10), Genre.HORROR, 3);
        Book8 = new Book(Author1, RandomAlphabetic(15), RandomAlphabetic(10), Genre.FICTION, 4);
        Book9 = new Book(Author1, RandomAlphabetic(15), RandomAlphabetic(10), Genre.HORROR, 4);
        Book10 = new Book(Author6, RandomAlphabetic(15), RandomAlphabetic(10), Genre.FICTION, 4);
        Reader1 = new Reader(RandomAge1);
        RandomAge2 = NextInt(0, 120);
        RandomAge1 = NextInt(0, 120);
        Reader2 = new Reader(RandomAge1);
        Reader3 = new Reader(RandomAge2);
    }

    public  int NextInt(int startInclusive, int endExclusive)
    {
        return startInclusive == endExclusive
            ? startInclusive
            : startInclusive + new Random().Next(endExclusive - startInclusive);
    }


    private string RandomAlphabetic(int num)
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var stringChars = new char[num];
        var random = new Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        return new String(stringChars);
    }

    [SetUp]
    public void Setup()
    {
        Reader1.AddToFavourites(Genre.HORROR);
        Reader1.AddToFavourites(Genre.ROMANTIC);
        Reader2.AddToFavourites(Book2);
        Reader2.AddToFavourites(Book1);
        Reader2.AddToFavourites(Book3);
        Reader2.AddToFavourites(Book4);
        Reader2.AddToFavourites(Book7);
        Reader2.AddToFavourites(Book8);
        Reader2.AddToFavourites(Book10);
        Reader3.AddToFavourites(Book5);
        var books = new HashSet<Book>() {Book1, Book2, Book3, Book4, Book5, Book6, Book7, Book8, Book9, Book10};
        var readers = new HashSet<Reader>() {Reader1, Reader2, Reader3};
        this.SuggestionService = new BookSuggestionService(books, readers);
    }


    [Test]
    public void ShouldSuggestBookTitlesWithCorrectRating()
    {
        // when:
        HashSet<String> suggestedBooks = SuggestionService.SuggestBooks(Reader1, 4);

        // then:
        Assert.Equals(suggestedBooks, new HashSet<string>()
        {
            Book2.Title
        });
    }

    [Test]
    public void ShouldSuggestBookTitlesWithDefaultRatingOfFourOrHigher()
    {
        // when:
        HashSet<string> suggestedBooks = SuggestionService.SuggestBooks(Reader1);

        // then:
        Assert.Equals(suggestedBooks, new HashSet<string>()
        {
            Book1.Title, Book2.Title,
            Book4.Title
        });
    }

    [Test]
    public void shouldOnlySuggestBookTitlesOfGivenAuthor()
    {
        // when:
        HashSet<string> suggestedBooks = SuggestionService.SuggestBooks(Reader1, Author1);

        // then:
        Assert.Equals(suggestedBooks, new HashSet<string>() {Book1.Title, Book2.Title});
    }
}