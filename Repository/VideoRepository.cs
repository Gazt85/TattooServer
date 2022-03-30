using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VideoRepository : RepositoryBase<Video>, IVideoRepository
    {
        public VideoRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {

        }

        public async Task<PagedList<Video>> GetAllVideosAsync(VideoParameters videoParameters, bool trackChanges)
        {
            var videos = await FindAll(trackChanges)
           .OrderBy(v => v.Date)
           .ToListAsync();

            return PagedList<Video>
              .ToPagedList(videos, videoParameters.PageNumber, videoParameters.PageSize);
        }
           

        public async Task<Video> GetVideoAsync(Guid videoId, bool trackChanges) =>
            await FindByCondition(v => v.Id.Equals(videoId), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateVideo(Video video) => Create(video);

        public void DeleteVideo(Video video) => Delete(video);
    }
}
