using Ardalis.Specification;
using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Core.Specifications
{
    class PayoutIncompleteItemsSpecification : Specification<OrderDetail>
    {
        //Get All OrderDetail's instructor by month
        public PayoutIncompleteItemsSpecification(int month, Guid id)
        {
            Query.Where(e => e.PurchasedDay.Month == month && e.Course.UserId == id).Include(x => x.Course).ThenInclude(x => x.Promotion);
        }
    }
}
