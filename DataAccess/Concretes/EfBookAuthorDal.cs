﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes
{
    public class EfBookAuthorDal : EfRepositoryBase<BookAuthor, LibraryAPIDbContext>, IBookAuthorDal
    {
        public EfBookAuthorDal(LibraryAPIDbContext context) : base(context)
        {
        }
    }
}
