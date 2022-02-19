using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        IClientRepository Client { get; }
        IProductRepository Product { get; }
        IAppointmentRepository Appointment { get; }
        IBlogItemRepository BlogItem { get; }
        IBlogPostRepository BlogPost { get; }
        IVideoRepository Video { get; }

        Task SaveAsync();
    }
}
