using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WebAPI.Endpoints.CategoryItems
{
    public class ChangeDelToCategoryRequest
    {
        public Guid Id { get; set; }
        public bool IsDelete { get; set; }
    }
}
