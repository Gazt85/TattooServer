using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAppointmentRepository
    {
        Task<PagedList<AppointmentData>> GetAllApointmentsAsync(AppointmentParameters appointmentParameters,bool trackChanges);
        Task<AppointmentData> GetAppointmentAsync(Guid appointmentId, bool trackChanges);
        void CreateAppointment(AppointmentData appointment);
        void DeleteAppointment(AppointmentData appointment);
    }
}
