﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WebAPI.Endpoints.Students
{
    public class StudentRequest
    {
        public Guid Id { get; set; }

        public bool IsStatus { get; set; }
    }
}
