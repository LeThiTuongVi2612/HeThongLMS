using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WebAPI.ApiModels.InstructorItemDTO
{
    public class UploadAvatarRequest
    {
        public Guid Id { get; set; }
        public IFormFile file { get; set; }
    }
}
