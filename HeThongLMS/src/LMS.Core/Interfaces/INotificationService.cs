using LMS.Core.Entities;
using LMS.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Interfaces
{
    public interface INotificationService 
    {
        Task<Notification> CreateNotification(Notification notification);
        Task<List<Notification>> GetAllNotificationById(Guid userId);
        Task<Notification> GetNotificationById(Guid id);
        Task<Notification> ReadNotification(Notification notification);
    }
}
