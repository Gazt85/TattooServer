using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IVideoRepository
    {
        Task<PagedList<Video>> GetAllVideosAsync(VideoParameters videoParameters ,bool trackChanges);
        Task<Video> GetVideoAsync(Guid videoId, bool trackChanges);
        void CreateVideo(Video video);
        void DeleteVideo(Video video);
    }
}
