using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Management_of_books_Project.BookProgram;
using Management_of_books_Project.Exeptions;
using Management_of_books_Project.Interfaces;
using Management_of_books_Project.PName;

namespace Management_of_books_Project.BManagerProgram
{
    public class BookManager : IInterface
    {
        private List<Book> bookList = new List<Book>
        {
            new Book("1984", "George Orwell", 1949),
            new Book("To Kill a Mockingbird", "Harper Lee", 1960),
            new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925),
            new Book("Pride and Prejudice", "Jane Austen", 1813),
            new Book("The Catcher in the Rye", "J.D. Salinger", 1951),
            new Book("Moby-Dick", "Herman Melville", 1851),
            new Book("War and Peace", "Leo Tolstoy", 1869),
            new Book("The Hobbit", "J.R.R. Tolkien", 1937),
            new Book("Crime and Punishment", "Fyodor Dostoevsky", 1866),
            new Book("Brave New World", "Aldous Huxley", 1932),
            new Book("Jane Eyre", "Charlotte Brontë", 1847),
            new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954),
            new Book("Fahrenheit 451", "Ray Bradbury", 1953),
            new Book("Animal Farm", "George Orwell", 1945),
            new Book("Wuthering Heights", "Emily Brontë", 1847),
            new Book("The Brothers Karamazov", "Fyodor Dostoevsky", 1880),
            new Book("Les Misérables", "Victor Hugo", 1862),
            new Book("The Alchemist", "Paulo Coelho", 1988),
            new Book("The Stranger", "Albert Camus", 1942),
            new Book("The Picture of Dorian Gray", "Oscar Wilde", 1890),
            new Book("Don Quixote", "Miguel de Cervantes", 1605),
            new Book("The Divine Comedy", "Dante Alighieri", 1320),
            new Book("One Hundred Years of Solitude", "Gabriel García Márquez", 1967),
            new Book("The Sound and the Fury", "William Faulkner", 1929),
            new Book("The Trial", "Franz Kafka", 1925),
            new Book("A Passage to India", "E.M. Forster", 1924),
            new Book("The Sun Also Rises", "Ernest Hemingway", 1926),
            new Book("Madame Bovary", "Gustave Flaubert", 1856),
            new Book("Ulysses", "James Joyce", 1922),
            new Book("The Count of Monte Cristo", "Alexandre Dumas", 1844),
            new Book("Things Fall Apart", "Chinua Achebe", 1958),
            new Book("The Grapes of Wrath", "John Steinbeck", 1939),
            new Book("Slaughterhouse-Five", "Kurt Vonnegut", 1969),
            new Book("A Tale of Two Cities", "Charles Dickens", 1859),
            new Book("Invisible Man", "Ralph Ellison", 1952),
            new Book("Beloved", "Toni Morrison", 1987),
            new Book("Rebecca", "Daphne du Maurier", 1938),
            new Book("Heart of Darkness", "Joseph Conrad", 1899),
            new Book("The Bell Jar", "Sylvia Plath", 1963),
            new Book("A Clockwork Orange", "Anthony Burgess", 1962)
        };

        public virtual void PName() { }


        public void ChooseMethod()
        {
            Console.WriteLine("Enter method name (Add / Show / Search):");
            string answer = Console.ReadLine() ?? string.Empty;

            if (answer.Equals("Add", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter title:");
                string title = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Enter author:");
                string author = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Enter year:");
                int releaseYear = int.Parse(Console.ReadLine());

                AddBook(title, author, releaseYear);
            }
            else if (answer.Equals("Show", StringComparison.OrdinalIgnoreCase))
            {
                ShowBooks();
            }
            else if (answer.Equals("Search", StringComparison.OrdinalIgnoreCase))
            {
                SearchBooks();
            }
            else
            {
                Console.WriteLine($"{Exeption.ArgumentException} Invalid method. Please enter (Add / Show / Search)");
            }
        }

        public void AddBook(string title, string author, int releaseYear)
        {
            bookList.Add(new Book(title, author, releaseYear));
            Console.WriteLine("Book added successfully.");
        }

        public void ShowBooks()
        {
            foreach (var book in bookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.ReleaseYear}");
                Thread.Sleep(40);
            }
        }

        public void SearchBooks()
        {
            Console.WriteLine("Enter a title to search: ");
            string searchTitle = Console.ReadLine() ?? string.Empty;

            var foundBooks = bookList
                .Where(book => book.Title.IndexOf(searchTitle, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (foundBooks.Count == 0)
            {
                Console.WriteLine($"{Exeption.ArgumentException}" + " Book not found!");
            }
            else
            {
                Console.WriteLine($"Found books with title '{searchTitle}':");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.ReleaseYear}");
                }
            }
        }

    }
}

