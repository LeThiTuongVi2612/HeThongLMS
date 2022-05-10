using Ardalis.Result;
using LMS.Core.Entities;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LMS.Core.Interfaces
{
    public interface ISubCategoryService
    {
        Task<List<SubCategory>> GetAllSubCategory();
        Task<SubCategory> GetSubCategoryById(Guid id);
        Task<SubCategory> CreateSubCategory(SubCategory subCategory);
        Task<SubCategory> DeleteSubCategory(SubCategory subCategory);
        Task<SubCategory> UpdateSubCategory(SubCategory subCategory);
        Task<SubCategory> GetNextIncompleteItemAsync();
        Task<List<SubCategory>> GetAllIncompleteItemsAsync(string searchString);
        Task<bool> IsSubCategoryNameExisted(string catename);
    }
}
