using System;
using System.Collections.Generic;
using System.Text;

using CleanArchitecture.Application.ViewModels;

namespace Application.Interfaces
{
    public interface IBookService
    {
        BookViewModel GetBooks();
    }
}
