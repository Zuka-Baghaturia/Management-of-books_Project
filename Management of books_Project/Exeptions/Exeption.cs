using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_of_books_Project.BManagerProgram;
namespace Management_of_books_Project.Exeptions
{
    abstract public class Exeption : BookManager
    {
        static public void Exception()
        {
            throw new System.Exception("Something went wrong.");
        }

        static public void ArgumentException()
        {
            throw new System.ArgumentException("Invalid argument.");
        }

        static public void ArgumentNullException()
        {
            throw new System.ArgumentNullException("paramName", "Parameter cannot be null.");
        }

        static public void ArgumentOutOfRangeException()
        {
            throw new System.ArgumentOutOfRangeException("paramName", 999, "Value is out of range.");
        }

        static public void InvalidOperationException()
        {
            throw new System.InvalidOperationException("Operation is not valid in this state.");
        }

        static public void NullReferenceException()
        {
            throw new System.NullReferenceException("Object reference not set to an instance of an object.");
        }

        static public void IndexOutOfRangeException()
        {
            throw new System.IndexOutOfRangeException("Index is out of bounds.");
        }

        static public void KeyNotFoundException()
        {
            throw new System.Collections.Generic.KeyNotFoundException("Key not found in the dictionary.");
        }

        static public void IOException()
        {
            throw new System.IO.IOException("An I/O error occurred.");
        }

        static public void FileNotFoundException()
        {
            throw new System.IO.FileNotFoundException("The file was not found.");
        }

        static public void DirectoryNotFoundException()
        {
            throw new System.IO.DirectoryNotFoundException("The directory was not found.");
        }

        static public void FormatException()
        {
            throw new System.FormatException("Input string was not in a correct format.");
        }

        static public void OverflowException()
        {
            throw new System.OverflowException("Numeric overflow occurred.");
        }

        static public void InvalidCastException()
        {
            throw new System.InvalidCastException("Specified cast is not valid.");
        }
    }
}
