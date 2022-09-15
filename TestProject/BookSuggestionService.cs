using TestProject.model;

namespace TestProject;

public class BookSuggestionService
{
    private readonly HashSet<Book> _books;
    private readonly HashSet<Reader> _readers;


    public BookSuggestionService(HashSet<Book> books, HashSet<Reader> readers)
    {
        _books = books;
        _readers = readers;
    }
    
    /*
     The method `Set<String> suggestBooks(Reader reader, int rating)` should return titles of all the  books that meet all the following criteria:
   1. Have exactly the rating specified in the method argument
   2. Belong to one of the reader's favourite genres
   3. Belong to favourite books' list of at least one different reader of the same age
     */

    public HashSet<string> SuggestBooks(Reader reader)
    {
        throw new NotImplementedException();
    }

    /*
     The method `Set<String> suggestBooks(Reader reader, int rating)` should return titles of all the  books that meet all the following criteria:
   1. Have exactly the rating specified in the method argument
   2. Belong to one of the reader's favourite genres
   3. Belong to favourite books' list of at least one different reader of the same age
     */
    public HashSet<String> SuggestBooks(Reader reader, int rating)
    {
        throw new NotImplementedException();
    }

    /*
     *  The method `Set<String> suggestBooks(Reader reader, Author author)` should return titles of all the  books that meet all the following criteria:
  1. Have a rating of four or higher
  2. Belong to one of the reader's favourite genres
  3. Belong to favourite books' list of at least one different reader of the same age
  4. Have been written by the author specified in the method argument
     */
    
    public HashSet<String> SuggestBooks(
        Reader reader,
        Author author)
    {
        throw new NotImplementedException();
    }
}