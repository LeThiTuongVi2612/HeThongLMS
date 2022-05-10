using Ardalis.Specification;
using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Core.Specifications.InstructorSpec
{
    public class UserNameExistedSpecification : Specification<User>
    {
        public UserNameExistedSpecification(string username)
        {
            Query.Where(item => item.UserName.Equals(username));
        }

    }
}
