using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<AppointmentData>> GetAllApointmentsAsync(bool trackChanges);
        Task<AppointmentData> GetAppointmentAsync(Guid appointmentId, bool trackChanges);
        void CreateAppointment(AppointmentData appointment);
        void DeleteAppointment(AppointmentData appointment);
    }
}
