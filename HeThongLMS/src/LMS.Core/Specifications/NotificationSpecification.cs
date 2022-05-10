using Ardalis.Specification;
using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Core.Specifications
{
    class NotificationSpecification : Specification<Notification>
    {
        public NotificationSpecification(Guid id)
        {
            Query.Where(item =>item.IsDeleted.Equals(false) && item.UserId.Equals(id));
        }
    }
}
