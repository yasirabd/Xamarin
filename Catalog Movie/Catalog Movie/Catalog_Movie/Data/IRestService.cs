using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog_Movie.Models;

namespace Catalog_Movie.Data
{
    public interface IRestService
    {
        Task RefreshDataAsync();
    }
}
