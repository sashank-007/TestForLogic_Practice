package com.test.services;

import java.util.HashSet;
import java.util.Set;

import com.test.model.Author;
import com.test.model.Book;
import com.test.model.Genre;
import com.test.model.Reader;

class BookSuggestionService {

	private final Set<Book> books;
	private final Set<Reader> readers;

	public BookSuggestionService(Set<Book> books, Set<Reader> readers) {
		this.books = books;
		this.readers = readers;
	}

	/*
	The method `Set<String> suggestBooks(Reader reader)` should return titles of all the  books that meet all the following criteria:
 1. Have a rating of four or higher
 2. Belong to one of the reader's favourite genres
 3. Belong to favourite books' list of at least one different reader of the same age
	 */
	Set<String> suggestBooks(Reader reader) {
		if (reader != null) {
			Set<Book> fourPlusRatedFavGenreBooks = new HashSet<>();
			Set<Genre> favGenres = reader.getFavouriteGenres();
			Set<String> bookSuggest = new HashSet<>();
			int readerAge = reader.getAge();

			for (Book book : books) {
				System.out.println("book.getRating() = " + book.getRating());
				if (book.getRating() >= 4 && favGenres.contains(book.getGenre())) {
					fourPlusRatedFavGenreBooks.add(book);
				}
			}

			System.out.println("readerAge = " + readerAge);
			for (Reader otherReader : readers) {
				System.out.println("otherReader.getAge() = " + otherReader.getAge());
				if (readerAge == otherReader.getAge() && !otherReader.getFavouriteBooks().isEmpty()) {
					for (Book favBooks : fourPlusRatedFavGenreBooks) {
						if (otherReader.getFavouriteBooks().contains(favBooks)) {
							bookSuggest.add(favBooks.getTitle());
							System.out.println("favBooks.getTitle() = " + favBooks.getTitle());
						}
					}
				}
			}
			return bookSuggest;
		} else {
			throw new UnsupportedOperationException("Please, implement me");
		}
	}




	/*
	 The method `Set<String> suggestBooks(Reader reader, int rating)` should return titles of all the  books that meet all the following criteria:
   1. Have exactly the rating specified in the method argument
   2. Belong to one of the reader's favourite genres
   3. Belong to favourite books' list of at least one different reader of the same age
	 */



	Set<String> suggestBooks(Reader reader, int rating) {
		if (rating > 5 || rating < 1) {
			throw new IllegalArgumentException();
		}
		if (reader != null) {
			Set<Book> fourPlusRatedFavGenreBooks = new HashSet<>();
			Set<Genre> favGenres = reader.getFavouriteGenres();
			Set<String> bookSuggest = new HashSet<>();
			int readerAge = reader.getAge();

			for (Book book : books) {
				System.out.println("book.getRating() = " + book.getRating());
				if (book.getRating() == rating && favGenres.contains(book.getGenre())) {
					fourPlusRatedFavGenreBooks.add(book);
					System.out.println("book.getTitle() = " + book.getTitle());
				}
			}

			System.out.println("readerAge = " + readerAge);
			for (Reader otherReader : readers) {
				System.out.println("otherReader.getAge() = " + otherReader.getAge());
				if (readerAge == otherReader.getAge() && !otherReader.getFavouriteBooks().isEmpty()) {
					for (Book favBooks : fourPlusRatedFavGenreBooks) {
						if (otherReader.getFavouriteBooks().contains(favBooks)) {
							bookSuggest.add(favBooks.getTitle());
							System.out.println("favBooks.getTitle() = " + favBooks.getTitle());
						}
					}
				}
			}
			return bookSuggest;
		} else {
			throw new UnsupportedOperationException("Please, implement me");
		}
	}

		/*
	 The method `Set<String> suggestBooks(Reader reader, Author author)` should return titles of all the  books that meet all the following criteria:
  1. Have a rating of four or higher
  2. Belong to one of the reader's favourite genres
  3. Belong to favourite books' list of at least one different reader of the same age
  4. Have been written by the author specified in the method argument
	 */


	Set<String> suggestBooks(Reader reader, Author author) {
		if (reader != null && author != null) {
			Set<Book> fourPlusRatedFavGenreAuthorBooks = new HashSet<>();
			Set<Genre> favGenres = reader.getFavouriteGenres();
			Set<String> bookSuggest = new HashSet<>();
			int readerAge = reader.getAge();

			System.out.println("author = " + author.getFirstName()+" "+author.getLastName());

			for (Book book : books) {
				System.out.println("book.getRating() = " + book.getRating());
				if (book.getRating() >= 4 && book.getAuthor().equals(author) && favGenres.contains(book.getGenre())) {
					fourPlusRatedFavGenreAuthorBooks.add(book);
				}
			}

			System.out.println("readerAge = " + readerAge);
			for (Reader otherReader : readers) {
				System.out.println("otherReader.getAge() = " + otherReader.getAge());
				if (readerAge == otherReader.getAge() && !otherReader.getFavouriteBooks().isEmpty()) {
					for (Book favBooks : fourPlusRatedFavGenreAuthorBooks) {
						if (otherReader.getFavouriteBooks().contains(favBooks)) {
							bookSuggest.add(favBooks.getTitle());
							System.out.println("favBooks.getTitle() = " + favBooks.getTitle());
						}
					}
				}
			}
			return bookSuggest;
		} else {
			throw new UnsupportedOperationException("Please, implement me");
		}
	}

}
