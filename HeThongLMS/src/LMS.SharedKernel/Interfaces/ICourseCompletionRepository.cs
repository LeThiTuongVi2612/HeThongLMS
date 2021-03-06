using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LMS.SharedKernel.Interfaces
{
    public interface ICourseCompletionRepository: IRepository
    {
        Task<T> AddCourseCompletionAsync<T>(T entity) where T : class;
    }
}
