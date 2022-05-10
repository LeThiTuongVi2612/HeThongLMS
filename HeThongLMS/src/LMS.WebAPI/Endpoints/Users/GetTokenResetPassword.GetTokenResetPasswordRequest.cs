﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WebAPI.Endpoints.Users
{
    public class GetTokenResetPasswordRequest
    {
        [Required]
        public string Email { get; set; }
    }
}
