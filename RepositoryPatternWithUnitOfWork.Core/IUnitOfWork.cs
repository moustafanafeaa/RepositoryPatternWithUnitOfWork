using RepositoryPatternWithUnitOfWork.Core.Interfaces;
using RepositoryPatternWithUnitOfWork.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUnitOfWork.Core
{
    public interface IUnitOfWork: IDisposable
    {
        //add all repository
        IBaseRepository<Author> Authors { get; }
        IBaseRepository<Book> Books { get; }

        //add method => needed to be in unitofwork(SaveChange)

        int Complete();

    }
}
