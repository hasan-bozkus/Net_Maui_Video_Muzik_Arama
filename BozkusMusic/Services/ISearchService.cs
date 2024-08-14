using BozkusMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozkusMusic.Services
{
    public interface ISearchService
    {
        Task<List<Video>> GetVideoBySearch(string searchText);
    }
}
