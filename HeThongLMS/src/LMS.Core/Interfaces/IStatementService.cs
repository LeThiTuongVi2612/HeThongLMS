using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Interfaces
{
    public interface IStatementService
    {
        Task<List<OrderDetail>> GetAllByMonth(int month, Guid id);

        Task<OrderDetail> GetOrderById(Guid userId, Guid courseId);
    }
}
