using System.Collections.Generic;
using System.Threading.Tasks;
using Interbase_connection.Models;

namespace Interbase_connection.Data
{
    public interface IRepository
    {
        Task<List<WorkRequest>> GetAllWorkrequest();
    }
}