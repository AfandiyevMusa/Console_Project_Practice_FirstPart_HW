using System;
using DomainLayer.Entities;

namespace ServiceLayer.Services.Interfaces
{
	public interface ILibraryService
	{
        Library Create(Library name);
        Library Update(int id, Library library);
        void Delete(int id);
        Library GetById(int id);
        Library GetByName(string name);
        List<Library> GetAll();
    }
}

