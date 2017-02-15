using System;
using LibrarySystemLiveDemo.Data.Models;

namespace LibrarySystemLiveDemo.Services
{
    public interface IBookService
    {
        Book GetById(Guid? id);
    }
}