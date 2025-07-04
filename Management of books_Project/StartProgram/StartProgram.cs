using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::Management_of_books_Project.BManagerProgram;
using Management_of_books_Project.PName;

namespace Management_of_books_Project.StartProgram
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();
            ProgramName ProgName = new ProgramName();

            while (true)
            {
                ProgName.PName();

                manager.ChooseMethod();

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}


// exception [yes], exception class [yes], abstract class [yes], Inheritance [yes], threading[yes]