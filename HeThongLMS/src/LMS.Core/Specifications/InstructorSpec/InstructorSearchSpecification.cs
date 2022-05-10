using Ardalis.Specification;
using LMS.Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Core.Specifications.InstructorSpec
{
    public class InstructorSearchSpecification : Specification<User>
    {
        public InstructorSearchSpecification(string searchString)
        {        
            //JsonConvert.SerializeObject(Query).Contains(searchString);
            Query.Where(u => (u.Role.Name.Equals("Instructor") && u.Email.StartsWith(searchString))
                        || (u.Role.Name.Equals("Instructor") && u.FirstName.StartsWith(searchString))
                        || (u.Role.Name.Equals("Instructor") &&u.LastName.StartsWith(searchString))).Include(u => u.Role);
           
        }
    }
}
