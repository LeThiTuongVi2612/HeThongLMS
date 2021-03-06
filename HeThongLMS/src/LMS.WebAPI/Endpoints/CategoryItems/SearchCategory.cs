using Ardalis.ApiEndpoints;
using LMS.Core.Entities;
using LMS.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LMS.WebAPI.Endpoints.CategoryItems
{
    public class SearchCategory : BaseAsyncEndpoint
    {
        private readonly ICategoryService _categoryService;

        public SearchCategory(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("/searchCategory")]
        [SwaggerOperation(
            Summary = "Gets a list of Search Category",
            Description = "Gets a list of Search Category",
            OperationId = "Category.ListSearch",
            Tags = new[] { "CategoryEndpoints" })
        ]
        public  async Task<ActionResult<List<CategoryResponse>>> HandleAsync(string search)
        {
            var items = (await _categoryService.GetAllIncompleteItemsAsync(search))
                .Select(item => new CategoryResponse
                {
                    Name = item.Name,
                    Status = item.Status
                });

            return Ok(items);
        }

    }
}
