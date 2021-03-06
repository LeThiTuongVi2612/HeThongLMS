using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Interfaces
{
    public interface IEarningServices
    {
        Task<List<OrderDetail>> GetAllEarningAsync(int month, int year, Guid id);

        Task<List<OrderDetail>> GetEarningAsync(Guid id);

        Task<OrderDetail> GetByIdAsync(Guid id);
    }
}
