using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AppointmentRepository : RepositoryBase<AppointmentData>, IAppointmentRepository
    {
        public AppointmentRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {

        }

        public async Task<IEnumerable<AppointmentData>> GetAllApointmentsAsync(bool trackChanges) =>
           await FindAll(trackChanges)
           .OrderBy(a => a.StartDateTime)
           .ToListAsync();

        public async Task<AppointmentData> GetAppointmentAsync(Guid appointmentId, bool trackChanges) =>
            await FindByCondition(a => a.Id.Equals(appointmentId), trackChanges)
            .SingleOrDefaultAsync();


        public void CreateAppointment(AppointmentData appointment) => Create(appointment);


        public void DeleteAppointment(AppointmentData appointment) => Delete(appointment);
    }
}
