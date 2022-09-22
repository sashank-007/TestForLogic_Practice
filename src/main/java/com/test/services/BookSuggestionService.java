package com.test.services;

import java.util.Set;

import com.test.model.Author;
import com.test.model.Book;
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
		throw new UnsupportedOperationException("Please, implement me");
	}




	/*
	 The method `Set<String> suggestBooks(Reader reader, int rating)` should return titles of all the  books that meet all the following criteria:
   1. Have exactly the rating specified in the method argument
   2. Belong to one of the reader's favourite genres
   3. Belong to favourite books' list of at least one different reader of the same age
	 */



	Set<String> suggestBooks(Reader reader, int rating) {
		throw new UnsupportedOperationException("Please, implement me");
	}

		/*
	 The method `Set<String> suggestBooks(Reader reader, Author author)` should return titles of all the  books that meet all the following criteria:
  1. Have a rating of four or higher
  2. Belong to one of the reader's favourite genres
  3. Belong to favourite books' list of at least one different reader of the same age
  4. Have been written by the author specified in the method argument
	 */


	Set<String> suggestBooks(Reader reader, Author author) {
		throw new UnsupportedOperationException("Please, implement me");
	}

}
