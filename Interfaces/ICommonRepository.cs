using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library1C.Interfaces
{
    public interface ICommonRepository<T>
    {
        Task<T> Get(string key);
        Task<T> Get(Guid key);

        Task<IEnumerable<T>> GetList();
    }
}
