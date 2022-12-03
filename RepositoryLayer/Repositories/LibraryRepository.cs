using System;
using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class LibraryRepository : IRepository<Library>
    {
        public void Add(Library entity)
        {
            if (entity == null) throw new ArgumentNullException();
            AppDbContext<Library>.datas.Add(entity);
        }

        public void Delete(Library entity)
        {
            throw new NotImplementedException();
        }

        public Library Get(Predicate<Library> predicate)
        {
            return AppDbContext<Library>.datas.Find(predicate);
        }

        public List<Library> GetAll(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Library entity)
        {
            throw new NotImplementedException();
        }
    }
}

