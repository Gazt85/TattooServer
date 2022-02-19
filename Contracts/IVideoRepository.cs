using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IVideoRepository
    {
        Task<IEnumerable<Video>> GetAllVideosAsync(bool trackChanges);
        Task<Video> GetVideoAsync(Guid videoId, bool trackChanges);
        void CreateVideo(Video video);
        void DeleteVideo(Video video);
    }
}
