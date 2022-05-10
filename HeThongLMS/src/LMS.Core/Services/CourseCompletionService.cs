using Ardalis.Result;
using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Core.Mapper.CourseCompletionModel;
using LMS.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public class CourseCompletionService : ICourseCompletionService
    {
        private readonly ICourseCompletionRepository _courseCompletionRepository;
        public CourseCompletionService(ICourseCompletionRepository courseCompletionRepository)
        {
            _courseCompletionRepository = courseCompletionRepository;
        }

        public async Task<Result<bool>> CreateCourseCompletion(Guid userId, Guid courseId)
        {
         
            try
            {
                var model = new CourseCompletion();
                model.UserId = userId;
                model.CourseId = courseId;
                model.CompleteDate = DateTime.UtcNow;
                var item = await _courseCompletionRepository.AddCourseCompletionAsync<CourseCompletion>(model);

                if (item == null)
                {
                    return Result<bool>.Error(new[] { "Error. Can't create view" });
                }
              
                return new Result<bool>(true);
            }
            catch (Exception ex)
            {
                return Result<bool>.Error(new[] { ex.Message });
            }
        }
    }
}
