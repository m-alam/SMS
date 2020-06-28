using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Framework
{
    class StudentService : IStudentService, IDisposable
    {
        private ISMSUnitOfWork _smsUnitOfWork;
        public StudentService(ISMSUnitOfWork smsUnitOfWork)
        {
            _smsUnitOfWork = smsUnitOfWork;
        }

        public void CreateStudent(Student student)
        {
            //var count = _smsUnitOfWork.StudentRepository.GetCount(x => x.Title == book.Title);
            //if (count > 0)
            //throw new DuplicationException("Book Already exist", nameof(book.Title));

            _smsUnitOfWork.StudentRepository.Add(student);
            _smsUnitOfWork.Save();
        }
        //public Book DeleteBook(int id)
        //{
        //    var book = _libraryUnitOfWork.BookRepository.GetById(id);
        //    _libraryUnitOfWork.BookRepository.Remove(book);
        //    _libraryUnitOfWork.Save();
        //    return book;
        //}

        public void Dispose()
        {
            //_libraryUnitOfWork?.Dispose();
        }

        //public void EditBook(Book book)
        //{
        //    var count = _libraryUnitOfWork.BookRepository.GetCount(x => x.Title == book.Title
        //            && x.Id != book.Id);

        //    if (count > 0)
        //        throw new DuplicationException("Book title already exists", nameof(book.Title));

        //    var existingBook = _libraryUnitOfWork.BookRepository.GetById(book.Id);
        //    existingBook.Author = book.Author;
        //    existingBook.Edition = book.Edition;
        //    existingBook.PublicationDate = book.PublicationDate;
        //    existingBook.Title = book.Title;

        //    _libraryUnitOfWork.Save();
        //}

        public Student GetStudent(int id)
        {
            return _smsUnitOfWork.StudentRepository.GetById(id);
        }


        public (IList<Student> records, int total, int totalDisplay)
            GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _smsUnitOfWork.StudentRepository.GetAll().ToList();

            return (result, 0, 0);
        }
    }
}
