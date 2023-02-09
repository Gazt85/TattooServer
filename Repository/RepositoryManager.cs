using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager 
    {
        private RepositoryContext _repositoryContext;

        private IUserRepository _userRepository;
        private IAppointmentRepository _appointmentRepository;
        private IBlogItemRepository _blogItemRepository;
        private IBlogPostRepository _blogPostRepository;
        private IProductRepository _productRepository;
        private IVideoRepository _videoRepository;     
        private IClientRepository _clientRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_repositoryContext);

                return _userRepository;
            }
        }

        public IClientRepository Client
        {
            get
            {
                if (_clientRepository == null)
                    _clientRepository = new ClientRepository(_repositoryContext);

                return _clientRepository;
            }
        }

        public IAppointmentRepository Appointment
        {
            get
            {
                if (_appointmentRepository == null)
                    _appointmentRepository = new AppointmentRepository(_repositoryContext);

                return _appointmentRepository;
            }
        }

        public IBlogItemRepository BlogItem
        {
            get
            {
                if (_blogItemRepository == null)
                    _blogItemRepository = new BlogItemRepository(_repositoryContext);

                return _blogItemRepository;
            }
        }

        public IBlogPostRepository BlogPost
        {
            get
            {
                if (_blogPostRepository == null)
                    _blogPostRepository = new BlogPostRepository(_repositoryContext);

                return _blogPostRepository;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_repositoryContext);

                return _productRepository;
            }
        }

        public IVideoRepository Video
        {
            get
            {
                if (_videoRepository == null)
                    _videoRepository = new VideoRepository(_repositoryContext);

                return _videoRepository;
            }
        }

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
