using Ardalis.ApiEndpoints;
using LMS.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LMS.WebAPI.Endpoints.Courses
{
    public class GiveForReview : BaseAsyncEndpoint
    {
        private readonly ICourseService _courseService;

        public GiveForReview(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPut("/Courses/Review")]
        [SwaggerOperation(
            Summary = "Updates a Course",
            Description = "Updates a Course with status as blocked or last status",
            OperationId = "Course.GiveForReview",
            Tags = new[] { "CourseEndpoints" })
        ]
        public async Task<bool> HandleAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _courseService.GiveForReview(id);
        }
    }
}
