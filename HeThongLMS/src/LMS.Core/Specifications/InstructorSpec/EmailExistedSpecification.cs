using Ardalis.Specification;
using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Core.Specifications.InstructorSpec
{
    public class EmailExistedSpecification : Specification<User>
    {
        public EmailExistedSpecification(string email)
        {
            Query.Where(item => item.Email.Equals(email));
        }

    }
}
