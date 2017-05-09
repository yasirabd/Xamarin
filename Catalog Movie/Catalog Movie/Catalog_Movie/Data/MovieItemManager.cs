using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog_Movie.Data;

namespace Catalog_Movie.Data
{
    public class MovieItemManager
    {
        IRestService restService;

        public MovieItemManager(IRestService service)
        {
            restService = service;
        }

        public Task GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }
    }
}
