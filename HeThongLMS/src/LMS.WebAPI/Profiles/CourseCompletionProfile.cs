using AutoMapper;
using LMS.Core.Entities;
using LMS.Core.Mapper.CourseCompletionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WebAPI.Profiles
{  
    public class CourseCompletionProfile : Profile
    {
        public CourseCompletionProfile()
        {
            //create map create coursecompletion
            CreateMap<CourseCompletion, CreateCourseCompletionRequest>();
            CreateMap<CreateCourseCompletionRequest, CourseCompletion>();

        }
    }
}
