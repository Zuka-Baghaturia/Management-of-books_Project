using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_of_books_Project.BookProgram
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _releaseYear;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set { _releaseYear = value; }
        }

        public Book(string title, string author, int releaseYear)
        {
            _title = title;
            _author = author;
            _releaseYear = releaseYear;
        }
    }
}

